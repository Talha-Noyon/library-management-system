using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Library_Managment_System.Entity;
using Library_Managment_System.Data;

namespace Library_Managment_System.UI
{
    public partial class MyBookSelf : Form
    {
        string userid;
        DataAccess dataAccess = new DataAccess();
        public MyBookSelf(string id)
        {
            InitializeComponent();
            userid = id;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void MyBookSelf_Load(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString("yyyy/MM/dd");
            dateLabel.Text = date;
            returndatetxtBox.Text = date;
            timer1.Start();
            
            var q=dataAccess.ViewBookSelf(userid);
            
            dgvBookSelf.DataSource = q;
        }

        private void dateLabel_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            timeLabel.Text = date.ToLongTimeString();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            
            string bookname=dgvBookSelf.CurrentCell.Value.ToString();
            LibraryDBDataContext cntx = new LibraryDBDataContext(Library_Managment_System.UI.Properties.Settings.Default.librarydbConnectionString);

            var q = from a in cntx.BookSelfs
                    where a.BookName == bookname
                    select a;

            BookSelf bookself = q.First();
            string backDate = bookself.BackDate;
            
            DateTime DateDueBack; 
            DateTime DateReturned;
            
            DateDueBack = Convert.ToDateTime(backDate);
         
            //string dateReturn = DateDueBack.ToString("yyyy/MM/dd");
            int daysOverDue;

            //DateReturned = DateTime.Now;// Convert.ToDateTime(dateReturn);
            //string currentTime = DateTime.Now.ToString("yyyy/MM/dd");
            //string date = DateTime.Now.ToString("yyyy/MM/dd");
            DateReturned = Convert.ToDateTime(returndatetxtBox.Text);
            daysOverDue = (DateReturned - DateDueBack).Days;
           
            if (daysOverDue > 0)
            {   
                this.Hide();
                new Return(bookname).ShowDialog();
                

            }
            else
            {
                DataAccess dataAccess = new DataAccess();
                dataAccess.ReturnBook(bookname);
                MessageBox.Show("Return Successful");
            
            }

            //double overDueValue = double.Parse(dateOverDueTxtBox.Text);
            //fine = fineRate * overDueValue;
            //lateRetrnFineTxtBox.Text = fine.ToString();

        }

        private void searchBookToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void timeLabel_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
