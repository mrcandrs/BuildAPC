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
    public partial class CPUScreen : Form
    {
        string uName;
        string cust_id;
        public CPUScreen(string uName, string cust_id)
        {
            InitializeComponent();
            label11.Text = uName;
            label12.Text = cust_id;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CPUScreen_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            Products products = new Products(label11.Text, label12.Text);
            this.Hide();
            products.Show();
        }
    }
}
