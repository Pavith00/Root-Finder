using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NewProb_Click(object sender, EventArgs e)
        {
            atxt.Clear();
            btxt.Clear();
            ctxt.Clear();
            rootsLbl.Text = "Number of roots:";

        }

        private void solve_Click(object sender, EventArgs e)
        {
            int a = int.Parse(atxt.Text);
            int b = int.Parse(btxt.Text);
            int c = int.Parse(ctxt.Text);
            int d = b * b - 4 * a * c;
            if (d > 0)
            {
                /*int x=(-b+(b*b-4*a)^1/2)/(2*a);
                int y = (-b - (b * b - 4 * a) ^ 1 / 2) / (2 * a);*/
                rootsLbl.Text = "Number of roots: 2";
            }
            else if (d == 0)
            {
                /*int x = (-b + (b * b - 4 * a) ^ 1 / 2) / (2 * a);*/
                rootsLbl.Text = "Number of roots: 1";
            }
            else
            {
                rootsLbl.Text = "Number of roots: No roots";
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


        
       

        
