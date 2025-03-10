using Microsoft.VisualBasic.Devices;

namespace Student_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            versionLabel.Text = Application.ProductVersion;
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            string firstName = textBox1.Text;
            string lastName = textBox2.Text;
            string email = textBox3.Text;


            if (string.IsNullOrEmpty(firstName) && string.IsNullOrEmpty(lastName) && string.IsNullOrEmpty(email))
            {
                MessageBox.Show("You must enter a First Name, Email and a Last Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!email.Contains("@"))
            {
                MessageBox.Show("Your email is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (char.IsUpper(firstName[0]) && char.IsUpper(lastName[0]))
            {
                StudentInfo studentInfo = new StudentInfo(firstName, lastName, email);

                studentInfo.ShowDialog();

            }
            else
            {
                MessageBox.Show("The Fields are invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        List<string> strings = new List<string>();

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = openFileDialog1;
            open.Title = "Select your student information form";

            if (open.ShowDialog() == DialogResult.OK)
            {
                List<string> values = File.ReadAllLines(open.FileName).ToList();

                if (values.Count == 0)
                {
                    MessageBox.Show("No Information found", "Invalid file");
                    return;
                }

                string email = "", firstname = "", lastname = "", course = "", courseID = "";

                foreach (var line in values)
                {
                    if (line.StartsWith("Email:"))
                    {
                        email = line.Replace("Email:", "").Trim();
                    }
                    else if (line.StartsWith("Firstname:"))
                    {
                        firstname = line.Replace("Firstname:", "").Trim();
                    }
                    else if (line.StartsWith("Lastname:"))
                    {
                        lastname = line.Replace("Lastname:", "").Trim();
                    }
                    else if (line.StartsWith("Course:"))
                    {
                        course = line.Replace("Course:", "").Trim();
                    }
                    else if (line.StartsWith("Course ID:"))
                    {
                        courseID = line.Replace("Course ID:", "").Trim();
                    }
                }

                StudentInfo studentInfo = new StudentInfo(firstname, lastname, email, course, courseID);

                studentInfo.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
