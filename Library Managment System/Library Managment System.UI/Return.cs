using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Library_Managment_System.Data;

namespace Library_Managment_System.UI
{
    public partial class Return : Form
    {
        string bookname;
        public Return(string bookname)
        {
            InitializeComponent();
            this.bookname = bookname;
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            
           // double fine =double.Parse(textBox1.Text);
            if (penaltyTxtBox.Text == "200" )
            {
                MessageBox.Show("You Give Penalty Successfully sonamoni");
                DataAccess dataAccess = new DataAccess();
                dataAccess.ReturnBook(bookname);
            }

            else if (penaltyTxtBox.Text == "")
            {
                MessageBox.Show("What the F***K first you give penalty then forward....(Matherchod)");
            }
            else
            {
                MessageBox.Show("Penalty quantity is incorrect");
            }
            
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Return_Load(object sender, EventArgs e)
        {

        }
    }
}
