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
    public partial class Form3 : Form
    {
        public string userName {  get; set; }
        public string EmpID { get; set; }
        public Form3()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Text = userName;
            label2.Text = EmpID;
        }

        private void button1_MotherBoard_Click(object sender, EventArgs e)
        {

        }

        private void button2_GraphicsCard_Click(object sender, EventArgs e)
        {

        }

        private void button3_Processor_Click(object sender, EventArgs e)
        {

        }

        private void button4_RAM_Click(object sender, EventArgs e)
        {

        }

        private void button5_PowerSupply_Click(object sender, EventArgs e)
        {

        }

        private void button6_Storage_Click(object sender, EventArgs e)
        {

        }

        private void button7_HDD_Click(object sender, EventArgs e)
        {

        }

        private void button8_Fan_Click(object sender, EventArgs e)
        {

        }

        private void button9_Monitor_Click(object sender, EventArgs e)
        {

        }

        private void button10_Keyboard_Click(object sender, EventArgs e)
        {

        }

        private void button11_Mouse_Click(object sender, EventArgs e)
        {

        }
    }
}
