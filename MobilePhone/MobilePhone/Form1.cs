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
            comboBox2.Items.Clear();

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

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            if (comboBox2.SelectedIndex == 0)
            {
                listView1.Items.Add("234567");
                listView1.Items.Add("436477");
                listView1.Items.Add("657890");
            }
            if (comboBox2.SelectedIndex == 1)
            {
                listView1.Items.Add("fdgdgd");
                listView1.Items.Add("jumuuk");
                listView1.Items.Add("6kbnbb");
            }
            if (comboBox2.SelectedIndex == 2)
            {
                listView1.Items.Add("234nbn");
                listView1.Items.Add("nbnn77");
                listView1.Items.Add("65qw90");
            }
        }
    }
}