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
    //Entry form
    public partial class College : Form
    {
        public College()
        {
            InitializeComponent();
        }

        //Choice between data editor and comparing test data
        private void button1_Click(object sender, EventArgs e)
        {
            //Instantiates and opens DataEditor
            DataEditor Data = new DataEditor();
            Data.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Instantiates and opens Compare
            FormCompare Compare = new FormCompare();
            Compare.Show();
        }
    }
}
