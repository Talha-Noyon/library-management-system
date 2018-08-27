using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Library_Managment_System.Data;
using Library_Managment_System.Entity;

namespace Library_Managment_System.UI
{
    public partial class SearchBook : Form
    {
        //short BookLoan;
        string userId;
        DataAccess dataAccess = new DataAccess();
        public SearchBook(String id)
        {
            InitializeComponent();
            userId = id;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void BrowseBook_Load(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            dateLabel.Text = date.ToString("yyyy/MM/dd");
            borrowDateTextBox.Text = date.ToString("yyyy/MM/dd");
            timer1.Start();
            

        }

        private void dateLabel_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            timeLabel.Text = date.ToLongTimeString();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void borrowButton_Click(object sender, EventArgs e)
        {
            //DateTime BookDueDate;
            //string n = "";
            int noOfDays = int.Parse(noOfDaysTextBox.Text);
            if (noOfDays == 0)
            {
                MessageBox.Show("You should Put The Valid Days For Borrow");
            }
            //if (noOfDays==int.Parse("") )
            //{
            //    MessageBox.Show("You should Put The Days For Borrow");
            //}
            if (noOfDays <= 7)
            {
                DateTime currentDay = DateTime.Now;
                currentDay = currentDay.AddDays(noOfDays);

                dueBackTextBox.Text = currentDay.ToString("yyyy/MM/dd");
            }
            else
            {
                MessageBox.Show("You can't borrow over 7 days");
            }



            BookSelf bookself = new BookSelf();
            bookself.UserId = userId;
            string dgvBookName = dgvShowBook["BookName", 0].Value.ToString();
           // MessageBox.Show(dgvBookName);
            bookself.BookName = dgvBookName;
            bookself.BackDate = dueBackTextBox.Text;

            dataAccess.AddBookMySelf(bookself);
            
            MessageBox.Show("Borrow Successfully");

            //switch (noOfDaysTextBox.Text)
            //{
            //    case "0":
            //        BookLoan = 0;
            //        DateTime today = DateTime.Now;
            //        today = today.AddDays(BookLoan);
            //        dueBackTextBox.Text = today.ToString("yyyy/MM/dd");
                    
            //        break;

            //    case "1":
            //        BookLoan = 1;
            //        DateTime today1 = DateTime.Now;
            //        today1 = today1.AddDays(BookLoan);
            //        dueBackTextBox.Text = today1.ToString("yyyy/MM/dd");
                    
            //        break;
            //    case "2":
            //        BookLoan = 2;
            //        DateTime today2 = DateTime.Now;
            //        today2 = today2.AddDays(BookLoan);
            //        dueBackTextBox.Text = today2.ToString("yyyy/MM/dd");
                   
            //        break;
            //    case "3":
            //        BookLoan = 3;
            //        DateTime today3 = DateTime.Now;
            //        today3 = today3.AddDays(BookLoan);
            //        dueBackTextBox.Text = today3.ToString("yyyy/MM/dd");
                    
            //        break;
            //    case "4":
            //        BookLoan = 4;
            //        DateTime today4 = DateTime.Now;
            //        //TimeSpan duration4 = new TimeSpan(BookLoan, 0, 0, 0);
            //        //DateTime answer4 = today4.Add(duration4);
            //        today4 = today4.AddDays(BookLoan);
            //        dueBackTextBox.Text = today4.ToString("yyyy/MM/dd");
                    
            //        break;
            //    case "5":
            //        BookLoan = 5;
            //        DateTime today5 = DateTime.Now;
            //        today5 = today5.AddDays(BookLoan);
            //        dueBackTextBox.Text = today5.ToString("yyyy/MM/dd");
                    
            //        break;
            //    case "6":
            //        BookLoan = 6;
            //        DateTime today6 = DateTime.Now;
            //        today6 = today6.AddDays(BookLoan);
            //        dueBackTextBox.Text = today6.ToString("yyyy/MM/dd");
                    
            //        break;
            //    case "7":
            //        BookLoan = 7;
            //        DateTime today7 = DateTime.Now;
            //        today7 = today7.AddDays(BookLoan);
            //        dueBackTextBox.Text = today7.ToString("yyyy/MM/dd");
                    
            //        break;
            //    default:
            //        break;
            //}
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }



        private void searchhOver(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void contactoMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var q = dataAccess.ViewBook();
            dgvShowBook.DataSource = q;
        }

        private void myBookSelfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MyBookSelf(userId).ShowDialog();
        }

        private void signoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmUserAccess().ShowDialog();
        }
    }
}
