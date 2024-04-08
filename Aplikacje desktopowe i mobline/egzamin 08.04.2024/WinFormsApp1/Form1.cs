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

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void labelEmail_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonOnly_Click(object sender, EventArgs e)
        {
            labelShowInfo.Text = "";
            bool evryThingIsGood = true;
            string textForChcek = textBoxMail.Text;
            bool containsOne = textForChcek.Contains("@");
            //sprawdzenie 
            if (containsOne)
            {

            }
            else
            {
                labelShowInfo.Text += "Nie prawidlowy adres mail";
                evryThingIsGood = false;
            }
            if (textBoxPass1.Text == textBoxPass2.Text)
            {

            }
            else
            {
                labelShowInfo.Text += "Hasla s¹ rozne";
                evryThingIsGood = false;
            }
            if (evryThingIsGood==true)
            {
                labelShowInfo.Text = "Witaj "+ textBoxMail.Text;
            }
        }
    }
}