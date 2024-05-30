using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Items
    { 
        public string MOTHERBOARD;
        public string GPU;
        public string CPU;
        public string RAM;
        public string PSU;
        public string SSD;
        public string HDD;
        public string FAN;
        public string MONITOR;
        public string KEYBOARD;
        public string MOUSE;
       



        public Items( string motherboard, string gpu,   string cpu,  string ram,  string psu,  string ssd,   string hdd,  string fan,   string monitor,  string keyboard,  string mouse)
        {
            MOTHERBOARD = motherboard;
            GPU = gpu;
            CPU = cpu;
            RAM = ram;
            PSU = psu;
            SSD = ssd;
            HDD = hdd;
            FAN = fan;
            MONITOR = monitor;
            KEYBOARD = keyboard;
            MOUSE = mouse;

        }

        public string Motherboard { get { return MOTHERBOARD; } set { MOTHERBOARD = value; } }
        public string Gpu { get { return GPU; } set { GPU = value; } }
        public string Cpu { get { return CPU; } set { CPU = value; } }
        public string Ram { get { return RAM; } set { RAM = value; } }
        public string Psu { get { return PSU; } set { PSU = value; } }
        public string Ssd { get { return SSD; } set { SSD = value; } }
        public string Hdd { get { return HDD; } set { HDD = value; } }
        public string Fan { get { return FAN; } set { FAN = value; } }
        public string Monitor { get { return MONITOR; } set { MONITOR = value; } }
        public string Keyboard { get { return KEYBOARD; } set { KEYBOARD = value; } }
        public string Mouse { get { return MOUSE; } set { MOUSE = value; } }

    }
}
