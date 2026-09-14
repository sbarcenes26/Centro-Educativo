namespace Centro_Educativo
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void AbrirFormularioHijo(Form formulario)
        {
            foreach (Form formularioAbierto in this.MdiChildren)
            {
                if (formularioAbierto.GetType() == formulario.GetType())
                {
                    formularioAbierto.Activate();
                    formulario.Dispose();
                    return;
                }
            }

            foreach (Form formularioAbierto in this.MdiChildren)
            {
                formularioAbierto.Close();
            }

            formulario.MdiParent = this;

            formulario.Dock = DockStyle.Fill;

            formulario.Show();
        }


        private void tsmiSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiEstudiantes_Click(object sender, EventArgs e)

        {
            AbrirFormularioHijo(new FrmEstudiantes());
        }

        private void tsmiDocentes_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new frmDocentes());
        }

        private void tsmiCursos_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new frmCursos());
        }

        private void tsmiMatriculas_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new frmMatriculas());
        }

        private void tsmiCalificaciones_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new frmCalificaciones());
        }

        private void tsmiPagos_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new frmPagos());
        }

        private void tsbEstudiantes_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmEstudiantes());
        }

        private void tsbPagos_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new frmPagos());
        }

        private void tsbDocentes_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new frmDocentes());
        }

        private void tsbCursos_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new frmCursos());
        }

        private void tsbMatriculas_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new frmMatriculas());
        }

        private void tsbCalificaciones_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new frmCalificaciones());
        }

        private void tsbInicio_Click(object sender, EventArgs e)
        {
            foreach (Form formulario in this.MdiChildren)
            {
                formulario.Close();
            }
        }
    }
}

