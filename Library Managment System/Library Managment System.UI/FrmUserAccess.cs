using System.Speech;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Threading;
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
    public partial class FrmUserAccess : Form
    {
        //SpeechRecognizer rec = new SpeechRecognizer();
        public FrmUserAccess()
        {
            InitializeComponent();
            //rec.SpeechRecognized += rec_SpeechRecognized;
            string date = DateTime.Now.ToString("yyyy/MM/dd");
            dateLabel.Text = date;
            timer1.Start();
        }
        //void rec_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        //{
        //    userNametextBox.Text = e.Result.Text;
        //}
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmUserAccessForm_Load(object sender, EventArgs e)
        {
            //var c = new Choices();
            //for (var i = 0; i <= 100; i++)
            //    c.Add(i.ToString());
            //var gb = new GrammarBuilder(c);
            //var g = new Grammar(gb);
            //rec.LoadGrammar(g);
            //rec.Enabled = true;
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
             new UserRegistration().ShowDialog();
             

             
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string userName, userPassword;
            string adminName = "Admin";
            string adminPass = "Admin";
            userName=userNametextBox.Text;
            userPassword=userPasswordBox.Text;
            

            if (userName == adminName && userPassword == adminPass)
            {
                new AdminSite().ShowDialog();
            }
            else
            { 
                new UserInfo(userName,userPassword).ShowDialog();
            }
                
        }

        private void dateLabel_Click(object sender, EventArgs e)
        {

        }

        private void contactoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            timeLabel.Text = date.ToLongTimeString();
        }


    }
}
