using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace BuildAPC
{
    public partial class HDDScreen : Form
    {
        string uName;
        string cust_id;
        public HDDScreen(string uName, string cust_id)
        {
            InitializeComponent();
            label11.Text = uName;
            label12.Text = cust_id;
        }

        private void HHDScreen_Load(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Products products = new Products(label11.Text, label12.Text);
            this.Hide();
            products.Show();
        }
    }
}
