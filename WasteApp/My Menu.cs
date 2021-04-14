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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void joinUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FullDetails ua = new FullDetails();
            ua.ShowDialog();
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Find_Us ol = new Find_Us();
            ol.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            FullDetails ua = new FullDetails();
            ua.ShowDialog();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Login2 au = new Login2();
            au.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChatApp ae = new ChatApp();
            ae.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Wallet sa = new Wallet();
            sa.ShowDialog();
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            Find_Me da = new Find_Me();
            da.ShowDialog();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Locator el = new Locator();
            el.ShowDialog();
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
            Find_Out le = new Find_Out();
            le.ShowDialog();
            
        }
    }
}
