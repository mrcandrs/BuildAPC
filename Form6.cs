using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

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



        private void button1_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.forCombobox = 1;
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

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 form = new Form7();
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
            form.ShowDialog();
        }
    }
}
