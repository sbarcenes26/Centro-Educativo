using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Centro_Educativo
{
    public partial class frmPagos : Form
    {
        public frmPagos()
        {
            InitializeComponent();
        }

        private void frmPagos_Load(object sender, EventArgs e)
        {
            dgvMensualidades.Rows.Add("Matrícula - Ciclo II", "$75.00", "20/07/2026", "PAGADO");
            dgvMensualidades.Rows.Add("Mensualidad - Agosto", "$60.00", "28/07/2026", "PAGADO");
            dgvMensualidades.Rows.Add("Mensualidad - Septiembre", "$60.00", "--", "PENDIENTE");
            dgvMensualidades.Rows.Add("Mensualidad - Octubre", "$60.00", "--", "PENDIENTE");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrarPago_Click(object sender, EventArgs e)
        {
            using (frmRegistrarPago formulario = new frmRegistrarPago())
            {
                formulario.ShowDialog(this);
            }
        }
    }

}
