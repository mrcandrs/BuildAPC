﻿using System;
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
    public partial class KeyboardScreen : Form
    {
        string uName;
        string cust_id;
        public KeyboardScreen(string uName, string cust_id)
        {
            InitializeComponent();
            label11.Text = uName;
            label12.Text = cust_id;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Products products = new Products(label11.Text, label12.Text);
            this.Hide();
            products.Show();
        }
    }
}