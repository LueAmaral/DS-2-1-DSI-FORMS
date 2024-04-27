namespace Questionario
{
    public partial class Questionario : Form

    {

        int acertos = 0;

        public Questionario()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void A1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void enviar_Click(object sender, EventArgs e)
        {


            if (C1.Checked)
            {
                ++acertos;
            }


            if (A2.Checked)
            {
                ++acertos;
            }


            if (A3.Checked)
            {
                ++acertos;
            }


            if (A4.Checked)
            {
                ++acertos;

            }
            if (D5.Checked)
            {
                ++acertos;
            }


            if (D6.Checked)
            {
                ++acertos;
            }


            if (B7.Checked)
            {
                ++acertos;
            }


            if (B8.Checked)
            {
                ++acertos;
            }


            if (A9.Checked)
            {
                ++acertos;
            }


            if (C10.Checked)
            {
                ++acertos;
            }


            MessageBox.Show("Número de respostas corretas: " + acertos, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            acertos = 0;
        }
    }
}