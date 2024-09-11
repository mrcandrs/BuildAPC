using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using System.Text.RegularExpressions;
using BuildAPC;

namespace WindowsFormsApp1
{

    public partial class ConfirmationForm : Form
    {
        // placeholders for the userName and id
        public string uName;
        public string customer_id;

        public ConfirmationForm(string uName, string customer_id)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            lblName.Text = uName;
            lbl_ID.Text = customer_id;

        }

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]

        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]


        private static extern bool ReleaseCapture();

        public double price1;
        public double price2;
        public double price3;
        public double price4;
        public double price5;
        public double price6;
        public double price7;
        public double price8;
        public double price9;
        public double price10;
        public double price11;

        public string mbText;
        public string gcText;
        public string cpuText;
        public string ramText;
        public string psuText;
        public string ssdText;
        public string hddText;
        public string fanText;
        public string monitorText;
        public string keyboardText;
        public string mouseText;


        private void button1_Click(object sender, EventArgs e) // Back button
        {
            OrderingForm form5 = new OrderingForm();
            form5.label_Username.Text = uName;
            form5.label1.Text = customer_id;
            form5.forCombobox = 0;
            form5.cb1Text = mbText;
            form5.cb2Text = gcText;
            form5.cb3Text = cpuText;
            form5.cb4Text = ramText;
            form5.cb5Text = psuText;
            form5.cb6Text = ssdText;
            form5.cb7Text = hddText;
            form5.cb8Text = fanText;
            form5.cb9Text = monitorText;
            form5.cb10Text = keyboardText;
            form5.cb11Text = mouseText;
            this.Hide();
            form5.ShowDialog();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            label1.Text = mbText;
            label2.Text = gcText;
            label3.Text = cpuText;
            label4.Text = ramText;
            label5.Text = psuText;
            label6.Text = ssdText;
            label7.Text = hddText;
            label8.Text = fanText;
            label9.Text = monitorText;
            label10.Text = keyboardText;
            label11.Text = mouseText;

            double total = price1 + price2 + price3 + price4 + price5 + price6 + price7 + price8 + price9 + price10 + price11;
            label30.Text = total.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxEmail.Text))
            {
                MessageBox.Show("Please enter your email address.", "Build-A-PC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the entered email is in a valid format
            if (!IsValidEmail(textBoxEmail.Text))
            {
                MessageBox.Show("Please enter a valid email address.", "Build-A-PC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (textBoxAddress.Text == "")
            {
                MessageBox.Show("Please enter your address.", "Build-A-PC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (textBoxProvince.Text == "")
            {
                MessageBox.Show("Please enter your province.", "Build-A-PC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (textBoxCity.Text == "")
            {
                MessageBox.Show("Please enter your city.", "Build-A-PC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (textBoxzipcode.Text == "")
            {
                MessageBox.Show("Please enter your ZIP Code.", "Build-A-PC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (textBoxContact.Text == "")
            {
                MessageBox.Show("Please enter your Contact Number.", "Build-A-PC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (input_amount.Text == "")
            {
                MessageBox.Show("Please enter your payment amount.", "Build-A-PC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(input_amount.Text, out double paymentAmount))
            {
                MessageBox.Show("Please enter a valid payment amount.", "Build-A-PC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(label30.Text, out double totalAmount))
            {
                MessageBox.Show("Error in calculating total amount.", "Build-A-PC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Compare the payment amount with the total amount
            if (paymentAmount < totalAmount)
            {
                MessageBox.Show("Payment amount is less than the total amount.", "Build-A-PC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double changeAmount = paymentAmount - totalAmount;

            // Ensure the change amount is non-negative
            if (changeAmount < 0)
            {
                label34.Text = changeAmount.ToString();
            }

            ReceiptForm form = new ReceiptForm();
            form.mohterboard = label1.Text;
            form.gpu = label2.Text;
            form.cpu = label3.Text;
            form.ram = label4.Text;
            form.psu = label5.Text;
            form.ssd = label6.Text;
            form.hdd = label7.Text;
            form.fan = label8.Text;
            form.monitor = label9.Text;
            form.keyboard = label10.Text;
            form.mouse = label11.Text;
            form.name = lblName.Text;
            form.nameid = lbl_ID.Text;
            form.email = textBoxEmail.Text;
            form.address = textBoxAddress.Text;
            form.city = textBoxCity.Text;
            form.province = textBoxProvince.Text;
            form.zipcode = textBoxzipcode.Text;
            form.contact = textBoxContact.Text;

            form.a1 = price1;
            form.a2 = price2;
            form.a3 = price3;
            form.a4 = price4;
            form.a5 = price5;
            form.a6 = price6;
            form.a7 = price7;
            form.a8 = price8;
            form.a9 = price9;
            form.a10 = price10;
            form.a11 = price11;

            double total1 = price1 + price2 + price3 + price4 + price5 + price6 + price7 + price8 + price9 + price10 + price11;





            string amount1 = input_amount.Text;
            double amount2 = Convert.ToDouble(amount1);

            double change1 = amount2 - total1;

            form.payment = amount1;
            form.change = change1;
            form.totals = total1;

            this.Hide();
            form.ShowDialog();

            // Insert the ordered items into the database
            string connectionString = "Data Source=LAPTOP-IB4S6631\\SQLEXPRESS;Initial Catalog=BuildAPC;Integrated Security=True;TrustServerCertificate=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO [dbo].[orderedItems] ([Motherboard], [GPU], [CPU], [RAM], [PSU], [SSD], [HDD], [FAN], [Monitor], [Keyboard], [Mouse], [Name], [CustomerID]) " +
                               "VALUES (@Motherboard, @GPU, @CPU, @RAM, @PSU, @SSD, @HDD, @FAN, @Monitor, @Keyboard, @Mouse, @Name, @CustomerID)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Use parameters to prevent SQL injection
                    cmd.Parameters.AddWithValue("@Motherboard", mbText);
                    cmd.Parameters.AddWithValue("@GPU", gcText);
                    cmd.Parameters.AddWithValue("@CPU", cpuText);
                    cmd.Parameters.AddWithValue("@RAM", ramText);
                    cmd.Parameters.AddWithValue("@PSU", psuText);
                    cmd.Parameters.AddWithValue("@SSD", ssdText);
                    cmd.Parameters.AddWithValue("@HDD", hddText);
                    cmd.Parameters.AddWithValue("@FAN", fanText);
                    cmd.Parameters.AddWithValue("@Monitor", monitorText);
                    cmd.Parameters.AddWithValue("@Keyboard", keyboardText);
                    cmd.Parameters.AddWithValue("@Mouse", mouseText);
                    cmd.Parameters.AddWithValue("@Name", uName);
                    cmd.Parameters.AddWithValue("@CustomerID", customer_id);

                    // Open the connection and execute the command
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            this.Hide();
            form.ShowDialog();


            QuantityOfItems quantityOfItems = new QuantityOfItems();
            if (label1.Text.Contains("ASRock"))
            {

                if (quantityOfItems.mb1 == 0)
                {
                    MessageBox.Show("No mb1 available.");
                    return;
                }

                quantityOfItems.mb1 -= 1;
                return;
            }
            else if (label1.Text.Contains("Asus"))
            {
                if (quantityOfItems.mb2 == 0)
                {
                    MessageBox.Show("No mb2 available.");
                    return;
                }

                quantityOfItems.mb2 -= 1;
                return;
            }
            else if (label1.Text.Contains("MSI"))
            {
                if (quantityOfItems.mb3 == 0)
                {
                    MessageBox.Show("No mb3 available.");
                    return;
                }

                quantityOfItems.mb3 -= 1;
                return;
            }
            else if (label1.Text.Contains("Gigabyte"))
            {
                if (quantityOfItems.mb4 == 0)
                {
                    MessageBox.Show("No mb4 available.");
                    return;
                }

                quantityOfItems.mb4 -= 1;
                return;
            }
            else if (label1.Text.Contains("EVGA"))
            {
                if (quantityOfItems.mb5 == 0)
                {
                    MessageBox.Show("No mb5 available.");
                    return;
                }
                quantityOfItems.mb5 -= 1;
                return;
            }



            if (label2.Text.Contains("560"))
            {

                if (quantityOfItems.gpu1 == 0)
                {
                    MessageBox.Show("No gpu1 available.");
                    return;
                }

                quantityOfItems.gpu1 -= 1;
                return;
            }
            else if (label2.Text.Contains("3070"))
            {

                if (quantityOfItems.gpu2 == 0)
                {
                    MessageBox.Show("No gpu2 available.");
                    return;
                }

                quantityOfItems.gpu2 -= 1;
                return;
            }
            else if (label2.Text.Contains("2070"))
            {

                if (quantityOfItems.gpu3 == 0)
                {
                    MessageBox.Show("No gpu3 available.");
                    return;
                }

                quantityOfItems.gpu3 -= 1;
                return;
            }
            else if (label2.Text.Contains("980"))
            {
                if (quantityOfItems.gpu4 == 0)
                {
                    MessageBox.Show("No gpu4 available.");
                    return;
                }

                quantityOfItems.gpu4 -= 1;
                return;

            }
            else if (label2.Text.Contains("6900"))
            {

                if (quantityOfItems.gpu5 == 0)
                {
                    MessageBox.Show("No gpu5 available.");
                    return;
                }

                quantityOfItems.gpu5 -= 1;
                return;
            }



            if (label3.Text.Contains("5600X"))
            {

                if (quantityOfItems.cpu1 == 0)
                {
                    MessageBox.Show("No cpu1 available.");
                    return;
                }

                quantityOfItems.cpu1 -= 1;
                return;
            }
            else if (label3.Text.Contains("5900X"))
            {
                if (quantityOfItems.cpu2 == 0)
                {
                    MessageBox.Show("No cpu2 available.");
                    return;
                }

                quantityOfItems.cpu2 -= 1;
                return;
            }
            else if (label3.Text.Contains("11600K"))
            {
                if (quantityOfItems.cpu3 == 0)
                {
                    MessageBox.Show("No cpu3 available.");
                    return;
                }

                quantityOfItems.cpu3 -= 1;
                return;
            }
            else if (label3.Text.Contains("11700K"))
            {
                if (quantityOfItems.cpu4 == 0)
                {
                    MessageBox.Show("No cpu4 available.");
                    return;
                }

                quantityOfItems.cpu4 -= 1;
                return;

            }
            else if (label3.Text.Contains("3970X"))
            {
                if (quantityOfItems.cpu5 == 0)
                {
                    MessageBox.Show("No cpu5 available.");
                    return;
                }

                quantityOfItems.cpu5 -= 1;
                return;
            }




            if (label4.Text.Contains("Corsair"))
            {
                if (quantityOfItems.ram1 == 0)
                {
                    MessageBox.Show("No ram1 available.");
                    return;
                }

                quantityOfItems.ram1 -= 1;
                return;
            }
            else if (label4.Text.Contains("kingston"))
            {
                if (quantityOfItems.ram2 == 0)
                {
                    MessageBox.Show("No ram2 available.");
                    return;
                }

                quantityOfItems.ram2 -= 1;
                return;
            }
            else if (label4.Text.Contains("Crucial"))
            {
                if (quantityOfItems.ram3 == 0)
                {
                    MessageBox.Show("No ram3 available.");
                    return;
                }

                quantityOfItems.ram3 -= 1;
                return;
            }
            else if (label4.Text.Contains("Team group"))
            {
                if (quantityOfItems.ram4 == 0)
                {
                    MessageBox.Show("No ram4 available.");
                    return;
                }

                quantityOfItems.ram4 -= 1;
                return;

            }
            else if (label4.Text.Contains("ADATA"))
            {

                if (quantityOfItems.ram5 == 0)
                {
                    MessageBox.Show("No ram5 available.");
                    return;
                }
                quantityOfItems.ram5 -= 1;
                return;
            }




            if (label5.Text.Contains("Corsair"))
            {
                if (quantityOfItems.psu1 == 0)
                {
                    MessageBox.Show("No psu1 available.");
                    return;
                }
                quantityOfItems.psu1 -= 1;
                return;
            }
            else if (label5.Text.Contains("EVGA"))
            {

                if (quantityOfItems.psu2 == 0)
                {
                    MessageBox.Show("No psu2 available.");
                    return;
                }
                quantityOfItems.psu2 -= 1;
                return;
            }
            else if (label5.Text.Contains("Seasonic"))
            {

                if (quantityOfItems.psu3 == 0)
                {
                    MessageBox.Show("No psu3 available.");
                    return;
                }
                quantityOfItems.psu3 -= 1;
                return;
            }
            else if (label5.Text.Contains("Cooler"))
            {

                if (quantityOfItems.psu4 == 0)
                {
                    MessageBox.Show("No psu4 available.");
                    return;
                }
                quantityOfItems.psu4 -= 1;
                return;

            }
            else if (label5.Text.Contains("Thermaltake"))
            {

                if (quantityOfItems.psu5 == 0)
                {
                    MessageBox.Show("No psu5 available.");
                    return;
                }
                quantityOfItems.psu5 -= 1;
                return;
            }


            if (label6.Text.Contains("WD"))
            {

                if (quantityOfItems.ssd1 == 0)
                {
                    MessageBox.Show("No ssd1 available.");
                    return;
                }
                quantityOfItems.ssd1 -= 1;
                return;
            }
            else if (label6.Text.Contains("Samsung"))
            {

                if (quantityOfItems.ssd2 == 0)
                {
                    MessageBox.Show("No ssd2 available.");
                    return;
                }
                quantityOfItems.ssd2 -= 1;
                return;
            }
            else if (label6.Text.Contains("Corsair"))
            {

                if (quantityOfItems.ssd3 == 0)
                {
                    MessageBox.Show("No ssd3 available.");
                    return;
                }
                quantityOfItems.ssd3 -= 1;
                return;
            }
            else if (label6.Text.Contains("ADATA"))
            {

                if (quantityOfItems.ssd4 == 0)
                {
                    MessageBox.Show("No ssd4 available.");
                    return;
                }
                quantityOfItems.ssd4 -= 1;
                return;

            }
            else if (label6.Text.Contains("Kingston"))
            {

                if (quantityOfItems.ssd5 == 0)
                {
                    MessageBox.Show("No ssd5 available.");
                    return;
                }
                quantityOfItems.ssd5 -= 1;
                return;
            }



            if (label7.Text.Contains("Blue"))
            {

                if (quantityOfItems.hdd1 == 0)
                {
                    MessageBox.Show("No hdd1 available.");
                    return;
                }
                quantityOfItems.hdd1 -= 1;
                return;
            }
            else if (label7.Text.Contains("BarraCuda"))
            {

                if (quantityOfItems.hdd2 == 0)
                {
                    MessageBox.Show("No hdd2 available.");
                    return;
                }
                quantityOfItems.hdd2 -= 1;
                return;
            }
            else if (label7.Text.Contains("Toshiba"))
            {

                if (quantityOfItems.hdd3 == 0)
                {
                    MessageBox.Show("No hdd3 available.");
                    return;
                }
                quantityOfItems.hdd3 -= 1;
                return;
            }
            else if (label7.Text.Contains("Red"))
            {

                if (quantityOfItems.hdd4 == 0)
                {
                    MessageBox.Show("No hdd4 available.");
                    return;
                }
                quantityOfItems.hdd4 -= 1;
                return;

            }
            else if (label7.Text.Contains("IronWolf"))
            {

                if (quantityOfItems.hdd5 == 0)
                {
                    MessageBox.Show("No hdd5 available.");
                    return;
                }
                quantityOfItems.hdd5 -= 1;
                return;
            }




            if (label8.Text.Contains("Hyper T2"))
            {

                if (quantityOfItems.fan1 == 0)
                {
                    MessageBox.Show("No fan1 available.");
                    return;
                }
                quantityOfItems.fan1 -= 1;
                return;
            }
            else if (label8.Text.Contains("NF-A14"))
            {

                if (quantityOfItems.fan2 == 0)
                {
                    MessageBox.Show("No fan2 available.");
                    return;
                }
                quantityOfItems.fan2 -= 1;
                return;
            }
            else if (label8.Text.Contains("ML140"))
            {

                if (quantityOfItems.fan3 == 0)
                {
                    MessageBox.Show("No fan3 available.");
                    return;
                }
                quantityOfItems.fan3 -= 1;
                return;
            }
            else if (label8.Text.Contains("Riing 12"))
            {

                if (quantityOfItems.fan4 == 0)
                {
                    MessageBox.Show("No fan4 available.");
                    return;
                }
                quantityOfItems.fan4 -= 1;
                return;

            }
            else if (label8.Text.Contains("Mugen 5"))
            {

                if (quantityOfItems.fan5 == 0)
                {
                    MessageBox.Show("No fan5 available.");
                    return;
                }
                quantityOfItems.fan5 -= 1;
                return;
            }



            if (label9.Text.Contains("Viewonic"))
            {

                if (quantityOfItems.monitor1 == 0)
                {
                    MessageBox.Show("No monitor1 available.");
                    return;
                }
                quantityOfItems.monitor1 -= 1;
                return;
            }
            else if (label9.Text.Contains("Acer"))
            {

                if (quantityOfItems.monitor2 == 0)
                {
                    MessageBox.Show("No monitor2 available.");
                    return;
                }
                quantityOfItems.monitor2 -= 1;
                return;
            }
            else if (label9.Text.Contains("BenQ"))
            {

                if (quantityOfItems.monitor3 == 0)
                {
                    MessageBox.Show("No monitor3 available.");
                    return;
                }
                quantityOfItems.monitor3 -= 1;
                return;
            }
            else if (label9.Text.Contains("Dell"))
            {

                if (quantityOfItems.monitor4 == 0)
                {
                    MessageBox.Show("No monitor4 available.");
                    return;
                }
                quantityOfItems.monitor4 -= 1;
                return;

            }
            else if (label9.Text.Contains("LG"))
            {

                if (quantityOfItems.monitor5 == 0)
                {
                    MessageBox.Show("No monitor5 available.");
                    return;
                }
                quantityOfItems.monitor5 -= 1;
                return;
            }



            if (label10.Text.Contains("Logitech"))
            {

                if (quantityOfItems.keyboard1 == 0)
                {
                    MessageBox.Show("No keyboard1 available.");
                    return;
                }
                quantityOfItems.keyboard1 -= 1;
                return;
            }
            else if (label10.Text.Contains("Razer"))
            {

                if (quantityOfItems.keyboard2 == 0)
                {
                    MessageBox.Show("No keyboard2 available.");
                    return;
                }

                quantityOfItems.keyboard2 -= 1;
                return;
            }
            else if (label10.Text.Contains("K55"))
            {

                if (quantityOfItems.keyboard3 == 0)
                {
                    MessageBox.Show("No keyboard3 available.");
                    return;
                }

                quantityOfItems.keyboard3 -= 1;
                return;
            }
            else if (label10.Text.Contains("HyperX"))
            {

                if (quantityOfItems.keyboard4 == 0)
                {
                    MessageBox.Show("No keyboard4 available.");
                    return;
                }

                quantityOfItems.keyboard4 -= 1;
                return;

            }
            else if (label10.Text.Contains("SteelSeries"))
            {

                if (quantityOfItems.keyboard5 == 0)
                {
                    MessageBox.Show("No keyboard5 available.");
                    return;
                }

                quantityOfItems.keyboard5 -= 1;
                return;
            }




            if (label11.Text.Contains("MX Master"))
            {

                if (quantityOfItems.mouse1 == 0)
                {
                    MessageBox.Show("No mouse1 available.");
                    return;
                }

                quantityOfItems.mouse1 -= 1;
                return;
            }
            else if (label11.Text.Contains("DeathAdder"))
            {

                if (quantityOfItems.mouse2 == 0)
                {
                    MessageBox.Show("No mouse2 available.");
                    return;
                }

                quantityOfItems.mouse2 -= 1;
                return;
            }
            else if (label11.Text.Contains("SteelSeries"))
            {

                if (quantityOfItems.mouse3 == 0)
                {
                    MessageBox.Show("No mouse3 available.");
                    return;
                }
                quantityOfItems.mouse3 -= 1;
                return;
            }
            else if (label11.Text.Contains("HyperX"))
            {

                if (quantityOfItems.mouse4 == 0)
                {
                    MessageBox.Show("No mouse4 available.");
                    return;
                }
                quantityOfItems.mouse4 -= 1;
                return;

            }
            else if (label11.Text.Contains("G502"))
            {
                if (quantityOfItems.mouse4 == 0)
                {
                    MessageBox.Show("No mouse5 available.");
                    return;
                }
                quantityOfItems.mouse5 -= 1;
                return;
            }
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

        private void button_Close_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Exit the Application?", "Build-A-PC", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }
        }

        private void button_Maximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void button_Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button2_Paint(object sender, PaintEventArgs e) //get receipt 3d button
        {
            ControlPaint.DrawBorder(e.Graphics, button2.ClientRectangle,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }


        private void input_amount_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(input_amount.Text, out double paymentAmount))
            {
                MessageBox.Show("Please enter a valid payment amount.", "Build-A-PC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(label30.Text, out double totalAmount))
            {
                MessageBox.Show("Error in calculating total amount.", "Build-A-PC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double changeAmount = paymentAmount - totalAmount;
            label34.Text = changeAmount.ToString();

            if (changeAmount < 0)
            {
                label34.Text = string.Empty;
            }
        }

            private void input_amount_KeyPress(object sender, KeyPressEventArgs e)
            {
            char digit = e.KeyChar;

            // Allow digits, backspace, and period
            if (!char.IsDigit(digit) && digit != 8 && digit != '.')
            {
                e.Handled = true;
                MessageBox.Show("Please enter numbers only for your payments.", "Build-A-PC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Allow only one period for decimal input
            if (digit == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }
        private bool IsValidEmail(string email)
        {
            // Define a regular expression pattern for email validation
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";

            // Create a Regex object with the pattern
            Regex regex = new Regex(pattern);

            // Use the IsMatch method to check if the email matches the pattern
            return regex.IsMatch(email);
        }

        private void textBoxzipcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            char digit = e.KeyChar;

            if (!char.IsDigit(digit) && digit != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please enter an integer for your ZIP Code.", "Build-A-PC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            char digit = e.KeyChar;

            if (!char.IsDigit(digit) && digit != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please enter an integer for your Contact number.", "Build-A-PC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Paint_1(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, button1.ClientRectangle,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OrderingForm order = new OrderingForm(lblName.Text, lbl_ID.Text);
            this.Hide();
            order.Show();
        }
    }
}
