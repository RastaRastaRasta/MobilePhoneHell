using System;
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



        public MobileMagazines()
        {
            {
                InitializeComponent();
                comboBox1.Items.AddRange(new object[] { "Связной", "Теле2", "МТС" });
                
            }



        }



        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == 0)
            {
                comboBox2.Items.AddRange(new object[] { "Apple", "Samsung", "Huawei" });
            }
            if (comboBox1.SelectedIndex == 1)
            {
                comboBox2.Items.AddRange(new object[] { "Xiaomi", "Samsung", "Huawei" });
            }
            if (comboBox1.SelectedIndex == 2)
            {
                comboBox2.Items.AddRange(new object[] { "ZTE", "LG", "Nokia" });
            }
        }
    }
}