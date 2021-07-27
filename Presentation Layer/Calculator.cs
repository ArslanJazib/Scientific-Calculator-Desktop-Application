using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicTier;
namespace VPAssignment3
{
    public partial class Calculator : Form
    {
        Calculate calculate = new Calculate();

        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CalculatorTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void basicCalculatorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            scientificOptions1.Visible = false;
            scientificOptions2.Visible = false;
        }

        private void scientificCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scientificOptions1.Visible = true;
            scientificOptions2.Visible = true;
        }

        private void zero_Click(object sender, EventArgs e)
        {
            
            InputDisplay.Text += "0";
        }

        private void one_Click(object sender, EventArgs e)
        {
            InputDisplay.Text += "1";
        }

        private void two_Click(object sender, EventArgs e)
        {
            InputDisplay.Text += "2";
        }

        private void three_Click(object sender, EventArgs e)
        {
            InputDisplay.Text += "3";
        }

        private void four_Click(object sender, EventArgs e)
        {
            InputDisplay.Text += "4";
        }

        private void five_Click(object sender, EventArgs e)
        {
            InputDisplay.Text += "5";
        }

        private void six_Click(object sender, EventArgs e)
        {
            InputDisplay.Text += "6";
        }

        private void seven_Click(object sender, EventArgs e)
        {
            InputDisplay.Text += "7";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            InputDisplay.Text += "8";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            InputDisplay.Text += "9";
        }

        private void dec_Click(object sender, EventArgs e)
        {
            InputDisplay.Text=calculate.validate(InputDisplay.Text, dec.Name);
        }

        private void braces_Click(object sender, EventArgs e)
        {
            InputDisplay.Text = calculate.validate(InputDisplay.Text, braces.Name);
        }

        private void ans_Click(object sender, EventArgs e)
        {
            InputDisplay.Text+= OutDisplay.Text;
        }

        private void equal_Click(object sender, EventArgs e)
        {
            calculate.calculateOutput(InputDisplay.Text);
        }

        private void plus_Click(object sender, EventArgs e)
        {
            InputDisplay.Text = calculate.validate(InputDisplay.Text, plus.Name);
        }

        private void minus_Click(object sender, EventArgs e)
        {
            InputDisplay.Text = calculate.validate(InputDisplay.Text, minus.Name);
        }

        private void mod_Click(object sender, EventArgs e)
        {
            InputDisplay.Text = calculate.validate(InputDisplay.Text, mod.Name);
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            InputDisplay.Text = calculate.validate(InputDisplay.Text, multiply.Name);
        }

        private void remove_Click(object sender, EventArgs e)
        {
            try
            {
                InputDisplay.Text = InputDisplay.Text.Remove(InputDisplay.Text.Length - 1, 1);

            }
            catch(Exception)
            {

            }
        }

        private void divide_Click(object sender, EventArgs e)
        {
            InputDisplay.Text = calculate.validate(InputDisplay.Text, divide.Name);
        }

        private void denote_Click(object sender, EventArgs e)
        {
            InputDisplay.Text = calculate.validate(InputDisplay.Text, denote.Name);
        }

        private void bar_Click(object sender, EventArgs e)
        {
            InputDisplay.Text = calculate.validate(InputDisplay.Text, bar.Name);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            InputDisplay.Clear();
            OutDisplay.Clear();
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            InputDisplay.Text = calculate.validate(InputDisplay.Text, sqrt.Name);
        }

        private void pi_Click(object sender, EventArgs e)
        {
            InputDisplay.Text = calculate.validate(InputDisplay.Text, pi.Name);
        }

        private void factorial_Click(object sender, EventArgs e)
        {
            InputDisplay.Text = calculate.validate(InputDisplay.Text, factorial.Name);
        }

        private void fraction_Click(object sender, EventArgs e)
        {
            InputDisplay.Text = calculate.validate(InputDisplay.Text, fraction.Name);
        }

        private void radian_degree_Click(object sender, EventArgs e)
        {
            if(radian_degree.Text=="Rad")
            {
                radian_degree.Text = "Deg";
            }
            else if(radian_degree.Text == "Deg")
            {
                radian_degree.Text = "Rad";
            }
        }

        private void lognatural_base_Click(object sender, EventArgs e)
        {
            if (lognatural_base.Text == "ln")
            {
                InputDisplay.Text = calculate.validate(InputDisplay.Text, "ln");
            }
            else
            {
                InputDisplay.Text = calculate.validate(InputDisplay.Text, "log_2");
            }
        }

        private void exponent_Click(object sender, EventArgs e)
        {
            InputDisplay.Text = calculate.validate(InputDisplay.Text, exponent.Name);
        }

        private void power_Click(object sender, EventArgs e)
        {
            InputDisplay.Text = calculate.validate(InputDisplay.Text, power.Name);

        }

        private void cube_Click(object sender, EventArgs e)
        {
            InputDisplay.Text = calculate.validate(InputDisplay.Text, cube.Name);

        }

        private void square_Click(object sender, EventArgs e)
        {
            InputDisplay.Text = calculate.validate(InputDisplay.Text, square.Name);

        }

        private void log_Click(object sender, EventArgs e)
        {

        }

        private void tan_tani_Click(object sender, EventArgs e)
        {
            if (tan_tani.Text == "tan")
            {
                InputDisplay.Text = calculate.validate(InputDisplay.Text, "tan");
            }
            else
            {
                InputDisplay.Text = calculate.validate(InputDisplay.Text, "tan^-1");
            }
        }

        private void cos_cosi_Click(object sender, EventArgs e)
        {
            if (cos_cosi.Text == "cos")
            {
                InputDisplay.Text = calculate.validate(InputDisplay.Text, "cos");
            }
            else
            {
                InputDisplay.Text = calculate.validate(InputDisplay.Text, "cos^-1");
            }
        }

        private void sin_sini_Click(object sender, EventArgs e)
        {
            if(sin_sini.Text== "sin")
            {
                InputDisplay.Text = calculate.validate(InputDisplay.Text, "sin");
            }
            else
            {
                InputDisplay.Text = calculate.validate(InputDisplay.Text, "sin^-1");
            }
        }

        private void shift_Click(object sender, EventArgs e)
        {
            if(shift.ButtonColor==Color.Orange)
            {
                shift.ButtonColor = Color.Silver;
                sin_sini.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                sin_sini.Text = "sin^-1";
                cos_cosi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                cos_cosi.Text = "cos^-1";
                tan_tani.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                tan_tani.Text = "tan^-1";
                lognatural_base.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lognatural_base.Text = "log_2";
            }
            else
            {
                shift.ButtonColor = Color.Orange;
                sin_sini.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                sin_sini.Text = "sin";
                cos_cosi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                cos_cosi.Text = "cos";
                tan_tani.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                tan_tani.Text = "tan";
                lognatural_base.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lognatural_base.Text = "ln";
            }
        }
    }
}
