namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double value;
        string operation;
        bool operation_pressed;

        private void PnumberEvent(object sender, EventArgs e)
        {
            if ((operation == "+") || (operation == "-") || (operation == "*") || (operation == "/"))
            {
                if (operation_pressed)
                {
                    operation_pressed = false;
                    txt_result.Text = "0";
                }
            }
            Button b = sender as Button;
            if (txt_result.Text == "0")
                txt_result.Text = b.Text;
            else
                txt_result.Text += b.Text;
        }

        private void PoperationEvent(object sender, EventArgs e)
        {
            Button b = sender as Button;
            operation = b.Text;
            value = double.Parse(txt_result.Text);
            operation_pressed = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                switch (operation)
                {
                    case "+":
                        txt_result.Text = (value + double.Parse(txt_result.Text)).ToString();
                        break;
                    case "-":
                        txt_result.Text = (value - double.Parse(txt_result.Text)).ToString();
                        break;
                    case "*":
                        txt_result.Text = (value * double.Parse(txt_result.Text)).ToString();
                        break;
                    case "/":
                        txt_result.Text = (value / double.Parse(txt_result.Text)).ToString();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txt_result.Text = "0";
        }
    }
}
