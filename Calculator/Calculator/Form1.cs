using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string currentCalc="";
        public Form1()
        {
            InitializeComponent();
        }
        private void button_Click(object sender, EventArgs e)
        {
            currentCalc += (sender as Button).Text;
            txt_Output.Text = currentCalc;
        }
        private void button_Equals_Click(object sender, EventArgs e)
        {
            string formattedCalc = currentCalc.ToString().Replace("x", "*").ToString().Replace("÷", "/");

            try
            {
                txt_Output.Text = new DataTable().Compute(formattedCalc, null).ToString();
                currentCalc = txt_Output.Text;
            }
            catch (Exception ex)
            {
                txt_Output.Text = "0";
                currentCalc = "";
            }
        }
        private void button_Clear_Click(object sender, EventArgs e)
        {
            txt_Output.Text = "0";
            currentCalc = "";
        }
        private void button_Back_Click(object sender, EventArgs e)
        {
            if (currentCalc.Length > 0)
            {
                currentCalc = currentCalc.Remove(currentCalc.Length - 1, 1);
            }

            txt_Output.Text = currentCalc;
        }
    }
}
