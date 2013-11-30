using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EscapeVelocityCalculator
{

    public partial class Form1 : Form
    {
        private const string Version = "1.0 Beta";
        private const double G = 6.67300E-11; // gravitational constant (close approximation)
        private double M = 0.0;
        private double r = 0.0;
        private double eV;

        public Form1()
        {
            InitializeComponent();
            txtBoxEscapeVe.Enabled = false;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try 
            {
                try              
	            {	        
		            M = Double.Parse(txtBoxMass.Text);
	            }
	            catch (Exception e1)
	            { 
                    System.Console.WriteLine(e1.Message);
                }
                try 
	            {	        
		                 r = Double.Parse(txtBoxRadius.Text);
	            }
	            catch (Exception e2)
	            {
                    System.Console.WriteLine(e2.Message);
                }
                try              
	            {	        
                    eV = Double.Parse(txtBoxEscapeVe.Text);
	            }
	            catch (Exception e3)
	            {
                    System.Console.WriteLine(e3.Message);
                }

                DoEscapeVeCalc();

            }
            catch (Exception e4) 
            {
                System.Console.WriteLine(e4.Message);
            }
        }

        private void DoEscapeVeCalc()
        {
            if (M > 0 && r > 0)
            {
                eV = Math.Sqrt((2 * (G * M)) / r);
                txtBoxEscapeVe.Text = eV.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            M = 0.0;
            r = 0.0;
            eV = 0.0;

            txtBoxEscapeVe.Text = "";
            txtBoxMass.Text = "";
            txtBoxRadius.Text = "";
        }

        private void btnEarth_Click(object sender, EventArgs e)
        {
            M = 5.97219E+24;
            txtBoxMass.Text = M.ToString();
            r = 6371.0;
            txtBoxRadius.Text = r.ToString();
            eV = 0.0;
            this.DoEscapeVeCalc();
        }

        private void btnMoon_Click(object sender, EventArgs e)
        {
            M = 7.3477E+22;
            txtBoxMass.Text = M.ToString();
            r = 1737.10;
            txtBoxRadius.Text = r.ToString();
            eV = 0.0;
            this.DoEscapeVeCalc();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
