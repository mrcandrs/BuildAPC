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
    public partial class Form5 : Form
    {   
        public Form5()
        {
            InitializeComponent();
        }
        // this will dictate the text in the combobox
        public int forCombobox = 0;

        // placeholders for the userName and id
        public string userName;
        public string id;

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
                comboBox1.Text = "NONE";
                comboBox2.Text = "NONE";
                comboBox3.Text = "NONE";
                comboBox4.Text = "NONE";
                comboBox5.Text = "NONE";
                comboBox6.Text = "NONE";
                comboBox7.Text = "NONE";
                comboBox8.Text = "NONE";
                comboBox9.Text = "NONE";
                comboBox10.Text = "NONE";
                comboBox11.Text = "NONE";
            }
            else if (forCombobox == 1)
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // instance
            Items items = new Items(comboBox1.Text.ToString(), comboBox2.Text.ToString(), comboBox3.Text.ToString(), comboBox4.Text.ToString(), comboBox5.Text.ToString(), comboBox6.Text.ToString(), comboBox7.Text.ToString(), comboBox8.Text.ToString(), comboBox9.Text.ToString(), comboBox10.Text.ToString(), comboBox11.Text.ToString());

            // update the text of labels in form 6
            Form6 form6 = new Form6();
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


            this.Hide();
            form6.ShowDialog();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // clearing the comboboxes
            string comboTextNull = "NONE";
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

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // sign out
        private void label3_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            this.Hide();
            form.ShowDialog();
        }
    }
}
