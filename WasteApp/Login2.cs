using System;
using System.Windows.Forms;
using System.Net;

namespace WindowsFormsApp1
{
    public partial class Login2 : Form
    {
        public Login2()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Er_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string Emailaddress = "abc@gmail.com";
            string Query = "select * from tbl_user where username = emailaddress";
            if (Emailaddress == "Abc@gmail.com" && Query == "username = emailaddress")
                MessageBox.Show("The user/email address exists.");
            else
                MessageBox.Show("The user/email address does not exist");
        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/login");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FullDetails hl = new FullDetails();
            hl.ShowDialog();
            this.Close();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/login");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/login");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.twitter.com/login");
        }
    }
       
    
}
