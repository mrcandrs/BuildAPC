using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1
{
    public partial class OrderingForm : Form
    {
        //placeholders for the userName and id
        public string uName;
        public string customer_id;
        public OrderingForm(string uName, string customer_id)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            label_Username.Text = uName;
            label1.Text = customer_id;
        }

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]

        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]

        private static extern bool ReleaseCapture();

        public OrderingForm() : this(string.Empty, string.Empty)
        {

        }

        // this will dictate the text in the combobox
        public int forCombobox = 0;

        // for updating the text of the comboboxes
        public string cb1Text;
        public string cb2Text;
        public string cb3Text;
        public string cb4Text;
        public string cb5Text;
        public string cb6Text;
        public string cb7Text;
        public string cb8Text;
        public string cb9Text;
        public string cb10Text;
        public string cb11Text;

        private void Form5_Load(object sender, EventArgs e)
        {
            if (forCombobox == 0)
            {
                comboBox1.Text = "None";
                comboBox2.Text = "None";
                comboBox3.Text = "None";
                comboBox4.Text = "None";
                comboBox5.Text = "None";
                comboBox6.Text = "None";
                comboBox7.Text = "None";
                comboBox8.Text = "None";
                comboBox9.Text = "None";
                comboBox10.Text = "None";
                comboBox11.Text = "None";

                label2.Text = "0.00";
                label15.Text = "0.00";
                label16.Text = "0.00";
                label17.Text = "0.00";
                label18.Text = "0.00";
                label19.Text = "0.00";
                label20.Text = "0.00";
                label21.Text = "0.00";
                label22.Text = "0.00";
                label23.Text = "0.00";
                label24.Text = "0.00";
            }
            if (forCombobox == 1)
            {
                comboBox1.Text = cb1Text;
                comboBox2.Text = cb2Text;
                comboBox3.Text = cb3Text;
                comboBox4.Text = cb4Text;
                comboBox5.Text = cb5Text;
                comboBox6.Text = cb6Text;
                comboBox7.Text = cb7Text;
                comboBox8.Text = cb8Text;
                comboBox9.Text = cb9Text;
                comboBox10.Text = cb10Text;
                comboBox11.Text = cb11Text;
            }

            //Set DecimalPlaces to 0 for all NumericUpDown controls
            numericUpDown1.DecimalPlaces = 0;
            numericUpDown2.DecimalPlaces = 0;
            numericUpDown3.DecimalPlaces = 0;
            numericUpDown4.DecimalPlaces = 0;
            numericUpDown5.DecimalPlaces = 0;
            numericUpDown6.DecimalPlaces = 0;
            numericUpDown7.DecimalPlaces = 0;
            numericUpDown8.DecimalPlaces = 0;
            numericUpDown9.DecimalPlaces = 0;
            numericUpDown10.DecimalPlaces = 0;
            numericUpDown11.DecimalPlaces = 0;

            //Add KeyPress event handlers
            numericUpDown1.KeyPress += NumericUpDown_KeyPress;
            numericUpDown2.KeyPress += NumericUpDown_KeyPress;
            numericUpDown3.KeyPress += NumericUpDown_KeyPress;
            numericUpDown4.KeyPress += NumericUpDown_KeyPress;
            numericUpDown5.KeyPress += NumericUpDown_KeyPress;
            numericUpDown6.KeyPress += NumericUpDown_KeyPress;
            numericUpDown7.KeyPress += NumericUpDown_KeyPress;
            numericUpDown8.KeyPress += NumericUpDown_KeyPress;
            numericUpDown9.KeyPress += NumericUpDown_KeyPress;
            numericUpDown10.KeyPress += NumericUpDown_KeyPress;
            numericUpDown11.KeyPress += NumericUpDown_KeyPress;
        }

        private void NumericUpDown_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Prevent the user from entering decimal points
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // instance
            Items items = new Items(comboBox1.Text, comboBox2.Text, comboBox3.Text, comboBox4.Text, comboBox5.Text, comboBox6.Text, comboBox7.Text, comboBox8.Text, comboBox9.Text, comboBox10.Text, comboBox11.Text);

            string connectionString = "Data Source=DESKTOP-5A8FMDF;Initial Catalog=buildapc;Integrated Security=True;TrustServerCertificate=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query1 = "INSERT INTO [dbo].[mainParts] ([Motherboard], [GPU], [CPU], [Name]) VALUES (@Motherboard, @GPU, @CPU, @Name)";
                string query2 = "INSERT INTO [dbo].[secondaryParts] ([RAM], [PSU], [SSD], [HDD], [Name]) VALUES (@RAM, @PSU, @SSD, @HDD, @Name)";
                string query3 = "INSERT INTO [dbo].[extraParts] ([FAN], [Monitor], [Keyboard], [Mouse], [Name]) VALUES (@FAN, @Monitor, @Keyboard, @Mouse, @Name)";

                con.Open();

                using (SqlCommand cmd = new SqlCommand(query1, con))
                {
                    cmd.Parameters.AddWithValue("@Motherboard", items.Motherboard);
                    cmd.Parameters.AddWithValue("@GPU", items.GPU);
                    cmd.Parameters.AddWithValue("@CPU", items.CPU);
                    cmd.Parameters.AddWithValue("@Name", label_Username.Text);
                    cmd.ExecuteNonQuery();
                }

                using (SqlCommand cmd1 = new SqlCommand(query2, con))
                {
                    cmd1.Parameters.AddWithValue("@RAM", items.RAM);
                    cmd1.Parameters.AddWithValue("@PSU", items.PSU);
                    cmd1.Parameters.AddWithValue("@SSD", items.SSD);
                    cmd1.Parameters.AddWithValue("@HDD", items.HDD);
                    cmd1.Parameters.AddWithValue("@Name", label_Username.Text);
                    cmd1.ExecuteNonQuery();
                }

                using (SqlCommand cmd2 = new SqlCommand(query3, con))
                {
                    cmd2.Parameters.AddWithValue("@FAN", items.FAN);
                    cmd2.Parameters.AddWithValue("@Monitor", items.Monitor);
                    cmd2.Parameters.AddWithValue("@Keyboard", items.Keyboard);
                    cmd2.Parameters.AddWithValue("@Mouse", items.Mouse);
                    cmd2.Parameters.AddWithValue("@Name", label_Username.Text);
                    cmd2.ExecuteNonQuery();
                }

                con.Close();
            }


            //update the text of labels in form 6
            ConfirmationForm form6 = new ConfirmationForm(label_Username.Text, label1.Text);

            try
            {
                {
                    form6.uName = label_Username.Text;
                    form6.customer_id = label1.Text;
                    //Convert the label values to double
                    double p1 = 0, p2 = 0, p3 = 0, p4 = 0, p5 = 0, p6 = 0, p7 = 0, p8 = 0, p9 = 0, p10 = 0, p11 = 0;
                    string lab1 = label2.Text;
                    string lab2 = label15.Text;
                    string lab3 = label16.Text;
                    string lab4 = label17.Text;
                    string lab5 = label18.Text;
                    string lab6 = label19.Text;
                    string lab7 = label20.Text;
                    string lab8 = label21.Text;
                    string lab9 = label22.Text;
                    string lab10 = label23.Text;
                    string lab11 = label24.Text;


                    if (!string.IsNullOrEmpty(lab1))
                        p1 = Convert.ToDouble(lab1);
                    if (!string.IsNullOrEmpty(lab2))
                        p2 = Convert.ToDouble(lab2);
                    if (!string.IsNullOrEmpty(lab3))
                        p3 = Convert.ToDouble(lab3);
                    if (!string.IsNullOrEmpty(lab4))
                        p4 = Convert.ToDouble(lab4);
                    if (!string.IsNullOrEmpty(lab5))
                        p5 = Convert.ToDouble(lab5);
                    if (!string.IsNullOrEmpty(lab6))
                        p6 = Convert.ToDouble(lab6);
                    if (!string.IsNullOrEmpty(lab7))
                        p7 = Convert.ToDouble(lab7);
                    if (!string.IsNullOrEmpty(lab8))
                        p8 = Convert.ToDouble(lab8);
                    if (!string.IsNullOrEmpty(lab9))
                        p9 = Convert.ToDouble(lab9);
                    if (!string.IsNullOrEmpty(lab10))
                        p10 = Convert.ToDouble(lab10);
                    if (!string.IsNullOrEmpty(lab11))
                        p11 = Convert.ToDouble(lab11);

                    //Pass the double values to ConfirmationForm
                    form6.price1 = p1;
                    form6.price2 = p2;
                    form6.price3 = p3;
                    form6.price4 = p4;
                    form6.price5 = p5;
                    form6.price6 = p6;
                    form6.price7 = p7;
                    form6.price8 = p8;
                    form6.price9 = p9;
                    form6.price10 = p10;
                    form6.price11 = p11;

                    //Pass other item texts to ConfirmationForm
                    form6.mbText = items.MOTHERBOARD;
                    form6.gcText = items.GPU;
                    form6.cpuText = items.CPU;
                    form6.ramText = items.RAM;
                    form6.psuText = items.PSU;
                    form6.ssdText = items.SSD;
                    form6.hddText = items.HDD;
                    form6.fanText = items.FAN;
                    form6.monitorText = items.MONITOR;
                    form6.keyboardText = items.KEYBOARD;
                    form6.mouseText = items.MOUSE;


                    //Show ConfirmationForm
                    this.Hide();
                    form6.ShowDialog();
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error: " + ex.Message + "\nPlease enter valid numerical values for prices.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
            private void button1_Click(object sender, EventArgs e)
            {
                // clearing the comboboxes
                string comboTextNull = "None";
                comboBox1.Text = comboTextNull;
                comboBox2.Text = comboTextNull;
                comboBox3.Text = comboTextNull;
                comboBox4.Text = comboTextNull;
                comboBox5.Text = comboTextNull;
                comboBox6.Text = comboTextNull;
                comboBox7.Text = comboTextNull;
                comboBox8.Text = comboTextNull;
                comboBox9.Text = comboTextNull;
                comboBox10.Text = comboTextNull;
                comboBox11.Text = comboTextNull;

                label2.Text = "0.00";
                label15.Text = "0.00";
                label16.Text = "0.00";
                label17.Text = "0.00";
                label18.Text = "0.00";
                label19.Text = "0.00";
                label20.Text = "0.00";
                label21.Text = "0.00";
                label22.Text = "0.00";
                label23.Text = "0.00";
                label24.Text = "0.00";
            }
        // sign out
        private void label3_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            this.Hide();
            form.ShowDialog();
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void button_Home_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, button_Home.ClientRectangle,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        private void button_Order_Paint(object sender, PaintEventArgs e)
        {

            ControlPaint.DrawBorder(e.Graphics, button_Order.ClientRectangle,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        private void button_AboutUs_Paint(object sender, PaintEventArgs e)
        {

            ControlPaint.DrawBorder(e.Graphics, button_AboutUs.ClientRectangle,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        private void button_Products_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, button_Products.ClientRectangle,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        private void button_Back_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, button_Back.ClientRectangle,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        private void button_LogOut_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, button_LogOut.ClientRectangle,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        private void button_Clear_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, button_Clear.ClientRectangle,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        private void button_Proceed_to_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, button_Proceed_to.ClientRectangle,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Exit the Application?", "Build-A-PC", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //check if the click was on the title bar
                if (e.Clicks == 1 && e.Y <= this.Height && e.Y >= 0)
                {
                    ReleaseCapture();
                    SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            }
        }
        //motherboard
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice1();
        }
        //GPU
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice2();
        }
        //CPU
        private void comboBox3_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            UpdateTotalPrice3();
        }
        //RAM
        private void comboBox4_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            UpdateTotalPrice4();
        }
        //PSU
        private void comboBox5_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            UpdateTotalPrice5();
        }
        //SSD
        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice6();
        }
        //HDD
        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice7();
        }
        //FAN
        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice8();
        }
        //Monitor
        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice9();
        }
        //Keyboard
        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice10();
        }
        //Mouse
        private void comboBox11_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            UpdateTotalPrice11();
        }

        //Motherboard method
        private void UpdateTotalPrice1()
        {
            double price = 0.0;

            if (comboBox1.Text.Contains("ASRock"))
            {
                price = 5888.75;
            }
            else if (comboBox1.Text.Contains("ASUS"))
            {
                price = 4999.75;
            }
            else if (comboBox1.Text.Contains("MSI"))
            {
                price = 4499.50;
            }
            else if (comboBox1.Text.Contains("Gigabyte"))
            {
                price = 3995.50;
            }
            else if (comboBox1.Text.Contains("EVGA"))
            {
                price = 3500.75;
            }

            double quantity = Convert.ToDouble(numericUpDown1.Value);
            double total = price * quantity;
            label2.Text = total.ToString();
        }
        //GPU method
        private void UpdateTotalPrice2()
        {
            double price = 0.0;

            if (comboBox2.Text.Contains("560"))
            {
                price = 2499.75;
            }
            else if (comboBox2.Text.Contains("3070"))
            {
                price = 2300.75;
            }
            else if (comboBox2.Text.Contains("2070"))
            {
                price = 2399.75;
            }
            else if (comboBox2.Text.Contains("980"))
            {
                price = 2100.75;
            }
            else if (comboBox2.Text.Contains("6900"))
            {
                price = 1995.75;
            }

            double quantity = Convert.ToDouble(numericUpDown2.Value);
            double total = price * quantity;
            label15.Text = total.ToString();
        }
        //CPU method
        private void UpdateTotalPrice3()
        {
            double price = 0.0;

            if (comboBox3.Text.Contains("5600X"))
            {
                price = 8900.75;
            }
            else if (comboBox3.Text.Contains("5900X"))
            {
                price = 8995.75;
            }
            else if (comboBox3.Text.Contains("11600K"))
            {
                price = 9499.75;
            }
            else if (comboBox3.Text.Contains("11700K"))
            {
                price = 9975.50;
            }
            else if (comboBox3.Text.Contains("3970X"))
            {
                price = 8499.75;
            }

            double quantity = Convert.ToDouble(numericUpDown3.Value);
            double total = price * quantity;
            label16.Text = total.ToString();
        }
        //RAM method
        private void UpdateTotalPrice4()
        {
            double price = 0.0;

            if (comboBox4.Text.Contains("Corsair"))
            {
                price = 2999.75;
            }
            else if (comboBox4.Text.Contains("Kingston"))
            {
                price = 2995.50;
            }
            else if (comboBox4.Text.Contains("Crucial"))
            {
                price = 2499.75;
            }
            else if (comboBox4.Text.Contains("Team"))
            {
                price = 1995.25;
            }
            else if (comboBox4.Text.Contains("ADATA"))
            {
                price = 2499.75;
            }

            double quantity = Convert.ToDouble(numericUpDown4.Value);
            double total = price * quantity;
            label17.Text = total.ToString();
        }
        //PSU method
        private void UpdateTotalPrice5()
        {
            double price = 0.0;

            if (comboBox5.Text.Contains("Corsair"))
            {
                price = 4888.75;
            }
            else if (comboBox5.Text.Contains("EVGA"))
            {
                price = 3995.75;
            }
            else if (comboBox5.Text.Contains("Seasonic"))
            {
                price = 4499.25;
            }
            else if (comboBox5.Text.Contains("Cooler"))
            {
                price = 2999.75;
            }
            else if (comboBox5.Text.Contains("Thermaltake"))
            {
                price = 3499.50;
            }

            double quantity = Convert.ToDouble(numericUpDown5.Value);
            double total = price * quantity;
            label18.Text = total.ToString();
        }
        //SSD method
        private void UpdateTotalPrice6()
        {
            double price = 0.0;

            if (comboBox6.Text.Contains("WD"))
            {
                price = 3888.75;
            }
            else if (comboBox6.Text.Contains("Samsung"))
            {
                price = 2996.80;
            }
            else if (comboBox6.Text.Contains("Corsair"))
            {
                price = 3499.75;
            }
            else if (comboBox6.Text.Contains("ADATA"))
            {
                price = 2999.50;
            }
            else if (comboBox6.Text.Contains("Kingston"))
            {
                price = 3499.50;
            }

            double quantity = Convert.ToDouble(numericUpDown11.Value);
            double total = price * quantity;
            label19.Text = total.ToString();
        }
        //HDD method
        private void UpdateTotalPrice7()
        {
            double price = 0.0;

            if (comboBox7.Text.Contains("Blue"))
            {
                price = 4499.50;
            }
            else if (comboBox7.Text.Contains("Seagate"))
            {
                price = 4299.80;
            }
            else if (comboBox7.Text.Contains("Toshiba"))
            {
                price = 4399.75;
            }
            else if (comboBox7.Text.Contains("Red"))
            {
                price = 4095.75;
            }
            else if (comboBox7.Text.Contains("IronWolf"))
            {
                price = 3999.75;
            }

            double quantity = Convert.ToDouble(numericUpDown6.Value);
            double total = price * quantity;
            label20.Text = total.ToString();
        }
        //FAN method
        private void UpdateTotalPrice8()
        {
            double price = 0.0;

            if (comboBox8.Text.Contains("Cooler"))
            {
                price = 2299.45;
            }
            else if (comboBox8.Text.Contains("Noctua"))
            {
                price = 2099.75;
            }
            else if (comboBox8.Text.Contains("Corsair"))
            {
                price = 2499.75;
            }
            else if (comboBox8.Text.Contains("Thermaltake"))
            {
                price = 1999.75;
            }
            else if (comboBox8.Text.Contains("Scythe"))
            {
                price = 2499.50;
            }

            double quantity = Convert.ToDouble(numericUpDown7.Value);
            double total = price * quantity;
            label21.Text = total.ToString();
        }
        //Monitor method
        private void UpdateTotalPrice9()
        {
            double price = 0.0;

            if (comboBox9.Text.Contains("ViewSonic"))
            {
                price = 4888.50;
            }
            else if (comboBox9.Text.Contains("Acer"))
            {
                price = 3999.75;
            }
            else if (comboBox9.Text.Contains("BenQ"))
            {
                price = 4499.75;
            }
            else if (comboBox9.Text.Contains("Dell"))
            {
                price = 3999.75;
            }
            else if (comboBox9.Text.Contains("LG"))
            {
                price = 4499.50;
            }

            double quantity = Convert.ToDouble(numericUpDown8.Value);
            double total = price * quantity;
            label22.Text = total.ToString();
        }
        //Keyboard method
        private void UpdateTotalPrice10()
        {
            double price = 0.0;

            if (comboBox10.Text.Contains("Logitech"))
            {
                price = 1599.75;
            }
            else if (comboBox10.Text.Contains("Razer"))
            {
                price = 999.75;
            }
            else if (comboBox10.Text.Contains("Corsair"))
            {
                price = 1499.75;
            }
            else if (comboBox10.Text.Contains("HyperX"))
            {
                price = 999.99;
            }
            else if (comboBox10.Text.Contains("SteelSeries"))
            {
                price = 1499.50;
            }

            double quantity = Convert.ToDouble(numericUpDown9.Value);
            double total = price * quantity;
            label23.Text = total.ToString();
        }
        //Mouse method
        private void UpdateTotalPrice11()
        {
            double price = 0.0;

            if (comboBox11.Text.Contains("MX"))
            {
                price = 888.50;
            }
            else if (comboBox11.Text.Contains("Razer"))
            {
                price = 700.75;
            }
            else if (comboBox11.Text.Contains("SteelSeries"))
            {
                price = 500.25;
            }
            else if (comboBox11.Text.Contains("HyperX"))
            {
                price = 900.25;
            }
            else if (comboBox11.Text.Contains("G502"))
            {
                price = 300.50;
            }

            double quantity = Convert.ToDouble(numericUpDown10.Value);
            double total = price * quantity;
            label24.Text = total.ToString();
        }


        private void button_Order_Click(object sender, EventArgs e)
        {
            OrderingForm order = new OrderingForm(label_Username.Text, label1.Text);
            this.Hide();
            this.ShowDialog();
        }

        private void button_AboutUs_Click(object sender, EventArgs e)
        {
            AboutUs aboutUs = new AboutUs(label_Username.Text, label1.Text);
            this.Show();
            this.Hide();
            aboutUs.ShowDialog();
        }

        private void button_Products_Click(object sender, EventArgs e)
        {
            Products products = new Products(label_Username.Text, label1.Text);
            this.Show();
            this.Hide();
            products.ShowDialog();
        }

        private void button_Back_Click(object sender, EventArgs e) //back button
        {
            Dashboard dashboard = new Dashboard(label_Username.Text, label1.Text);
            this.Hide();
            dashboard.ShowDialog();
        }

        private void button_LogOut_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to log out?", "Build-A-PC", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                DialogResult dialog2 = MessageBox.Show("You have been logged out.", "Build-A-PC", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                if (dialog2 == DialogResult.OK)
                {
                    LoginForm login = new LoginForm();
                    this.Hide();
                    login.ShowDialog();
                }
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice1();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice2();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice3();
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice4();
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice5();
        }

        private void numericUpDown11_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice6();
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice7();
        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice8();
        }

        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice9();
        }

        private void numericUpDown9_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice10();
        }

        private void numericUpDown10_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice11();
        }

        private void button_Home_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(label_Username.Text, label1.Text);
            this.Hide();
            dashboard.Show();
        }
    }
}
