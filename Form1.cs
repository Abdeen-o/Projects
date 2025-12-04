using System.Diagnostics.Eventing.Reader;

namespace Calculator_DU
{
    public partial class Form1 : Form
    {


        string operation = "";
        double result = 0;
        bool isoperation = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button btx = (Button)sender;

            if (textBox1.Text == "0" || isoperation == true)
            {
                textBox1.Clear();
                isoperation = false;
            }


            if (btx.Text == ".")
            {

                if (textBox1.Text.Contains("."))
                    return;


                if (textBox1.Text == "")
                    textBox1.Text = "0.";
                else
                    textBox1.Text += ".";
            }
            else
            {

                textBox1.Text += btx.Text;
            }
        }



        private void button11_Click(object sender, EventArgs e)
        {
            Button btx = (Button)sender;
            operation = btx.Text;
            result = double.Parse(textBox1.Text);
            isoperation = true;


        }

        private void button12_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    textBox1.Text = (result + double.Parse(textBox1.Text)).ToString();
                    break;

                case "−":
                    textBox1.Text = (result - double.Parse(textBox1.Text)).ToString();
                    break;

                case "×":
                    textBox1.Text = (result * double.Parse(textBox1.Text)).ToString();
                    break;

                case "÷":
                    textBox1.Text = (result / double.Parse(textBox1.Text)).ToString();
                    break;

                case "%":
                    textBox1.Text = (result % double.Parse(textBox1.Text)).ToString();
                    break;
            }


        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            result = 0;


        }

        private void button14_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text.Length > 1)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
            else
            {
                textBox1.Text = "0";
            }
        }

    }
}




