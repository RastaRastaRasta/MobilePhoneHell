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
        string[] s1 = new string[] { "Связной" };
        string[] s2 = new string[] { "Теле2" };
        string[] s3 = new string[] { "МТС" };
         


    public MobileMagazines()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(s1);
            comboBox1.Items.AddRange(s2);
            comboBox1.Items.AddRange(s3);
           

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == 0)
            {
                comboBox2.Items.AddRange(new string[] { "Apple", "Samsung", "Huawei" });
            }
            if (comboBox1.SelectedIndex == 1)
            {
                comboBox2.Items.AddRange(new string[] { "Xiaomi", "Samsung", "Huawei" });
            }
            if (comboBox1.SelectedIndex == 2)
            {
                comboBox2.Items.AddRange(new string[] { "ZTE", "LG", "Nokia" });
            }
        }
    }
}