namespace prySilvaGUI
{
    public partial class frmControles : Form
    {
        public frmControles()
        {
            InitializeComponent();
        }

        private void frmControles_Load(object sender, EventArgs e)
        {

        }

        private void cmdAbrir_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBotonera botonera = new frmBotonera();
            botonera.vecNombres[0] = "También soy hacker";
            botonera.Show();

            int i = 0;

            //while (i < botonera.vecNombres.Length)
            {

            } 
        }
    }
}
