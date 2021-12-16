namespace tempCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //input
            //§Õ¡‡¡Èπ
            //get input form textbox
            //show input to textbox
            //convert to f 
            // f = c* 9/5 + 32
            string Input = textBoxC.Text;
            double c = Convert.ToDouble(Input);
            double f = c * 9 / 5 + 32;
            textBoxF.Text = f.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Input = textBoxF.Text;
            double f = Convert.ToDouble(Input);
            double c = (f - 32) * 5 / 9;
            textBoxC.Text = c.ToString();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBoxC.Text = " ";
            textBoxF.Text = " ";
        }
    }
}