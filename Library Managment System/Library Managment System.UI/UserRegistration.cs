using Library_Managment_System.Data;
using Library_Managment_System.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Library_Managment_System.UI
{
    public partial class UserRegistration : Form
    {
        public UserRegistration()
        {
            InitializeComponent();
            
        }
        private void AddUser()
        {
            User user = new User();
            user.UserId = userIdtxtBox.Text;
            user.Title = titleTxtBox.Text;
            user.UserName = usrNameTxtBox.Text;
            user.Email = emailTxtBox.Text;
            user.Password = passwordTxtBox.Text;
            user.Address = adressTxtBox.Text;
            user.DOB = dateBox.Text;
            user.AdvPayment = paymentTxtBox.Text;


            DataAccess dataAccess = new DataAccess();
            dataAccess.AddUser(user);


        }
        private void UserRegistration_Load(object sender, EventArgs e)
        {
            
        }

        private void backButton_Click(object sender, EventArgs e)
        {
           
            new FrmUserAccess().ShowDialog();
            
            
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            if (passwordTxtBox.Text != confirmpassTxtBox.Text)
            {
                MessageBox.Show("confirm password fail");


            }

            //if (passwordTxtBox.Text != confirmpassTxtBox.Text)
            else if (passwordTxtBox.Text.Equals(confirmpassTxtBox.Text) && (titleTxtBox.Text != "") && (usrNameTxtBox.Text != "") && (emailTxtBox.Text != "") && (passwordTxtBox.Text != "") && (adressTxtBox.Text != "") && (dateBox.Text != "") && (paymentTxtBox.Text == "2000"))
            {
                this.AddUser();
                MessageBox.Show("Registration successfully");
                this.Close();
            }

            else
            {
                MessageBox.Show("Fill every textBox correctly");
            }
            
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void passwordTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void confirmpassTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
