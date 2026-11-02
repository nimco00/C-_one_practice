using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_practices
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            string Dayofweeklbl, monthlbl, Dayofthemonthlbl, yearlbl;

            Dayofweeklbl = textdayweek.Text;
            monthlbl = textmonth.Text;
            Dayofthemonthlbl = textdaymonth.Text;
            yearlbl = textyear.Text;
            textfulldata.Text = Dayofweeklbl + " " + monthlbl + " " + Dayofthemonthlbl + " " +
                yearlbl;

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            textdayweek.Clear();
            textmonth.Clear();
            textdaymonth.Clear();
            textyear.Clear();
            textdayweek.Focus();
            textfulldata.Text = "";
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
