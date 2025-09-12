using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySilvaGUI
{
    public partial class frmBotonera : Form
    {
        public frmBotonera()
        {
            InitializeComponent();
        }

        string[] vecNombres = new string[4];
        int i = 0;

        private void frmBotonera_Load(object sender, EventArgs e)
        {
            vecNombres[0] = "Ana";
            vecNombres[1] = "Juan";
            vecNombres[2] = "Pedro";
            vecNombres[3] = "Maria";

            lblNombre.Text = vecNombres[i];
        }

        private void cmdSiguiente_Click(object sender, EventArgs e)
        {

            i++;
            if (vecNombres.Length > i) {
                
                lblNombre.Text = vecNombres[i];
                cmdAtras.Enabled = true;
                
            }
            else
            {
                cmdSiguiente.Enabled = false;
            }
        }

        private void cmdAtras_Click(object sender, EventArgs e)
        {

            i--;
            if (vecNombres.Length < i) {
                
                lblNombre.Text = vecNombres[i];
                cmdSiguiente.Enabled = true;
                
            }
            else
            {
                cmdAtras.Enabled = false;
            }
        }
    }
}
