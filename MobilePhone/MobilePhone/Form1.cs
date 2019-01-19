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

        private List<MobilePhones> Phones = new List<MobilePhones>();


        public MobileMagazines()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new object[] { "Связной", "Теле2", "МТС" });
            this.Phones.Add(new MobilePhones() { ProductOwner = "Apple", Name = "IPhone 7", Params = new List<PhoneParams>() { PhoneParams.WaterProtected, PhoneParams.NFC } });
            this.Phones.Add(new MobilePhones() { ProductOwner = "Apple", Name = "IPhone 8", Params = new List<PhoneParams>() { PhoneParams.NFC, PhoneParams.NoBreak } });
            this.Phones.Add(new MobilePhones() { ProductOwner = "Apple", Name = "IPhone X", Params = new List<PhoneParams>() { PhoneParams.NFC, PhoneParams.doubleSim, PhoneParams.doubleCam, PhoneParams.NoBreak } });
            this.Phones.Add(new MobilePhones() { ProductOwner = "Samsung", Name = "A5", Params = new List<PhoneParams>() { PhoneParams.WaterProtected, PhoneParams.doubleSim, PhoneParams.doubleCam, PhoneParams.NoBreak } });
            this.Phones.Add(new MobilePhones() { ProductOwner = "Samsung", Name = "S9", Params = new List<PhoneParams>() { PhoneParams.doubleSim, PhoneParams.doubleCam, PhoneParams.WaterProtected } });
            this.Phones.Add(new MobilePhones() { ProductOwner = "Samsung", Name = "C8", Params = new List<PhoneParams>() { PhoneParams.doubleSim } });
            this.Phones.Add(new MobilePhones() { ProductOwner = "Huawei", Name = "Mate 20 lite", Params = new List<PhoneParams>() { PhoneParams.doubleSim, PhoneParams.doubleCam } });
            this.Phones.Add(new MobilePhones() { ProductOwner = "Huawei", Name = "nova 3", Params = new List<PhoneParams>() { PhoneParams.doubleSim, PhoneParams.NoBreak } });
            this.Phones.Add(new MobilePhones() { ProductOwner = "Huawei", Name = "Y6 Prime", Params = new List<PhoneParams>() { PhoneParams.doubleSim, PhoneParams.NFC, PhoneParams.NoBreak } });
            this.Phones.Add(new MobilePhones() { ProductOwner = "Xiaomi", Name = "Mi 8 Lite", Params = new List<PhoneParams>() { PhoneParams.doubleSim, PhoneParams.doubleCam, PhoneParams.WaterProtected } });
            this.Phones.Add(new MobilePhones() { ProductOwner = "Xiaomi", Name = "Redmi Note 6 Pro", Params = new List<PhoneParams>() { PhoneParams.doubleSim, PhoneParams.NFC, PhoneParams.doubleCam } });
            this.Phones.Add(new MobilePhones() { ProductOwner = "Xiaomi", Name = "Redmi 5", Params = new List<PhoneParams>() { PhoneParams.doubleSim, PhoneParams.NFC } });
            this.Phones.Add(new MobilePhones() { ProductOwner = "Asus", Name = "ZenFone 5Z", Params = new List<PhoneParams>() { PhoneParams.doubleSim, PhoneParams.WaterProtected } });
            this.Phones.Add(new MobilePhones() { ProductOwner = "Asus", Name = "ZenFone 4 Selfie Pro", Params = new List<PhoneParams>() { PhoneParams.doubleSim, PhoneParams.NoBreak, PhoneParams.WaterProtected } });
            this.Phones.Add(new MobilePhones() { ProductOwner = "Asus", Name = "ZenFone Max Pro", Params = new List<PhoneParams>() { PhoneParams.doubleSim, PhoneParams.NoBreak } });
            this.Phones.Add(new MobilePhones() { ProductOwner = "Meizu", Name = "M5C", Params = new List<PhoneParams>() { PhoneParams.doubleSim } });
            this.Phones.Add(new MobilePhones() { ProductOwner = "Meizu", Name = "M8 LITE", Params = new List<PhoneParams>() { PhoneParams.doubleSim, PhoneParams.doubleCam } });
            this.Phones.Add(new MobilePhones() { ProductOwner = "Meizu", Name = "NOTE 8", Params = new List<PhoneParams>() { PhoneParams.doubleCam, PhoneParams.NFC } });
            this.Phones.Add(new MobilePhones() { ProductOwner = "ZTE", Name = "Axon 9 PRO", Params = new List<PhoneParams>() { PhoneParams.doubleSim, PhoneParams.NFC, PhoneParams.NoBreak, PhoneParams.WaterProtected, PhoneParams.doubleCam } });
            this.Phones.Add(new MobilePhones() { ProductOwner = "ZTE", Name = "Blade V9 Vita", Params = new List<PhoneParams>() { PhoneParams.doubleSim, PhoneParams.doubleCam } });
            this.Phones.Add(new MobilePhones() { ProductOwner = "ZTE", Name = "Blade A6 max", Params = new List<PhoneParams>() { PhoneParams.doubleSim } });
            this.Phones.Add(new MobilePhones() { ProductOwner = "LG", Name = "Q6", Params = new List<PhoneParams>() { PhoneParams.doubleSim, PhoneParams.doubleCam } });
            this.Phones.Add(new MobilePhones() { ProductOwner = "LG", Name = "G7 ThinQ", Params = new List<PhoneParams>() { PhoneParams.doubleCam } });
            this.Phones.Add(new MobilePhones() { ProductOwner = "LG", Name = "X venture", Params = new List<PhoneParams>() { PhoneParams.NoBreak, PhoneParams.WaterProtected } });
            this.Phones.Add(new MobilePhones() { ProductOwner = "Nokia", Name = "8.1", Params = new List<PhoneParams>() { PhoneParams.doubleSim, PhoneParams.WaterProtected } });
            this.Phones.Add(new MobilePhones() { ProductOwner = "Nokia", Name = "6.1", Params = new List<PhoneParams>() { PhoneParams.doubleSim, PhoneParams.NFC, PhoneParams.NoBreak } });
            this.Phones.Add(new MobilePhones() { ProductOwner = "Nokia", Name = "5.1", Params = new List<PhoneParams>() { PhoneParams.doubleCam, PhoneParams.NFC, PhoneParams.WaterProtected } });

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
                comboBox2.Items.AddRange(new object[] { "Xiaomi", "Asus", "Meizu" });
            }


            if (comboBox1.SelectedIndex == 2)
            {
                comboBox2.Items.AddRange(new object[] { "ZTE", "LG", "Nokia" });
            }
        }


        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            if ((comboBox1.SelectedIndex == 0) && (comboBox2.SelectedIndex == 0))
            {

                var filteredPhones = this.Phones.Where(t => t.ProductOwner.Equals("Apple"));
                foreach (var phone in filteredPhones)
                {
                    listView1.Items.Add(phone.Name);
                }
            }
            if ((comboBox1.SelectedIndex == 0) && (comboBox2.SelectedIndex == 1))
            {

                var filteredPhones = this.Phones.Where(t => t.ProductOwner.Equals("Samsung"));
                foreach (var phone in filteredPhones)
                {
                    listView1.Items.Add(phone.Name);
                }
            }
            if ((comboBox1.SelectedIndex == 0) && (comboBox2.SelectedIndex == 2))
            {

                var filteredPhones = this.Phones.Where(t => t.ProductOwner.Equals("Huawei"));
                foreach (var phone in filteredPhones)
                {
                    listView1.Items.Add(phone.Name);
                }
            }
            if ((comboBox1.SelectedIndex == 1) && (comboBox2.SelectedIndex == 0))
            {

                var filteredPhones = this.Phones.Where(t => t.ProductOwner.Equals("Xiaomi"));
                foreach (var phone in filteredPhones)
                {
                    listView1.Items.Add(phone.Name);
                }
            }
            if ((comboBox1.SelectedIndex == 1) && (comboBox2.SelectedIndex == 1))
            {

                var filteredPhones = this.Phones.Where(t => t.ProductOwner.Equals("Asus"));
                foreach (var phone in filteredPhones)
                {
                    listView1.Items.Add(phone.Name);
                }
            }
            if ((comboBox1.SelectedIndex == 1) && (comboBox2.SelectedIndex == 2))
            {

                var filteredPhones = this.Phones.Where(t => t.ProductOwner.Equals("Meizu"));
                foreach (var phone in filteredPhones)
                {
                    listView1.Items.Add(phone.Name);
                }
            }
            if ((comboBox1.SelectedIndex == 2) && (comboBox2.SelectedIndex == 0))
            {

                var filteredPhones = this.Phones.Where(t => t.ProductOwner.Equals("ZTE"));
                foreach (var phone in filteredPhones)
                {
                    listView1.Items.Add(phone.Name);
                }
            }
            if ((comboBox1.SelectedIndex == 2) && (comboBox2.SelectedIndex == 1))
            {

                var filteredPhones = this.Phones.Where(t => t.ProductOwner.Equals("LG"));
                foreach (var phone in filteredPhones)
                {
                    listView1.Items.Add(phone.Name);
                }
            }
            if ((comboBox1.SelectedIndex == 2) && (comboBox2.SelectedIndex == 2))
            {

                var filteredPhones = this.Phones.Where(t => t.ProductOwner.Equals("Nokia"));
                foreach (var phone in filteredPhones)
                {
                    listView1.Items.Add(phone.Name);
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            var FilteredParams = new List<PhoneParams>();
            if (checkBox1.Checked)
                FilteredParams.Add(PhoneParams.doubleCam);
            if (checkBox2.Checked)
                FilteredParams.Add(PhoneParams.doubleSim);
            if (checkBox3.Checked)
                FilteredParams.Add(PhoneParams.WaterProtected);
            if (checkBox4.Checked)
                FilteredParams.Add(PhoneParams.NoBreak);
            if (checkBox5.Checked)
                FilteredParams.Add(PhoneParams.NFC);

            IEnumerable<MobilePhones> filteredPhones = this.Phones.Where(r => r.ProductOwner.Equals(comboBox2.Text));




            foreach (var param in FilteredParams)
            {
                filteredPhones = filteredPhones.Where(t => t.Params.Contains(param)).ToArray();
            }
            foreach (var phone in filteredPhones)
            {
                listView1.Items.Add(phone.Name);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            listView1.Items.Clear();

        }
    }
}
      
    