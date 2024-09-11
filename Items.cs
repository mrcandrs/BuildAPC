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
        //public string EMAIL;
        //public string ADDRESS;
        //public string CITY;
        //public string PROVINCE;
        //public string ZIPCODE;
        //public string CONTACT;
       



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
            //EMAIL = email;
           // ADDRESS = address;
            //CITY = city;
            //PROVINCE = province;
            //ZIPCODE = zipcode;
            //CONTACT = contact;
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
        //public string Email { get { return EMAIL; }set { EMAIL = value; } }
        //public string Address { get { return ADDRESS; } set { ADDRESS = value; } }
        //public string City { get { return CITY; } set { CITY = value; } }
        //public string Province { get { return PROVINCE; } set { PROVINCE = value; } }
        //public string Zipcode { get { return ZIPCODE; } set {  ZIPCODE = value; } }
        //public string Contact { get { return CONTACT; } set { CONTACT = value; } }

    }
}
