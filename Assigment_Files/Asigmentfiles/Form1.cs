using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asigmentfiles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //creating new file
            StreamWriter outfiles ;
            //open the file - creating new file
            outfiles = File.CreateText("Home.txt");
            //process the file - writing the file
            outfiles.WriteLine(" welcome to CA242 ");
            outfiles.WriteLine(" My name is Naima Ahmed");
            outfiles.WriteLine(" My faculty is computer Science");

            //Close the file
            outfiles.Close();
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Example ofcreating new file , writing the file

            //Import Class
            StreamWriter outfiles;

            //use three process the file 
            //open the file - creating new file
            outfiles = File.CreateText(@"C:\Users\dhaaf\Downloads\output\khk.txt");


            //process the file - writing the file
            outfiles.WriteLine(" Welcome to CA242");
            outfiles.WriteLine(" waxaan ahay ardayad wax baraneeso");
            outfiles.WriteLine("jaamacada jamhuriya");

            //Close the file
            outfiles.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //import class 
            StreamReader outfiles;

            //open the file - raed the file
            //outfiles = File.OpenText(@"C:\Users\dhaaf\Downloads\output\hom.txt");
            outfiles = File.OpenText(@"C:\Users\dhaaf\Downloads\output\khk.txt");

            //process the file -  reading the file
            //creating variable
            String lines;
            //loops Reading All files items
            while (outfiles.EndOfStream == false)
            {
                //Assign the variable - return string 
                lines = outfiles.ReadLine();
                //assign listbox
                listBox1.Items.Add(lines);
            }
            //close the file
            outfiles.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //delete the file
            File.Delete(@"C:\Users\dhaaf\Downloads\output\khk.txt");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //reading the other function 
            StreamReader outfiles;

            outfiles = File.OpenText(@"C:\Users\dhaaf\Downloads\output\khk.txt");

            string lines;

            while (outfiles.EndOfStream == false)
            {
                lines = outfiles.ReadLine();
                listBox1.Items.Add(lines);
            }

            outfiles.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Delete item the file
            listBox1.Items.Remove(listBox1.SelectedItem);
        }
    }
}
