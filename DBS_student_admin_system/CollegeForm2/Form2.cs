using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeForm2
{
    //Compare form
    public partial class FormCompare : Form
    {
        //Test studentlist and teacherlist created
        List<Student> studentlist = new List<Student>();
        List<Teacher> teacherlist = new List<Teacher>();
        
        //Intatiate student and teacher classes
        Student stu = new Student();
        Teacher tea = new Teacher();
        Student stu2 = new Student();
        Teacher tea2 = new Teacher();


        public FormCompare()
        {
            //Sample data is displayed on all four list view boxes when form is opened
            InitializeComponent();
            

            stu.StudentID = "567890";
            stu.Status = "Undergraduate";
            stu.FName = "John";
            stu.LName = "Peters";
            stu.Phone = "1232342";
            stu.Email = "johnp@mail.net";

            studentlist.Add(stu);

            tea.FName = "John";
            tea.LName = "Peters";
            tea.salary = 25000m;
            tea.subjectTaught = "Maths";
            tea.Phone = "1232342";
            tea.Email = "johnp@mail.net";

            teacherlist.Add(tea);


            int x = 1;
            lvwCompare1.Columns.Add("Student", 85);
            lvwCompare1.Columns.Add("Student ID", 85);
            lvwCompare1.Columns.Add("Status", 85);
            lvwCompare1.Columns.Add("First Name", 85);
            lvwCompare1.Columns.Add("Last Name", 85);
            lvwCompare1.Columns.Add("Phone", 85);
            lvwCompare1.Columns.Add("Email", 85);

            ListViewItem data = new ListViewItem(x.ToString());
            data.SubItems.Add(stu.StudentID);
            data.SubItems.Add(stu.Status);
            data.SubItems.Add(stu.FName);
            data.SubItems.Add(stu.LName);
            data.SubItems.Add(stu.Phone);
            data.SubItems.Add(stu.Email);
            lvwCompare1.Items.Add(data);

            lvwCompare2.Columns.Add("Teacher", 85);
            lvwCompare2.Columns.Add("First Name", 85);
            lvwCompare2.Columns.Add("Last Name", 85);
            lvwCompare2.Columns.Add("Subject", 85);
            lvwCompare2.Columns.Add("Salary", 85);
            lvwCompare2.Columns.Add("Phone", 85);
            lvwCompare2.Columns.Add("Email", 85);

            ListViewItem data2 = new ListViewItem(x.ToString());
            data2.SubItems.Add(tea.FName);
            data2.SubItems.Add(tea.LName);
            data2.SubItems.Add(tea.subjectTaught);
            data2.SubItems.Add(tea.salary.ToString());
            data2.SubItems.Add(tea.Phone);
            data2.SubItems.Add(tea.Email);
            lvwCompare2.Items.Add(data2);

            

            stu2.StudentID = "90989080";
            stu2.Status = "Postgraduate";
            stu2.FName = "Peter";
            stu2.LName = "Johnson";
            stu2.Phone = "13453434";
            stu2.Email = "petejon@mail.net";

            studentlist.Add(stu2);


            tea2.FName = "Peter";
            tea2.LName = "John";
            tea2.salary = 32000m;
            tea2.subjectTaught = "Programming";
            tea2.Phone = "1897656";
            tea2.Email = "pete@mail.net";

            teacherlist.Add(tea2);

            lvwCompare3.Columns.Add("Student", 85);
            lvwCompare3.Columns.Add("Student ID", 85);
            lvwCompare3.Columns.Add("Status", 85);
            lvwCompare3.Columns.Add("First Name", 85);
            lvwCompare3.Columns.Add("Last Name", 85);
            lvwCompare3.Columns.Add("Phone", 85);
            lvwCompare3.Columns.Add("Email", 85);

            ListViewItem data3 = new ListViewItem(x.ToString());
            data3.SubItems.Add(stu2.StudentID);
            data3.SubItems.Add(stu2.Status);
            data3.SubItems.Add(stu2.FName);
            data3.SubItems.Add(stu2.LName);
            data3.SubItems.Add(stu2.Phone);
            data3.SubItems.Add(stu2.Email);
            lvwCompare3.Items.Add(data3);

            lvwCompare4.Columns.Add("Teacher", 85);
            lvwCompare4.Columns.Add("First Name", 85);
            lvwCompare4.Columns.Add("Last Name", 85);
            lvwCompare4.Columns.Add("Subject", 85);
            lvwCompare4.Columns.Add("Salary", 85);
            lvwCompare4.Columns.Add("Phone", 85);
            lvwCompare4.Columns.Add("Email", 85);

            ListViewItem data4 = new ListViewItem(x.ToString());
            data4.SubItems.Add(tea2.FName);
            data4.SubItems.Add(tea2.LName);
            data4.SubItems.Add(tea2.subjectTaught);
            data4.SubItems.Add(tea2.salary.ToString());
            data4.SubItems.Add(tea2.Phone);
            data4.SubItems.Add(tea2.Email);
            lvwCompare4.Items.Add(data4);

        }

        private void lvwCompare1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        //Compare button 1
        private void btnCompare_Click(object sender, EventArgs e)
        {
            //Compares the names of the student and teacher in the first set of test data and determines if they match
            if (stu.FName == tea.FName && stu.LName == tea.LName)
            {
                //Label used to tell if match or not
                lblCompare1.Text = "This is the same person as they have the same first and last name";
            }

            else
            {
                lblCompare1.Text = "This is not the same person as they have different names";
            }

        }

        //Compare button 2
        private void btnCompare2_Click(object sender, EventArgs e)
        {
            if (stu2.FName == tea2.FName && stu2.LName == tea2.LName)
            {
                lblCompare2.Text = "This is the same person as they have the same first and last name";
            }

            else
            {
                lblCompare2.Text = "This is not the same person as they have different names";
            }

        }
    }
}
