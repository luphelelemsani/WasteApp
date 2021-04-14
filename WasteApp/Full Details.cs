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
   
    public partial class FullDetails : Form
    {
        public FullDetails()
        {
            InitializeComponent();
        }
    class Person
    {
        public string FirstName = "";
        public string Lastname = "";
        private string idNumber;
        public string IDnumber
        {
            get{return idNumber;}
            set{idNumber = value;}

        }
        public string Mobilenumber;
        public string Gender;
        public string Role;
        public string Address;
        private string passWord;
        public string Password
        {
            get
            {
                return passWord;
            }
            set
            {
                passWord = value;
            }
        }
        private string confirmPassword;
        public string ConfirmPassword
        {
            get
            {
                return confirmPassword;
            }
            set
            {
                confirmPassword = value;
            }
        }

        public string GetPerson()
        {
            return FirstName + "\t" + Lastname;
        }
    }
 
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Full_Details_Load(object sender, EventArgs e)
        {

        }
  
        private void AddBtn_Click(object sender, EventArgs e)
        {
            Person c = new Person();

            c.FirstName = FirstNameBox.Text;
            c.Lastname = LastNameBox.Text;
            c.IDnumber = IDBox.Text;
            c.Mobilenumber = PhoneBox.Text;
            c.Address = AddressBox.Text;
            c.Gender = GenderBox.SelectedItem.ToString();
            c.Role = comboBox1.SelectedItem.ToString();
            c.Password = PassowrdBox.Text;
            c.ConfirmPassword = ConPasswordBox.Text;

            bool success = new bool();
            if (success == true)
            {
                //Displays the successful adding
                MessageBox.Show("The users details were successfully saved.");
            }         
            else
            { 
                //Displays the unsuccessful adding
                MessageBox.Show("The users details were unsuccessful.");
            }
            
            Login2 st = new Login2();
            st.ShowDialog();
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Form3 pl = new Form3();
            pl.ShowDialog();
        }

        private void LastNameBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
