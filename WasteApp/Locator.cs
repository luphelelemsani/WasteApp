using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net;

namespace WindowsFormsApp1
{
    public partial class Locator : Form
    {
        public Locator()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public  void MainMenu_Load(object sender, EventArgs e)
        {
#pragma warning disable CS0168 // Variable is declared but never used
            string Locators(string ip)
#pragma warning restore CS0168 // Variable is declared but never used
            { 
                var res = "";
                WebRequest request = WebRequest.Create("http://ipinfo.io/z" + ip);
                using (WebResponse response = request.GetResponse())
                using (StreamReader stream = new StreamReader(response.GetResponseStream()))
                {
                    string line;
                    while ((line = stream.ReadLine()) != null)
                    {
                        res += line;

                    }
                }
                return res;
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form3 ye = new Form3();
            ye.ShowDialog();
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        class collection

        {
            public string WasteSize;
            public string WasteType;
            public string WasteDate;
            public string WasteDescrp;
            public string WasteLocate;
            public collection(string a,string b, string c,string d,string e)
            {
                WasteSize = a;
                WasteType = b;
                WasteDate = c;
                WasteDescrp = d;
                WasteLocate = e;
            }
            
                public string toString()
            {

                return "Waste size: " + WasteSize + "Waste Type: " + WasteType 
                    + " Waste Date: " + WasteDate + " Waste Descrp " + WasteDescrp +
                    "Waste Location: " + WasteLocate ;
            }
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string a = comboBox3.SelectedItem.ToString();
            string b = comboBox2.SelectedItem.ToString();
            string c = comboBox1.SelectedItem.ToString();
            string d = textBox1.Text.ToString();
            string ed = dateTimePicker1.Value.ToString();
            collection coll;
            try
            {
                //coll.WasteSize = comboBox3.SelectedValue.ToString();
                //coll.WasteType = comboBox2.SelectedValue.ToString();
                //coll.WasteLocate = comboBox1.SelectedValue.ToString();
                //coll.WasteDescrp = textBox1.Text;
                //coll.WasteDate = dateTimePicker1.Value.ToString();
                // collection coll = new collection(comboBox3.SelectedValue.ToString(), comboBox2.SelectedValue.ToString(), comboBox1.SelectedValue.ToString(), textBox1.Text.ToString(), dateTimePicker1.Value.ToString());
                coll = new collection(a, b, c, d, ed);
               
            }
            catch(Exception exc)
            {
                 coll = new collection("test1", "test2", "test3", "test4", "today");
                MessageBox.Show(exc.ToString());
            }
            listBox1.Items.Add(coll.toString());
        }

    }
    
}
