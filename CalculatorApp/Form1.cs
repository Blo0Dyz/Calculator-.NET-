namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int value1 = 1;
        int value2 = 2;

        private void btn_1_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "1";
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            string currentText = label1.Text;

            if (!string.IsNullOrEmpty(currentText))
            {
                label1.Text = currentText.Substring(0, currentText.Length - 1);
            }
        }

        private void btn_more_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "+";
        }

        private void btn_result_Click(object sender, EventArgs e)
        {
            

        }
    }
}
