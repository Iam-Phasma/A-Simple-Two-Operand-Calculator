using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorModule
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbl_screen.ResetText();                   //to reset screen at the start
        }



        //NUMBERS//
        private void btn_1_Click(object sender, EventArgs e)
        {
            //lbl_screen.ResetText();                           //screen will reset after num2 
            long one = 1;                                     //initializing value
            lbl_screen.Text += (one);                         //appending value, not adding
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            //lbl_screen.ResetText();
            long two = 2;
            lbl_screen.Text += (two);
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            //lbl_screen.ResetText();
            long three = 3;
            lbl_screen.Text += (three);
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            //lbl_screen.ResetText();
            long four = 4;
            lbl_screen.Text += (four);
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            //lbl_screen.ResetText();
            long five = 5;
            lbl_screen.Text += (five);
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            //lbl_screen.ResetText();
            long six = 6;
            lbl_screen.Text += (six);
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            //lbl_screen.ResetText();
            long seven = 7;
            lbl_screen.Text += (seven);
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            //lbl_screen.ResetText();
            long eight = 8;
            lbl_screen.Text += (eight);
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            //lbl_screen.ResetText();
            long nine = 9;
            lbl_screen.Text += (nine);
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            //lbl_screen.ResetText();
            long zero = 0;
            lbl_screen.Text += (zero);
        }








        //ARITHMETIC//
        private void btn_plus_Click(object sender, EventArgs e)
        {
            try                                                         //when user click buttons in invalid order
            {
                calc.num1 = Convert.ToInt64(lbl_screen.Text);           //converting long value to Text form so it can be displayed in screen
                calc.arith = "+";                                       //initializing operation
                //Console.WriteLine(calc.num1);
                lbl_screen.ResetText();                                 //clearing screen for second number input
                //lbl_screen.Text = calc.arith;                         //displaying initialized operation
                btn_plus.BackColor = System.Drawing.Color.DarkOrange;   //changing button color to distinguish

            }
            catch(Exception a){

            }
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            try
            {
                calc.num1 = Convert.ToInt64(lbl_screen.Text);
                calc.arith = "-";
                //Console.WriteLine(calc.num1);
                lbl_screen.ResetText();
                //lbl_screen.Text = calc.arith;
                btn_minus.BackColor = System.Drawing.Color.DarkOrange;
            }
            catch (Exception a)
            {

            }
        }

        private void btn_multiply_Click(object sender, EventArgs e)
        {
            try
            {
                calc.num1 = Convert.ToInt64(lbl_screen.Text);
                calc.arith = "x";
                //Console.WriteLine(calc.num1);
                lbl_screen.ResetText();
                //lbl_screen.Text = calc.arith;
                btn_multiply.BackColor = System.Drawing.Color.DarkOrange;
            }
            catch (Exception a)
            {

            }
        }

        private void btn_devide_Click(object sender, EventArgs e)
        {
            try
            {
                calc.num1 = Convert.ToInt64(lbl_screen.Text);
                calc.arith = "/";
                //Console.WriteLine(calc.num1);
                lbl_screen.ResetText();
                //lbl_screen.Text = calc.arith;
                btn_devide.BackColor = System.Drawing.Color.DarkOrange;
            }
            catch (Exception a)
            {

            }
        }








        //EQUALS//
        private void btn_equals_Click(object sender, EventArgs e)
        {
            if (calc.arith.Equals("+")) { 
                try
                {
                    btn_plus.BackColor = System.Drawing.SystemColors.ControlDarkDark;   //reverting back the default color
                    calc.num2 = Convert.ToInt64(lbl_screen.Text);                       //initializing the second input to num2 after chosen operation
                    lbl_screen.ResetText();                                             //reset screen when = is clicked
                    long sum = calc.num1 + calc.num2;                                   //calculating the 2 values

                    lbl_screen.Text = Convert.ToInt64(sum).ToString();                  //displaying the answer while also converting long value answer to Text form
                    calc.num1 = 0;                                                      //reseting num1 value
                    calc.num2 = 0;                                                      //reseting num2 value
                    btn_clear.BackColor = System.Drawing.Color.DarkRed;                 //alerting to reset

                    btn_1.Enabled = false;
                    btn_2.Enabled = false;
                    btn_3.Enabled = false;
                    btn_4.Enabled = false;
                    btn_5.Enabled = false;
                    btn_6.Enabled = false;
                    btn_7.Enabled = false;
                    btn_8.Enabled = false;
                    btn_9.Enabled = false;
                    btn_zero.Enabled = false;
                    btn_plus.Enabled = false;
                    btn_minus.Enabled = false;
                    btn_multiply.Enabled = false;
                    btn_devide.Enabled = false;
                    btn_equals.Enabled = false;

                }
                catch (Exception a)
                {

                }
            }else if (calc.arith.Equals("-")){
                try
                {
                    btn_minus.BackColor = System.Drawing.SystemColors.ControlDarkDark;
                    calc.num2 = Convert.ToInt64(lbl_screen.Text);
                    lbl_screen.ResetText();
                    long diff = calc.num1 - calc.num2;

                    lbl_screen.Text = Convert.ToInt64(diff).ToString();
                    calc.num1 = 0;
                    calc.num2 = 0;
                    btn_clear.BackColor = System.Drawing.Color.DarkRed;

                    btn_1.Enabled = false;
                    btn_2.Enabled = false;
                    btn_3.Enabled = false;
                    btn_4.Enabled = false;
                    btn_5.Enabled = false;
                    btn_6.Enabled = false;
                    btn_7.Enabled = false;
                    btn_8.Enabled = false;
                    btn_9.Enabled = false;
                    btn_zero.Enabled = false;
                    btn_plus.Enabled = false;
                    btn_minus.Enabled = false;
                    btn_multiply.Enabled = false;
                    btn_devide.Enabled = false;
                    btn_equals.Enabled = false;

                }
                catch (Exception a)
                {

                }
            }else if (calc.arith.Equals("x")){
                try
                {
                    btn_multiply.BackColor = System.Drawing.SystemColors.ControlDarkDark;
                    calc.num2 = Convert.ToInt64(lbl_screen.Text);
                    lbl_screen.ResetText();
                    long diff = calc.num1 * calc.num2;

                    lbl_screen.Text = Convert.ToInt64(diff).ToString();
                    calc.num1 = 0;
                    calc.num2 = 0;
                    btn_clear.BackColor = System.Drawing.Color.DarkRed;

                    btn_1.Enabled = false;
                    btn_2.Enabled = false;
                    btn_3.Enabled = false;
                    btn_4.Enabled = false;
                    btn_5.Enabled = false;
                    btn_6.Enabled = false;
                    btn_7.Enabled = false;
                    btn_8.Enabled = false;
                    btn_9.Enabled = false;
                    btn_zero.Enabled = false;
                    btn_plus.Enabled = false;
                    btn_minus.Enabled = false;
                    btn_multiply.Enabled = false;
                    btn_devide.Enabled = false;
                    btn_equals.Enabled = false;

                }
                catch (Exception a)
                {

                }
            }else if (calc.arith.Equals("/"))
            {
                try
                {
                    btn_devide.BackColor = System.Drawing.SystemColors.ControlDarkDark;
                    calc.num2 = Convert.ToInt64(lbl_screen.Text);
                    lbl_screen.ResetText();
                    long diff = calc.num1 / calc.num2;

                    lbl_screen.Text = Convert.ToInt64(diff).ToString();
                    calc.num1 = 0;
                    calc.num2 = 0;
                    btn_clear.BackColor = System.Drawing.Color.DarkRed;

                    btn_1.Enabled = false;
                    btn_2.Enabled = false;
                    btn_3.Enabled = false;
                    btn_4.Enabled = false;
                    btn_5.Enabled = false;
                    btn_6.Enabled = false;
                    btn_7.Enabled = false;
                    btn_8.Enabled = false;
                    btn_9.Enabled = false;
                    btn_zero.Enabled = false;
                    btn_plus.Enabled = false;
                    btn_minus.Enabled = false;
                    btn_multiply.Enabled = false;
                    btn_devide.Enabled = false;
                    btn_equals.Enabled = false;


                }
                catch (Exception a)
                {

                }
            }

        }







        //OTHER//
        private void button1_Click(object sender, EventArgs e)
        {
            //calc.arith = " ";
            lbl_screen.ResetText();
            btn_plus.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            btn_minus.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            btn_multiply.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            btn_devide.BackColor = System.Drawing.SystemColors.ControlDarkDark;

            btn_clear.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            btn_1.Enabled = true;
            btn_2.Enabled = true;
            btn_3.Enabled = true;
            btn_4.Enabled = true;
            btn_5.Enabled = true;
            btn_6.Enabled = true;
            btn_7.Enabled = true;
            btn_8.Enabled = true;
            btn_9.Enabled = true;
            btn_zero.Enabled = true;
            btn_plus.Enabled = true;
            btn_minus.Enabled = true;
            btn_multiply.Enabled = true;
            btn_devide.Enabled = true;
            btn_equals.Enabled = true;

        }

        
    }
}
