namespace FirstApplicationWithWinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void buttonFirst_Click(object sender, EventArgs e)
        {
            string message = "witaj w programie";
            message += "ulubiony przedmiot :\n";
            if (checkBoxMathematics.Checked)
            {
                message += "* matma\n";
            }
            if (checkBoxGerman.Checked)
            {
                message += "*jezyk niemiecki \n";
            }

            message += "  :\n";

            if (radioButtonNo.Checked)
            {
                message += textBoxName.Text + "Ze mn¹ sie nie napijesz \n ";
            }
            else
            {
                message += "Piwo \n";
            }
            if (textBoxName.Text != "")
            {
                message += " Twoje imie to: " + textBoxName.Text + "\n";
            }
            

            if (comboBoxGames.SelectedIndex != -1)
            {
                if (comboBoxGames.Text == "fortnite " )
                {
                    message += "battle pass";
                }
            }
            
            MessageBox.Show(message);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}