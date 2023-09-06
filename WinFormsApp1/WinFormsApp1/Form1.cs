namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int age = Convert.ToInt32(textBox3.Text);
            int total  = 80 - age;
            textBox5.Text = $"NAME: {textBox1?.Text.ToString().ToUpper()}\t\t FAMILY: {textBox2?.Text.ToString().ToUpper()} \n AGE: {textBox3?.Text.ToString()} \t\t WITH: {textBox4?.Text.ToString()} kg\n ExpairDate: {total} year";
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}