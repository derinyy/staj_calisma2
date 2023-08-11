namespace WinFormsApp22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int kasatutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {

            int milkshake, americano, mocha, waffle, bowl, toplam;
            milkshake = Convert.ToInt16(textBox1.Text);
            americano = Convert.ToInt16(textBox2.Text);
            mocha = Convert.ToInt16(textBox3.Text);
            waffle = Convert.ToInt16(textBox4.Text);
            bowl = Convert.ToInt16(textBox5.Text);

            toplam = milkshake * 2 + americano * 4 + mocha * 5 + waffle * 15 + bowl * 10;
            label3.Text = toplam.ToString() + "$$";
            MessageBox.Show("Payment Done!");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Lütfen sipariþ notunuzu giriniz...";
        }
    }
}