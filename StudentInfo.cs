using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Form
{
    public partial class StudentInfo : Form
    {
        public string firstName;
        public string lastName;
        private string email;

        public StudentInfo(string userFirst, string userLast, string userEmail,
            string course = "Level 3 National Foundation Diploma in Games Development and IT (Enhanced)", string? courseID = "1024")
        {
            InitializeComponent();

            textBox1.Text = course;
            textBox2.Text = courseID;

            this.Text = userFirst;
            labelEmail.Text = userEmail;
            firstName = userFirst;
            lastName = userLast;
            email = userEmail;
        }

        private void StudentInfo_Load(object sender, EventArgs e)
        {
            versionLabel.Text = Application.ProductVersion;

            userDetail.Text = firstName + " " + lastName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = saveFileDialog1;

            saveFile.Title = "Export: " + email + "'s details to a file";

            saveFile.DefaultExt = "txt";
            saveFile.FileName = "Student.txt";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                string file_name = saveFile.FileName;

                using (Stream s = File.Open(file_name, FileMode.Create))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    string c = string.Format("{0} {1}'s Information: \n", firstName, lastName);

                    sw.WriteLine(c);

                    sw.WriteLine(string.Format("Email: {0}", email));
                    sw.WriteLine(string.Format("Firstname: {0}", firstName));
                    sw.WriteLine(string.Format("Lastname: {0}", lastName));
                    sw.WriteLine(string.Format("Lastname: {0}", lastName));
                    sw.WriteLine(string.Format("Course: {0}", textBox1.Text));
                    sw.WriteLine(string.Format("Course ID: {0}", textBox2.Text));

                    sw.Dispose();
                    MessageBox.Show(string.Format("Exported to: {0}", file_name));
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
                PrintDialog printDlg = new PrintDialog();
                PrintDocument printDoc = new PrintDocument();

                printDlg.Document = printDoc;
                printDlg.AllowSelection = true;
                printDlg.AllowSomePages = true;
                //Call ShowDialog
                if (printDlg.ShowDialog() == DialogResult.OK)
                {
                printDoc.PrintPage += new PrintPageEventHandler(pd_PrintPage);
                printDoc.Print();
            }            
        }

        private void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {
            ev.Graphics.DrawString("Test", Font, Brushes.Black,
                            ev.MarginBounds.Left, 0, new StringFormat());
        }
    }
}
