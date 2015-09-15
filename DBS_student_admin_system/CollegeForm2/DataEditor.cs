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
    public partial class DataEditor : Form
    {
        //Two new lists are created, one for student, one for teacher
        List<Student> studentlist = new List<Student>();
        List<Teacher> teacherlist = new List<Teacher>();
        
        //Instantiate student and teacher
        Student stu = new Student();
        Teacher tea = new Teacher();
        public DataEditor()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
        private void DataEditor_Load(object sender, EventArgs e)
        {

        }

        //Add student button clicked
        private void btnAddStu_Click_1(object sender, EventArgs e)
        {
            //Strings used for temporary read in values
            string ID, status, fname, lname, phone, email;
            bool flag = true;

            
            //String values read in from text and combo boxes
                ID = txtID.Text;
                foreach (Student s in studentlist)
                {
                    //if statement used when ID matches ID already entered
                    if (s.StudentID == ID)
                    {
                        label13.Text = "The ID exists";
                        //Bool flag set to false when ID exists, exits back to main menu
                        flag = false;
                    }

                }
                status = cmbStatus.Text;
                fname = txtStuFName.Text;
                lname = txtStuLName.Text;

                /*foreach statements used to see if names or unique phone and email details are used for previous student or teacher
                  and informs user if they are through a label*/
                foreach (Student s in studentlist)
                {
                    if (s.FName == fname && s.LName == lname)
                    {
                        label13.Text = "Note: This person may already be entered.";
                    }
                }
                foreach (Teacher t in teacherlist)
                {
                    if (t.FName == fname && t.LName == lname)
                    {
                        label13.Text = "Note: This person may already be entered.";
                    }
                }


                email = txtStuEmail.Text;
                phone = txtStuPhone.Text;
                //Cancel entry (flag = false) if all text boxes were not filled
                if (ID == "" || status == "" || fname == "" || lname == "" || phone == "" || email == "")
                {
                    label13.Text = "Error: Not enough data";
                    flag = false;
                }
            
            
            //Cancels entry (flag = false) when phone or email is entered that belongs to a student already 
                foreach (Student s in studentlist)
                {
                    if (s.Phone == phone || s.Email == email)
                    {
                        MessageBox.Show("These attributes already exist for a different person");
                        flag = false;
                    }
                }
                foreach (Teacher t in teacherlist)
                {
                    if (t.Phone == phone || t.Email == email)
                    {
                        MessageBox.Show("These attributes already exist for a different person");
                        flag = false;
                    }
                }

                /*if bool flag remains true temporary string values are added to studentlist
                  by use of get set accessors in Person class*/
                if (flag)
                {
                    stu.StudentID = ID;
                    stu.Status = status;
                    stu.FName = fname;
                    stu.LName = lname;
                    stu.Phone = phone;
                    stu.Email = email;
                    studentlist.Add(stu);

                    label13.Text = "*Student added";


                    //Resets all text boxes
                    foreach (Control text in this.Controls)
                    {
                        foreach (Control text2 in text.Controls)
                        {
                            if (text2 is TextBox)
                            {
                                text2.Text = string.Empty;
                            }
                        }
                    }
                }
        }


        //Same approach when Add Teacher is clicked
        private void btnTeacher_Click_1(object sender, EventArgs e)
        {
            string subject, fname, lname, phone, email;
            decimal salary = 0;
            bool flag = true;

            fname = txtTeaFName.Text;
            lname = txtTeaLName.Text;
            foreach (Student s in studentlist)
            {
                if (s.FName == fname && s.LName == lname)
                {
                    label13.Text = "Note: This person may already be entered.";
                }
            }
            foreach (Teacher t in teacherlist)
            {
                if (t.FName == fname && t.LName == lname)
                {
                    label13.Text = "Note: This person may already be entered.";
                }
            }
            subject = txtSubject.Text;


            // Try catch used when no data entered for salary
            try
            {
                salary = decimal.Parse(txtSalary.Text);
            }
            catch (Exception)
            {
               
            }

            phone = txtTeaPhone.Text;
            email = txtTeaEmail.Text;
            
            
            if (subject == "" || fname == "" || lname == "" || phone == "" || email == "" || salary == 0)
            {
                label13.Text = "Error: Not enough data";
                flag = false;
            }


            foreach (Teacher t in teacherlist)
                {
                    if (t.Phone == phone || t.Email == email)
                    {
                        MessageBox.Show("These attributes already exist for a different person");
                        flag = false;
                    }
                }
            foreach (Student s in studentlist)
            {
                if (s.Phone == phone || s.Email == email)
                {
                    MessageBox.Show("These attributes already exist for a different person");
                    flag = false;
                }
            }

            if (flag)
            {
                tea.FName = fname;
                tea.LName = lname;
                tea.subjectTaught = subject;
                tea.salary = salary;
                tea.Phone = phone;
                tea.Email = email;
                teacherlist.Add(tea);

                label13.Text = "*Teacher added";
            }


            foreach (Control text in this.Controls)
            {
                foreach (Control text2 in text.Controls)
                {
                    if (text2 is TextBox)
                    {
                        text2.Text = string.Empty;
                    }
                }
            }
        }

        //Display all button
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            //if statement for when no data is in either list
            if (studentlist.Count == 0 && teacherlist.Count == 0)
            {
                label13.Text = "The list is Empty";
            }
            else
            {
                //List View used to display lists
                
                // x determines the row of data to be displayed
                int x = 1;
                //List is cleared when button is pressed
                lvwDisplay.Clear();
                //Displays all required rows with a width set to 85
                lvwDisplay.Columns.Add("Student", 85);
                lvwDisplay.Columns.Add("Student ID", 85);
                lvwDisplay.Columns.Add("Status", 85);
                lvwDisplay.Columns.Add("First Name", 85);
                lvwDisplay.Columns.Add("Last Name", 85);
                lvwDisplay.Columns.Add("Phone", 85);
                lvwDisplay.Columns.Add("Email", 85);
                foreach (Student s in studentlist)
                {
                    //Instantiates the ListViewItem option using the student overriden to string method
                    ListViewItem data = new ListViewItem(x.ToString());
                    //Adds each item to 'data'
                    data.SubItems.Add(s.StudentID);
                    data.SubItems.Add(s.Status);
                    data.SubItems.Add(s.FName);
                    data.SubItems.Add(s.LName);
                    data.SubItems.Add(s.Phone);
                    data.SubItems.Add(s.Email);
                    //Displays 'data'
                    lvwDisplay.Items.Add(data);
                }

                lvwDisplay2.Clear();
                lvwDisplay2.Columns.Add("Teacher", 85);
                lvwDisplay2.Columns.Add("First Name", 85);
                lvwDisplay2.Columns.Add("Last Name", 85);
                lvwDisplay2.Columns.Add("Subject", 85);
                lvwDisplay2.Columns.Add("Salary", 85);
                lvwDisplay2.Columns.Add("Phone", 85);
                lvwDisplay2.Columns.Add("Email", 100);
                foreach (Teacher t in teacherlist)
                {
                    ListViewItem data2 = new ListViewItem(x.ToString());
                    data2.SubItems.Add(t.FName);
                    data2.SubItems.Add(t.LName);
                    data2.SubItems.Add(t.subjectTaught);
                    data2.SubItems.Add(t.salary.ToString());
                    data2.SubItems.Add(t.Phone);
                    data2.SubItems.Add(t.Email);
                    lvwDisplay2.Items.Add(data2);

                }
                //x increased in order to proceed to next row
                x++;
            }

            //All text boxes emptied
            foreach (Control text in this.Controls)
            {
                foreach (Control text2 in text.Controls)
                {
                    if (text2 is TextBox)
                    {
                        text2.Text = string.Empty;
                    }
                }
            }
        }

        //Search button
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Bool used for when match is or isn't found
            bool FoundMatch = false;
            string lname;
            //Two int's used for two list views
            int x = 1, y = 1;

            //Text box for last name
            lname = txtSearch.Text;

            //Clears list view for student
            lvwDisplay.Clear();

            //Checks for match between entered last name and data currently stored
            foreach (Student s in studentlist)
            {
                if (s.LName == lname)
                {
                    //Displays all mathces found
                    lvwDisplay.Columns.Add("Student", 85);
                    lvwDisplay.Columns.Add("Student ID", 85);
                    lvwDisplay.Columns.Add("Status", 85);
                    lvwDisplay.Columns.Add("First Name", 85);
                    lvwDisplay.Columns.Add("Last Name", 85);
                    lvwDisplay.Columns.Add("Phone", 85);
                    lvwDisplay.Columns.Add("Email", 100);
                    
                    ListViewItem data = new ListViewItem(y.ToString());
                    data.SubItems.Add(s.StudentID);
                    data.SubItems.Add(s.Status);
                    data.SubItems.Add(s.FName);
                    data.SubItems.Add(s.LName);
                    data.SubItems.Add(s.Phone);
                    data.SubItems.Add(s.Email);
                    lvwDisplay.Items.Add(data);
                    FoundMatch = true;
                }
                //Increases y for another potential entry
                y++;
            }

            //When bool is false and no matches are found, displayed through label13
            if (!FoundMatch)
            {
                label13.Text = "No matches found";
            }

            //Same approach for teacher list view box
            lvwDisplay2.Clear();
            foreach (Teacher t in teacherlist)
            {
                if (t.LName == lname)
                {

                    lvwDisplay2.Columns.Add("Teacher", 85);
                    lvwDisplay2.Columns.Add("First Name", 85);
                    lvwDisplay2.Columns.Add("Last Name", 85);
                    lvwDisplay2.Columns.Add("Subject", 85);
                    lvwDisplay2.Columns.Add("Salary", 85);
                    lvwDisplay2.Columns.Add("Phone", 85);
                    lvwDisplay2.Columns.Add("Email", 100);

                    ListViewItem data2 = new ListViewItem(x.ToString());
                    data2.SubItems.Add(t.FName);
                    data2.SubItems.Add(t.LName);
                    data2.SubItems.Add(t.subjectTaught);
                    data2.SubItems.Add(t.salary.ToString());
                    data2.SubItems.Add(t.Phone);
                    data2.SubItems.Add(t.Email);
                    lvwDisplay2.Items.Add(data2);

                    FoundMatch = true;
                }

                x++;
            }
                if (!FoundMatch)
                {
                    label13.Text = "No matches found";
                }
            //Clears all text boxes
                foreach (Control text in this.Controls)
                {
                    foreach (Control text2 in text.Controls)
                    {
                        if (text2 is TextBox)
                        {
                            text2.Text = string.Empty;
                        }
                    }
                }
        }
    

        

        private void lvwDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        //Remove button
        private void btnRemove_Click(object sender, EventArgs e)
        {
            //Entry removed based on unique phone number
            bool FoundMatch2 = false;
            string phone;

            //Phone number entered through text box
            phone = txtPhone.Text;


            //Checks if entered phone number exists
            for (int i = 0; i < studentlist.Count; i++)
            {
                Student s = studentlist[i];
                if (s.Phone == phone)
                {
                        studentlist.Remove(s);
                    //Message box opens to display message
                        MessageBox.Show("Student removed"); 
                        FoundMatch2 = true;
                }

                if (!FoundMatch2)
                {
                    Console.WriteLine("No match found");
                }
            }

            //Repeated for teacher
            for (int j = 0; j < teacherlist.Count; j++)
            {
                Teacher t = teacherlist[j];

                if (t.Phone == phone)
                {
                 
                        teacherlist.Remove(t);
                        MessageBox.Show("Teacher removed");
                        FoundMatch2 = true;
           
                }
                if (!FoundMatch2)
                {
                    Console.WriteLine("No match found");

                }
            }
        }

    }
}
