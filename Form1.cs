using System;
using System.Linq.Expressions;
using System.Text.RegularExpressions;

namespace Task3_Calculator
{
    public partial class Calculator : Form
    {
        public string MathematicalExample = null;
        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void ButtonDivide_Click(object sender, EventArgs e)
        {
            OutputWindow.Text += "÷";
            MathematicalExample += "/";
        }

        private void ButtonLeftParenthesis_Click(object sender, EventArgs e)
        {
            OutputWindow.Text += "(";
            MathematicalExample += "(";
        }

        private void ButtonRightParenthesis_Click(object sender, EventArgs e)
        {
            OutputWindow.Text += ")";
            MathematicalExample += ")";
        }

        private void ButtonPlus_Click(object sender, EventArgs e)
        {
            OutputWindow.Text += "+";
            MathematicalExample += "+";
        }

        private void ButtonOne_Click(object sender, EventArgs e)
        {
            OutputWindow.Text += "1";
            MathematicalExample += "1";
        }

        private void ButtonTwo_Click(object sender, EventArgs e)
        {
            OutputWindow.Text += "2";
            MathematicalExample += "2";
        }

        private void ButtonThree_Click(object sender, EventArgs e)
        {
            OutputWindow.Text += "3";
            MathematicalExample += "3";
        }

        private void ButtonFour_Click(object sender, EventArgs e)
        {
            OutputWindow.Text += "4";
            MathematicalExample += "4";
        }

        private void ButtonFive_Click(object sender, EventArgs e)
        {
            OutputWindow.Text += "5";
            MathematicalExample += "5";
        }

        private void ButtonSix_Click(object sender, EventArgs e)
        {
            OutputWindow.Text += "6";
            MathematicalExample += "6";
        }

        private void ButtonSeven_Click(object sender, EventArgs e)
        {
            OutputWindow.Text += "7";
            MathematicalExample += "7";
        }

        private void ButtonEight_Click(object sender, EventArgs e)
        {
            OutputWindow.Text += "8";
            MathematicalExample += "8";
        }

        private void ButtonNine_Click(object sender, EventArgs e)
        {
            OutputWindow.Text += "9";
            MathematicalExample += "9";
        }

        private void ButtonNull_Click(object sender, EventArgs e)
        {
            OutputWindow.Text += "0";
            MathematicalExample += "0";
        }

        private void ButtonPoint_Click(object sender, EventArgs e)
        {
            OutputWindow.Text += ".";
            MathematicalExample += ".";
        }

        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            OutputWindow.Text += "-";
            MathematicalExample += "-";
        }

        private void ButtonMultiply_Click(object sender, EventArgs e)
        {
            OutputWindow.Text += "×";
            MathematicalExample += "*";
        }

        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            if (OutputWindow.Text.Length > 0)
            {
               OutputWindow.Text = OutputWindow.Text.Remove(OutputWindow.Text.Length - 1);
            }
            if (MathematicalExample.Length > 0)
            {
                MathematicalExample = MathematicalExample.Remove(MathematicalExample.Length - 1);
            }
        }

        private void ButtonClearAll_Click(object sender, EventArgs e)
        {
            OutputWindow.Text = "";
            MathematicalExample = "";
        }

        private void ButtonCos_Click(object sender, EventArgs e)
        {
            OutputWindow.Text += "cos(";
            MathematicalExample += "cos(";
        }

        private void ButtonSin_Click(object sender, EventArgs e)
        {
            OutputWindow.Text += "sin(";
            MathematicalExample += "sin(";
        }

        private void ButtonTg_Click(object sender, EventArgs e)
        {
            OutputWindow.Text += "tg(";
            MathematicalExample += "tan(";
        }

        private void ButtonExponentiation_Click(object sender, EventArgs e)
        {
            OutputWindow.Text += "^";
            MathematicalExample += "^";
        }

        private void ButtonSqrt_Click(object sender, EventArgs e)
        {
            OutputWindow.Text += "√(";
            MathematicalExample += "sqrt(";
        }

        private void ButtonE_Click(object sender, EventArgs e)
        {
            OutputWindow.Text += "e";
            MathematicalExample += "e";
        }

        private void ButtonLn_Click(object sender, EventArgs e)
        {
            OutputWindow.Text += "ln(";
            MathematicalExample += "ln(";
        }

        private void ButtonLog_Click(object sender, EventArgs e)
        {
            OutputWindow.Text += "log(";
            MathematicalExample += "log10(";
        }

        private void ButtonPi_Click(object sender, EventArgs e)
        {
            OutputWindow.Text += "π";
            MathematicalExample += "pi";
        }

        private void ButtonEquals_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MathematicalExample)) return;

            try
            {
                string result = EvaluateExpression(MathematicalExample);
                OutputWindow.Text = result;
                MathematicalExample = result;
            }
            catch (Exception ex)
            {
                OutputWindow.Text = "Ошибка!" + ex;
                MathematicalExample = "";
            }
        }

        private string EvaluateExpression(string expression)
        {
            try
            {
                //пока без тригонометрии
                System.Data.DataTable dt = new System.Data.DataTable();
                var result = dt.Compute(expression, null);
                return result.ToString();
            }
            catch
            {
                throw new Exception("Неверное выражение");
            }
        }
    }
}
