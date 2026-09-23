using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assigment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnshowinfo_Click(object sender, EventArgs e)
        {

            //stage 1of input
            //creating variable

            string name,department,fulldata;
            int studentid;
            int semester;

            //initial values to variable
            name = txtname.Text;
            studentid = int.Parse(txtstudentid.Text);
            department = txtdepartment.Text;
            semester = int.Parse(txtsemester.Text);

            //stage 2 process - comcatination of fulldata
            
            fulldata= name + " " +studentid + " " +department + " " +semester;

            //stage 3 output using lable
            lbloutput.Text = fulldata;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            //cleaning texbox and label
            txtname.Clear();
            txtstudentid.Clear();
            txtdepartment.Clear();
            txtsemester.Clear();
            lbloutput.Text = " ";
        }
    }
}
