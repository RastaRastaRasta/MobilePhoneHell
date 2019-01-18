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
                listView1.Items.Add("IPhone 7");
                listView1.Items.Add("IPhone 8");
                listView1.Items.Add("Iphone X");
            }
            if ((comboBox1.SelectedIndex == 0) && (comboBox2.SelectedIndex == 1))
            {
                listView1.Items.Add("A5");
                listView1.Items.Add("S9");
                listView1.Items.Add("C8");
            }
            if ((comboBox1.SelectedIndex == 0) && (comboBox2.SelectedIndex == 2))
            {
                listView1.Items.Add("Mate 20 lite");
                listView1.Items.Add("nova 3");
                listView1.Items.Add("Y6 Prime");
            }
            if ((comboBox1.SelectedIndex == 1) && (comboBox2.SelectedIndex == 0))
            {
                listView1.Items.Add("Mi 8 Lite");
                listView1.Items.Add("Redmi Note 6 Pro");
                listView1.Items.Add("Redmi 5");
            }
            if ((comboBox1.SelectedIndex == 1) && (comboBox2.SelectedIndex == 1))
            {
                listView1.Items.Add("ZenFone 5Z ");
                listView1.Items.Add("ZenFone 4 Selfie Pro");
                listView1.Items.Add("ZenFone Max Pro");
            }
            if ((comboBox1.SelectedIndex == 1) && (comboBox2.SelectedIndex == 2))
            {
                listView1.Items.Add("M5C");
                listView1.Items.Add("M8 LITE");
                listView1.Items.Add("NOTE 8");
            }
            if ((comboBox1.SelectedIndex == 2) && (comboBox2.SelectedIndex == 0))
            {
                listView1.Items.Add("Axon 9 PRO");
                listView1.Items.Add("Blade V9 Vita");
                listView1.Items.Add("Blade A6 max");
            }
            if ((comboBox1.SelectedIndex == 2) && (comboBox2.SelectedIndex == 1))
            {
                listView1.Items.Add("Q6");
                listView1.Items.Add("G7 ThinQ");
                listView1.Items.Add("X venture");
            }
            if ((comboBox1.SelectedIndex == 2) && (comboBox2.SelectedIndex == 2))
            {
                listView1.Items.Add("8.1");
                listView1.Items.Add("6.1");
                listView1.Items.Add("5.1");
            }
        }

        
            private void button1_Click(object sender, EventArgs e)
            {
                listView1.Items.Clear();


                //comboBox2.SelectedIndex = -1; 

                if ((checkBox1.Checked == true) && (checkBox2.Checked == false) && (checkBox3.Checked == true) && (checkBox4.Checked == false) && (checkBox5.Checked == true))
                {
                    listView1.Items.Add("Iphone X");
                }

                if ((checkBox1.Checked == true) && (checkBox2.Checked == false) && (checkBox3.Checked == false) && (checkBox4.Checked == false) && (checkBox5.Checked == false))
                {
                    listView1.Items.Add("Iphone X");
                }

                if ((checkBox1.Checked == false) && (checkBox2.Checked == false) && (checkBox3.Checked == true) && (checkBox4.Checked == false) && (checkBox5.Checked == false))
                {
                    listView1.Items.Add("Iphone X");
                }

                if ((checkBox1.Checked == false) && (checkBox2.Checked == false) && (checkBox3.Checked == false) && (checkBox4.Checked == false) && (checkBox5.Checked == true))
                {
                    listView1.Items.Add("Iphone X");
                }

                if ((checkBox1.Checked == true) && (checkBox2.Checked == false) && (checkBox3.Checked == true) && (checkBox4.Checked == false) && (checkBox5.Checked == false))
                {
                    listView1.Items.Add("Iphone X");
                }

                if ((checkBox1.Checked == false) && (checkBox2.Checked == false) && (checkBox3.Checked == true) && (checkBox4.Checked == false) && (checkBox5.Checked == true))
                {
                    listView1.Items.Add("Iphone X");
                    //listView1.Items.Clear(); 

                    if ((checkBox1.Checked == true) && (checkBox2.Checked == true) && (checkBox3.Checked == true) && (checkBox4.Checked == false) && (checkBox5.Checked == false))
                    {
                        listView1.Items.Add("S9");
                    }

                    if ((checkBox1.Checked == true) && (checkBox2.Checked == false) && (checkBox3.Checked == true) && (checkBox4.Checked == false) && (checkBox5.Checked == false))
                    {
                        listView1.Items.Add("S9");
                    }

                    //listView1.Items.Clear(); 

                    if ((checkBox1.Checked == false) && (checkBox2.Checked == false) && (checkBox3.Checked == false) && (checkBox4.Checked == true) && (checkBox5.Checked == true))
                    {
                        listView1.Items.Add("nova 3");
                    }

                    /*if (checkBox5.Checked == true) 
                    { 
                    listView1.Items.Add("IPhone 7"); 
                    listView1.Items.Add("IPhone 9"); 
                    listView1.Items.Add("Iphone X"); 
                    listView1.Items.Add("A5"); 
                    listView1.Items.Add("S9"); 
                    listView1.Items.Add("C8"); 
                    listView1.Items.Add("Mate 20 lite"); 
                    listView1.Items.Add("M8 LITE"); 
                    listView1.Items.Add("5.1"); 

                    }*/


                }
            }
        }
    }

    