using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week4
{
    public partial class SimpleCalculator : Form
    {

        private string mathOp;

        public SimpleCalculator()
        {
            InitializeComponent();
        }

        private void Btn_Submit_Click(object sender, EventArgs e)
        {
            DoMath();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            mathOp = "add";
        }   

        private void Btn_Subtract_Click(object sender, EventArgs e)
        {
            mathOp = "min";
        }

        private void Btn_Multiply_Click(object sender, EventArgs e)
        {
            mathOp = "mul";
        }

        private void Btn_Divide_Click(object sender, EventArgs e)
        {
            mathOp = "div";
        }

        private void DoMath()
        {
            try
            {
                switch (mathOp)
                {
                    case "add":
                        OutputWindow.Text += ($"{ValOne.Text} + {ValTwo.Text} = {Convert.ToInt16(ValOne.Text) + Convert.ToInt16(ValTwo.Text)}\n");
                        break;
                    case "min":
                        OutputWindow.Text += ($"{ValOne.Text} - {ValTwo.Text} = {Convert.ToInt16(ValOne.Text) - Convert.ToInt16(ValTwo.Text)}\n");
                        break;
                    case "mul":
                        OutputWindow.Text += ($"{ValOne.Text} * {ValTwo.Text} = {Convert.ToInt16(ValOne.Text) * Convert.ToInt16(ValTwo.Text)}\n");
                        break;
                    case "div":
                        OutputWindow.Text += ($"{ValOne.Text} / {ValTwo.Text} = {Convert.ToInt16(ValOne.Text) / Convert.ToInt16(ValTwo.Text)}\n");
                        break;
                    default:
                        MessageBox.Show("select an operation");
                        break;
                }
            }
            catch(FormatException ex)
            {
                MessageBox.Show("Numbers only!");
            }
        }
    }
}
