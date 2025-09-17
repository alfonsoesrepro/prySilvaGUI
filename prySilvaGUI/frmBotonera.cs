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
        public string[] vecNombres = new string[4];
        int i = 0;
        
        public frmBotonera()
        {
            InitializeComponent();
        }

        private void frmBotonera_Load(object sender, EventArgs e)
        {
            //vecNombres[0] = "Ana";
            vecNombres[1] = "Juan";
            vecNombres[2] = "Pedro";
            vecNombres[3] = "Maria";

            lblNombre.Text = vecNombres[i];
        }

        private void cmdSiguiente_Click(object sender, EventArgs e)
        {
            i++;
            if (vecNombres.Length > i)
            {

                lblNombre.Text = vecNombres[i];

                if (i > 0)
                {
                    cmdAtras.Enabled = true;
                }

                if ((i + 1) == vecNombres.Length)
                {
                    cmdSiguiente.Enabled = false;
                }
            }

        }

        private void cmdAtras_Click(object sender, EventArgs e)
        {
            i--;
            if (vecNombres.Length > i)
            {

                lblNombre.Text = vecNombres[i];

                if (i == 0)
                {
                    cmdAtras.Enabled = false;
                }

                if (i > 0)
                {
                    cmdSiguiente.Enabled = true;
                }

            }

        }

        private void cmdUltimo_Click(object sender, EventArgs e)
        {
           
            lblNombre.Text = vecNombres[3];
            
        }

        private void cmdPrimero_Click(object sender, EventArgs e)
        {
            
            lblNombre.Text = vecNombres[0];
           
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }
    }
}
