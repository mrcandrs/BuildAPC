using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;
using System.Reflection.Emit;
using System.Security.Cryptography;

namespace WindowsFormsApp1
{
    public partial class ReceiptForm : Form
    {
        Random random = new Random();
        public string mohterboard { get; set; }
        public string gpu { get; set; }
        public string cpu { get; set; }
        public string ram { get; set; }
        public string psu { get; set; }
        public string ssd { get; set; }
        public string hdd { get; set; }
        public string fan { get; set; }
        public string monitor { get; set; }
        public string keyboard { get; set; }
        public string mouse { get; set; }
        public string name { get; set; }
        public string nameid { get; set; }

        public string email { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string province { get; set; }
        public string zipcode { get; set; }
        public string contact { get; set; }

        public double a1 { get; set; }
        public double a2 { get; set; }
        public double a3 { get; set; }
        public double a4 { get; set; }
        public double a5 { get; set; }
        public double a6 { get; set; }
        public double a7 { get; set; }
        public double a8 { get; set; }
        public double a9 { get; set; }
        public double a10 { get; set; }
        public double a11 { get; set; }

        public double totals { get; set; }
        public string payment { get; set; }
        public double change { get; set; }



        public ReceiptForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private async void Form7_Load(object sender, EventArgs e)
        {

            string todaydate = DateTime.Now.ToString("yyyMMdd");
            string randomnum = random.Next(1000, 9999).ToString();
            string randomnumber = randomnum + todaydate;

            string date = DateTime.Now.ToString("yyyy/MM/dd");






            string n = "Name: ";
            string id = "ID";
            string a = "Mother Board:";
            string b = "Graphics card(GPU):          ";
            string c = "Processor (CPU):             ";
            string d = "Power Supply Unit(PSU):      ";
            string p = "Random Acces Memory (RAM):   ";
            string f = "Solid State Drive(SSD):      ";
            string g = "Hard Disc(HDD):              ";
            string h = "Fan:                         ";
            string i = "Monitor:                     ";
            string j = "Keyboard:                    ";
            string k = "Mouse:                       ";

            label59.Text = "DATE:  ";
            label41.Text = date;

            label39.Text = "RECEIPT";


            label40.Text = "---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------";

            label56.Text = "Parts";
            label57.Text = "Quantity";
            label58.Text = "Price";




            label16.Text = a;
            label3.Text = mohterboard;
            label45.Text = "₱" + a1.ToString();



            label17.Text = b;
            label4.Text = gpu;
            label46.Text = "₱" + a2.ToString();



            label18.Text = c;
            label5.Text = cpu;
            label47.Text = "₱" + a3.ToString();



            label19.Text = d;
            label6.Text = ram;
            label48.Text = "₱" + a4.ToString();



            label20.Text = p;
            label7.Text = psu;
            label49.Text = "₱" + a5.ToString();



            label21.Text = f;
            label8.Text = ssd;
            label50.Text = "₱" + a6.ToString();



            label22.Text = g;
            label9.Text = hdd;
            label51.Text = "₱" + a7.ToString();



            label23.Text = h;
            label10.Text = fan;
            label52.Text = "₱" + a8.ToString();



            label24.Text = i;
            label11.Text = monitor;
            label53.Text = "₱" + a9.ToString();



            label25.Text = j;
            label12.Text = keyboard;
            label54.Text = "₱" + a10.ToString();


            label26.Text = k;
            label13.Text = mouse;
            label55.Text = "₱" + a11.ToString();


            label42.Text = "---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------";

            //Label 3 at the buttom

            label62.Text = "Total: ";
            label43.Text = "₱" + totals.ToString();


            labelusername.Text = name;
            label14.Text = n;



            labelID.Text = nameid;
            label15.Text = id;
            label44.Text = "Payment: ";
            label63.Text = payment;




            label64.Text = "---------------------------------------------";


            label34.Text = address;
            label28.Text = "Address:            ";
            label66.Text = "Change: ";
            label65.Text = change.ToString();


            label35.Text = city;
            label29.Text = "City/Municipality:  ";


            label36.Text = province;
            label30.Text = "Province:";


            label37.Text = zipcode;
            label31.Text = "Zip Code:           ";


            label38.Text = contact;
            label32.Text = "Contact Number:     ";


            label61.Text = randomnumber;
            label60.Text = "Receipt no.         ";


            label33.Text = email;
            label27.Text = "Email: ";

            string connectionString = "Data Source=DESKTOP-5A8FMDF;Initial Catalog=buildapc;Integrated Security=True;TrustServerCertificate=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO [dbo].[payment] ([receiptno], [CustomerID], [Name]) " +
                               "VALUES (@receiptno, @CustomerID, @Name)";
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Use parameters to prevent SQL injection
                    cmd.Parameters.AddWithValue("@receiptno", randomnumber);
                    cmd.Parameters.AddWithValue("@CustomerID", nameid);
                    cmd.Parameters.AddWithValue("@Name", name);


                    // Open the connection and execute the command
 
                    cmd.ExecuteNonQuery();


                }
                con.Close();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Would you like to make another purchase?", "Build-A-PC", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                OrderingForm order = new OrderingForm(labelusername.Text, labelID.Text);
                order.Show();
                this.Hide();
            }
            else
            {
                DialogResult dialog2 = MessageBox.Show("You have been logged out.", "Build-A-PC", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                if (dialog2 == DialogResult.OK)
                {
                    LoginForm login = new LoginForm();
                    login.Show();
                    this.Hide();
                }
            }
        }
    }
}


       