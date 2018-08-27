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
    public partial class AdminSite : Form
    {
        DataAccess dataAccess = new DataAccess();
        public AdminSite()
        {
            InitializeComponent();
        }
        public void ShowGridView()
        {
            LibraryDBDataContext cntx = new LibraryDBDataContext(Library_Managment_System.UI.Properties.Settings.Default.librarydbConnectionString);

            var q = from a in cntx.BrowseBooks// where user.UserId.Contains("1232")
                    select a;
            dgvAdminSite.DataSource = q;
        }
        private void AddBook()
        {

            BrowseBook bookbrowse = new BrowseBook();
            bookbrowse.BookName = bookNameTxtBox.Text;
            bookbrowse.BookId = bookIdTextBox.Text;
            bookbrowse.Author = authorTextBox.Text;
            bookbrowse.Catagory = catagoryTextBox.Text;

            
            dataAccess.AddBook(bookbrowse);
            //LibraryDBDataContext cntx = new LibraryDBDataContext(Library_Managment_System.UI.Properties.Settings.Default.librarydbConnectionString);

            //cntx.BrowseBooks.InsertOnSubmit(browsebook);
            //cntx.SubmitChanges();
        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdminSite_Load(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToLongDateString();
            dateLabel.Text = date;

        }

        private void contactoMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void addBookButton_Click(object sender, EventArgs e)
        {
            this.AddBook();
            MessageBox.Show("Book Add SuccessFully");
            this.ShowGridView();
        }

        private void dgvAdminSite_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var q = dataAccess.ViewBook();
            dgvAdminSite.DataSource = q;
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AddBook();
            MessageBox.Show("Book Add SuccessFully");
            this.ShowGridView();
        }

        private void viewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //LibraryDBDataContext cntx = new LibraryDBDataContext(Library_Managment_System.UI.Properties.Settings.Default.librarydbConnectionString);

            //var q = from a in cntx.Users// where user.UserId.Contains("1232")
            //        select a;
            var q=dataAccess.ViewUser();
            dgvAdminSite.DataSource = q;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //string dgvGetValue=dgvAdminSite.Cells["BookName"].Value.ToString();
            string data = dgvAdminSite.SelectedRows[0].Cells["BookName"].ToString();
            MessageBox.Show(data);
        }


    }
}
