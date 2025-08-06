using System.Data;

namespace AplicatieCalculatorC_
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

        private void button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                textBox.Text += button.Text;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox.Clear();
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            try
            {
                var result = new DataTable().Compute(textBox.Text, null);
                textBox.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in calculation: " + ex.Message);
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            textBox.Text += "+";
        }
        private void buttonMinus_Click(object sender, EventArgs e)
        {
            textBox.Text += "-";
        }
        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            textBox.Text += "*";
        }
        private void buttonDivide_Click(object sender, EventArgs e)
        {
            textBox.Text += "/";

        }

    }
}
