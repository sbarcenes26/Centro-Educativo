using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Centro_Educativo
{
    public partial class frmDocentes : Form
    {
        public frmDocentes()
        {
            InitializeComponent();
        }

        private void btnCerrarDocente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarDocente_Click(object sender, EventArgs e)
        {
            frmNuevoDocente ventanaModal = new frmNuevoDocente();
            ventanaModal.ShowDialog();
        }
    }
}
