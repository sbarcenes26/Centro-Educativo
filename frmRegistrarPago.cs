using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Centro_Educativo
{
    public partial class frmRegistrarPago : Form
    {
        public frmRegistrarPago()
        {
            InitializeComponent();
        }

        private void btnAplicarPago_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Transacción exitosa. Se ha generado el comprobante de pago electrónico.", "Colecturía", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
