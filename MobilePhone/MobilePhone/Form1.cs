﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobilePhone
{
    public partial class MobileMagazines : Form
    {
        private List<MobilePhones> mobiles;

        public MobileMagazines()
        {
            InitializeComponent();
            this.mobiles = new List<MobilePhones>()
            {
                new MobilePhones() { },
                new MobilePhones() { }
            };
        }


  }
}
