namespace Memory_Memes
{
    public partial class Form1 : Form
    {
        int movimentos, cliques, casrtasEncontradas;
        
        public Form1()
        {
            InitializeComponent();
            inicio();
        }

        private void inicio()
        {
            foreach (PictureBox item in Controls.OfType<PictureBox>())
            {
                item.Image = Properties.Resources.Fundo;
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}