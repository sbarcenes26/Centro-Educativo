using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Centro_Educativo
{
    public partial class frmMatriculas : Form
    {
        public frmMatriculas()
        {
            InitializeComponent();
        }

        private void btnRegistrarMatricula_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Matrícula procesada con éxito!", "Sistema Académico", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }
    }
}
