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

namespace WindowsFormsApp1
{
    public partial class Form7 : Form
    {
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

        public Form7()
        {
            InitializeComponent();
        }

        private async void Form7_Load(object sender, EventArgs e)
        {
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
            label1.Text = a + mohterboard;
            await Task.Delay(1000);
            label2.Text = b + gpu;
            await Task.Delay(1000);
            label3.Text = c + cpu;
            await Task.Delay(1000);
            label4.Text = d + ram;
            await Task.Delay(1000);
            label5.Text = p + psu;
            await Task.Delay(1000);
            label6.Text = f + ssd;
            await Task.Delay(1000);
            label7.Text = g + hdd;
            await Task.Delay(1000);
            label8.Text = h + fan;
            await Task.Delay(1000);
            label9.Text = i + monitor;
            await Task.Delay(1000);
            label10.Text = j + keyboard;
            await Task.Delay(1000);
            label11.Text = k + mouse;
            await Task.Delay(1000);
        }
    }
}
