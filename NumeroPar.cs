namespace WinFormsApp1
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

        private void button1_Click(object sender, EventArgs e)
        {
           int numero1 = Int32.Parse(textBox1.Text);
           
            if (numero1 % 2 == 0)
            {
                MessageBox.Show("El número es par");
            }
            else
            {
                MessageBox.Show("El número es impar");
            }

        }
    }
}