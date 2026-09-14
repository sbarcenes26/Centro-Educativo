using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Centro_Educativo
{
    public partial class frmCursos : Form
    {
        public frmCursos()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevoCurso_Click(object sender, EventArgs e)
        {
            frmNuevoCurso ventanaModal = new frmNuevoCurso();
            ventanaModal.Text = "Nuevo Curso";
            ventanaModal.ShowDialog();

        }
    }
}
