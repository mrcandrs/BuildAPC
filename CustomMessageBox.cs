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
    public partial class CustomMessageBox : Form
    {
        public CustomMessageBox()
        {
            InitializeComponent();
        }

        public void UpdateCountdownLabel(int seconds)
        {
            labelCountdown.Text = $"Too many failed attempts. Please wait {seconds} seconds.";
        }
    }
}
