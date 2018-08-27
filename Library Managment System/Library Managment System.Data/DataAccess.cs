using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using Library_Managment_System.Entity;

namespace Library_Managment_System.Data
{
    public class DataAccess
    {
        string bookName;
        static LibraryDBDataContext cntx;
        public static LibraryDBDataContext Context
        {
            get
            {
                cntx = new LibraryDBDataContext(Library_Managment_System.Data.Properties.Settings.Default.librarydbConnectionString);
                
                return cntx;
            }
        }

        public void AddUser(User user)
        {
            //Console.WriteLine(""+user.UserId+""+user.UserName+""+user.Title);
            
            LibraryDBDataContext cntx = new LibraryDBDataContext(Library_Managment_System.Data.Properties.Settings.Default.librarydbConnectionString);

            cntx.Users.InsertOnSubmit(user);
            cntx.SubmitChanges();
        
        }
        public void AddBook(BrowseBook bookbrowse)
        {
            //Console.WriteLine(""+user.UserId+""+user.UserName+""+user.Title);

            LibraryDBDataContext cntx = new LibraryDBDataContext(Library_Managment_System.Data.Properties.Settings.Default.librarydbConnectionString);

            cntx.BrowseBooks.InsertOnSubmit(bookbrowse);
            cntx.SubmitChanges();

        }
        public void AddBookMySelf(BookSelf bookself)
        {
            //Console.WriteLine(""+user.UserId+""+user.UserName+""+user.Title);

            LibraryDBDataContext cntx = new LibraryDBDataContext(Library_Managment_System.Data.Properties.Settings.Default.librarydbConnectionString);

            cntx.BookSelfs.InsertOnSubmit(bookself);
            cntx.SubmitChanges();

        }
        public object ViewUser()
        {
            LibraryDBDataContext cntx = new LibraryDBDataContext(Library_Managment_System.Data.Properties.Settings.Default.librarydbConnectionString);

            var q = from a in cntx.Users// where user.UserId.Contains("1232")
                    select a;
            return q;
        }
        public object ViewBook()
        {
            LibraryDBDataContext cntx = new LibraryDBDataContext(Library_Managment_System.Data.Properties.Settings.Default.librarydbConnectionString);

            var q = from a in cntx.BrowseBooks//here user.UserId.Contains("1232")
                    select a;
            return q;
        }
        public object ViewBookSelf(string userid)
        {
            string id = userid;
            LibraryDBDataContext cntx = new LibraryDBDataContext(Library_Managment_System.Data.Properties.Settings.Default.librarydbConnectionString);

            var q = from a in cntx.BookSelfs
                    where a.UserId == id
                    select a;

            BookSelf bookself = q.First();
            //BookSelf bookself = q.Where(obj => obj.UserId == id ).First();// int.Parse(idTextBox.Text)).First();
            return q;
        }
        public void ReturnBook(string bookname)
        {
            bookName = bookname;
            LibraryDBDataContext cntx = new LibraryDBDataContext(Library_Managment_System.Data.Properties.Settings.Default.librarydbConnectionString);
            var q = from a in cntx.BookSelfs
                    where a.BookName == bookName
                    select a;
            BookSelf bookself = q.First();
            cntx.BookSelfs.DeleteOnSubmit(bookself);
            cntx.SubmitChanges();

        }



    }
}
