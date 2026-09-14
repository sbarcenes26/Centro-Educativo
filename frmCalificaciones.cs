using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Centro_Educativo
{
    public partial class frmCalificaciones : Form
    {
        public frmCalificaciones()
        {
            InitializeComponent();
        }

        private void btnCalcularPromedio_Click(object sender, EventArgs e)
        {

            string p1 = txtPorcentaje1.Text;
            string p2 = txtPorcentaje2.Text;
            string p3 = txtPorcentaje3.Text;
            MessageBox.Show($"Promedios calculados exitosamente", "Sistema Académico", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            fmrReportedeNotas frm = new fmrReportedeNotas();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
