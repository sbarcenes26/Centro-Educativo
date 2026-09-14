using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Centro_Educativo
{
    public partial class FrmEstudiantes : Form
    {
        public FrmEstudiantes()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarEstudiante_Click(object sender, EventArgs e)
        {
            FrmAgregarEstudiante ventanaModal = new FrmAgregarEstudiante();
            ventanaModal.ShowDialog();
        }
    }
}
