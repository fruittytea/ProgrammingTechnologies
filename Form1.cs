namespace Task3_Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void ButtonDivide_Click(object sender, EventArgs e)
        {
            OutputWindow.Text += "/";
        }

        private void ButtonLeftParenthesis_Click(object sender, EventArgs e)
        {
            OutputWindow.Text += "(";
        }

        private void ButtonRightParenthesis_Click(object sender, EventArgs e)
        {
            OutputWindow.Text += ")";
        }

        private void ButtonPercent_Click(object sender, EventArgs e)
        {
            OutputWindow.Text += "%";
        }

        private void ButtonPlus_Click(object sender, EventArgs e)
        {
            OutputWindow.Text += "+";
        }

        private void ButtonOne_Click(object sender, EventArgs e)
        {
            OutputWindow.Text += "1";
        }

        private void ButtonTwo_Click(object sender, EventArgs e)
        {
            OutputWindow.Text += "2";
        }

        private void ButtonThree_Click(object sender, EventArgs e)
        {
            OutputWindow.Text += "3";
        }

        private void ButtonFour_Click(object sender, EventArgs e)
        {
            OutputWindow.Text += "4";
        }

        private void ButtonFive_Click(object sender, EventArgs e)
        {
            OutputWindow.Text += "5";
        }

        private void ButtonSix_Click(object sender, EventArgs e)
        {
            OutputWindow.Text += "6";
        }

        private void ButtonSeven_Click(object sender, EventArgs e)
        {
            OutputWindow.Text += "7";
        }

        private void ButtonEight_Click(object sender, EventArgs e)
        {
            OutputWindow.Text += "8";
        }

        private void ButtonNine_Click(object sender, EventArgs e)
        {
            OutputWindow.Text += "9";
        }

        private void ButtonNull_Click(object sender, EventArgs e)
        {
            OutputWindow.Text += "0";
        }

        private void ButtonPoint_Click(object sender, EventArgs e)
        {
            OutputWindow.Text += ".";
        }

        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            OutputWindow.Text += "-";
        }

        private void ButtonMultiply_Click(object sender, EventArgs e)
        {
            OutputWindow.Text += "x";
        }

        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            string OutputText = OutputWindow.Text;
            if (OutputText.Length > 0)
            {
                OutputText = OutputText.Remove(OutputText.Length - 1);
            }
            OutputWindow.Text = OutputText;
        }

        private void ButtonClearAll_Click(object sender, EventArgs e)
        {
            OutputWindow.Text = "";
        }

        private void ButtonCos_Click(object sender, EventArgs e)
        {
            OutputWindow.Text += "cos(";
        }

        private void ButtonSin_Click(object sender, EventArgs e)
        {
            OutputWindow.Text += "sin(";
        }

        private void ButtonTg_Click(object sender, EventArgs e)
        {
            OutputWindow.Text += "tg(";
        }

        private void ButtonExponentiation_Click(object sender, EventArgs e)
        {
            OutputWindow.Text += "^";
        }

        private void ButtonSqrt_Click(object sender, EventArgs e)
        {
            OutputWindow.Text += "sqrt(";
        }

        private void ButtonE_Click(object sender, EventArgs e)
        {
            OutputWindow.Text += "e";
        }

        private void ButtonLn_Click(object sender, EventArgs e)
        {
            OutputWindow.Text += "ln(";
        }

        private void ButtonLog_Click(object sender, EventArgs e)
        {
            OutputWindow.Text += "log(";
        }

        private void ButtonPi_Click(object sender, EventArgs e)
        {
            OutputWindow.Text += "π";
        }
    }
}
