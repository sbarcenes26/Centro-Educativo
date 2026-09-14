namespace Centro_Educativo
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            mnuMenuPrincipal1 = new MenuStrip();
            tsmiAdministración = new ToolStripMenuItem();
            tsmiEstudiantes = new ToolStripMenuItem();
            tsmiDocentes = new ToolStripMenuItem();
            tsmiCursos = new ToolStripMenuItem();
            tsmiProcesos = new ToolStripMenuItem();
            tsmiMatriculas = new ToolStripMenuItem();
            tsmiCalificaciones = new ToolStripMenuItem();
            tsmiPagos = new ToolStripMenuItem();
            tsmiSalir = new ToolStripMenuItem();
            sslUsuario = new ToolStripStatusLabel();
            sstMenuInferior2 = new StatusStrip();
            tspMenuPrincipal = new ToolStrip();
            tsbInicio = new ToolStripButton();
            tsbEstudiantes = new ToolStripButton();
            tsbDocentes = new ToolStripButton();
            tsbCursos = new ToolStripButton();
            tsbMatriculas = new ToolStripButton();
            tsbCalificaciones = new ToolStripButton();
            tsbPago = new ToolStripButton();
            mnuMenuPrincipal1.SuspendLayout();
            sstMenuInferior2.SuspendLayout();
            tspMenuPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // mnuMenuPrincipal1
            // 
            mnuMenuPrincipal1.AutoSize = false;
            mnuMenuPrincipal1.BackColor = SystemColors.ActiveCaption;
            mnuMenuPrincipal1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mnuMenuPrincipal1.ImageScalingSize = new Size(20, 20);
            mnuMenuPrincipal1.Items.AddRange(new ToolStripItem[] { tsmiAdministración, tsmiProcesos, tsmiSalir });
            mnuMenuPrincipal1.Location = new Point(0, 0);
            mnuMenuPrincipal1.Name = "mnuMenuPrincipal1";
            mnuMenuPrincipal1.Padding = new Padding(7, 2, 0, 2);
            mnuMenuPrincipal1.RenderMode = ToolStripRenderMode.Professional;
            mnuMenuPrincipal1.Size = new Size(1182, 40);
            mnuMenuPrincipal1.TabIndex = 1;
            mnuMenuPrincipal1.Text = "menuStrip1";
            // 
            // tsmiAdministración
            // 
            tsmiAdministración.DropDownItems.AddRange(new ToolStripItem[] { tsmiEstudiantes, tsmiDocentes, tsmiCursos });
            tsmiAdministración.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            tsmiAdministración.Image = Properties.Resources.documentation_12650278;
            tsmiAdministración.Name = "tsmiAdministración";
            tsmiAdministración.Size = new Size(166, 36);
            tsmiAdministración.Text = "Administración";
            // 
            // tsmiEstudiantes
            // 
            tsmiEstudiantes.Name = "tsmiEstudiantes";
            tsmiEstudiantes.Size = new Size(185, 28);
            tsmiEstudiantes.Text = "Estudiantes";
            tsmiEstudiantes.Click += tsmiEstudiantes_Click;
            // 
            // tsmiDocentes
            // 
            tsmiDocentes.Name = "tsmiDocentes";
            tsmiDocentes.Size = new Size(185, 28);
            tsmiDocentes.Text = "Docentes";
            tsmiDocentes.Click += tsmiDocentes_Click;
            // 
            // tsmiCursos
            // 
            tsmiCursos.Name = "tsmiCursos";
            tsmiCursos.Size = new Size(185, 28);
            tsmiCursos.Text = "Cursos";
            tsmiCursos.Click += tsmiCursos_Click;
            // 
            // tsmiProcesos
            // 
            tsmiProcesos.DropDownItems.AddRange(new ToolStripItem[] { tsmiMatriculas, tsmiCalificaciones, tsmiPagos });
            tsmiProcesos.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            tsmiProcesos.Image = Properties.Resources.books_17359828;
            tsmiProcesos.Name = "tsmiProcesos";
            tsmiProcesos.Size = new Size(112, 36);
            tsmiProcesos.Text = "Procesos";
            // 
            // tsmiMatriculas
            // 
            tsmiMatriculas.Name = "tsmiMatriculas";
            tsmiMatriculas.Size = new Size(202, 28);
            tsmiMatriculas.Text = "Matriculas";
            tsmiMatriculas.Click += tsmiMatriculas_Click;
            // 
            // tsmiCalificaciones
            // 
            tsmiCalificaciones.Name = "tsmiCalificaciones";
            tsmiCalificaciones.Size = new Size(202, 28);
            tsmiCalificaciones.Text = "Calificaciones";
            tsmiCalificaciones.Click += tsmiCalificaciones_Click;
            // 
            // tsmiPagos
            // 
            tsmiPagos.Name = "tsmiPagos";
            tsmiPagos.Size = new Size(202, 28);
            tsmiPagos.Text = "Pagos";
            tsmiPagos.Click += tsmiPagos_Click;
            // 
            // tsmiSalir
            // 
            tsmiSalir.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            tsmiSalir.Name = "tsmiSalir";
            tsmiSalir.Size = new Size(60, 36);
            tsmiSalir.Text = "Salir";
            tsmiSalir.Click += tsmiSalir_Click;
            // 
            // sslUsuario
            // 
            sslUsuario.Name = "sslUsuario";
            sslUsuario.Size = new Size(161, 37);
            sslUsuario.Text = "Usuario: Administrador";
            // 
            // sstMenuInferior2
            // 
            sstMenuInferior2.AutoSize = false;
            sstMenuInferior2.BackColor = SystemColors.ActiveCaption;
            sstMenuInferior2.ImageScalingSize = new Size(20, 20);
            sstMenuInferior2.Items.AddRange(new ToolStripItem[] { sslUsuario });
            sstMenuInferior2.Location = new Point(0, 621);
            sstMenuInferior2.Name = "sstMenuInferior2";
            sstMenuInferior2.Padding = new Padding(1, 0, 16, 0);
            sstMenuInferior2.Size = new Size(1182, 43);
            sstMenuInferior2.TabIndex = 2;
            sstMenuInferior2.Text = "statusStrip1";
            // 
            // tspMenuPrincipal
            // 
            tspMenuPrincipal.ImageScalingSize = new Size(40, 40);
            tspMenuPrincipal.Items.AddRange(new ToolStripItem[] { tsbInicio, tsbEstudiantes, tsbDocentes, tsbCursos, tsbMatriculas, tsbCalificaciones, tsbPago });
            tspMenuPrincipal.Location = new Point(0, 40);
            tspMenuPrincipal.Name = "tspMenuPrincipal";
            tspMenuPrincipal.Size = new Size(1182, 103);
            tspMenuPrincipal.TabIndex = 4;
            tspMenuPrincipal.Text = "toolStrip1";
            // 
            // tsbInicio
            // 
            tsbInicio.AutoSize = false;
            tsbInicio.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbInicio.Image = (Image)resources.GetObject("tsbInicio.Image");
            tsbInicio.ImageTransparentColor = Color.Magenta;
            tsbInicio.Name = "tsbInicio";
            tsbInicio.Size = new Size(100, 100);
            tsbInicio.Text = "Texto de ayuda a mostrar Inicio";
            tsbInicio.Click += tsbInicio_Click;
            // 
            // tsbEstudiantes
            // 
            tsbEstudiantes.AutoSize = false;
            tsbEstudiantes.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbEstudiantes.Image = Properties.Resources.graduado;
            tsbEstudiantes.ImageTransparentColor = Color.Magenta;
            tsbEstudiantes.Name = "tsbEstudiantes";
            tsbEstudiantes.Size = new Size(100, 100);
            tsbEstudiantes.Text = "Texto de ayuda a mostrar estudiantes";
            tsbEstudiantes.Click += tsbEstudiantes_Click;
            // 
            // tsbDocentes
            // 
            tsbDocentes.AutoSize = false;
            tsbDocentes.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbDocentes.Image = Properties.Resources.profesor;
            tsbDocentes.ImageTransparentColor = Color.Magenta;
            tsbDocentes.Name = "tsbDocentes";
            tsbDocentes.Size = new Size(100, 100);
            tsbDocentes.Text = "Texto de ayuda a mostrar profesores";
            tsbDocentes.Click += tsbDocentes_Click;
            // 
            // tsbCursos
            // 
            tsbCursos.AutoSize = false;
            tsbCursos.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbCursos.Image = Properties.Resources.libro;
            tsbCursos.ImageTransparentColor = Color.Magenta;
            tsbCursos.Name = "tsbCursos";
            tsbCursos.Size = new Size(100, 100);
            tsbCursos.Text = "Texto de ayuda a mostrar Cursos";
            tsbCursos.Click += tsbCursos_Click;
            // 
            // tsbMatriculas
            // 
            tsbMatriculas.AutoSize = false;
            tsbMatriculas.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbMatriculas.Image = Properties.Resources.matricula;
            tsbMatriculas.ImageTransparentColor = Color.Magenta;
            tsbMatriculas.Name = "tsbMatriculas";
            tsbMatriculas.Size = new Size(100, 100);
            tsbMatriculas.Text = "Texto de ayuda a mostrar Matriculas";
            tsbMatriculas.Click += tsbMatriculas_Click;
            // 
            // tsbCalificaciones
            // 
            tsbCalificaciones.AutoSize = false;
            tsbCalificaciones.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbCalificaciones.Image = Properties.Resources.documentation_12650278;
            tsbCalificaciones.ImageTransparentColor = Color.Magenta;
            tsbCalificaciones.Name = "tsbCalificaciones";
            tsbCalificaciones.Size = new Size(100, 100);
            tsbCalificaciones.Text = "Texto de ayuda a mostrar Calificaciones";
            tsbCalificaciones.Click += tsbCalificaciones_Click;
            // 
            // tsbPago
            // 
            tsbPago.AutoSize = false;
            tsbPago.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbPago.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tsbPago.Image = Properties.Resources.matricula__2_;
            tsbPago.ImageTransparentColor = Color.Magenta;
            tsbPago.Name = "tsbPago";
            tsbPago.Size = new Size(100, 100);
            tsbPago.Text = "Texto de ayuda a mostrar pagos";
            tsbPago.Click += tsbPagos_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1182, 664);
            Controls.Add(tspMenuPrincipal);
            Controls.Add(sstMenuInferior2);
            Controls.Add(mnuMenuPrincipal1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IsMdiContainer = true;
            MainMenuStrip = mnuMenuPrincipal1;
            MinimumSize = new Size(1200, 700);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Administracion de Centros Educativos";
            WindowState = FormWindowState.Maximized;
            mnuMenuPrincipal1.ResumeLayout(false);
            mnuMenuPrincipal1.PerformLayout();
            sstMenuInferior2.ResumeLayout(false);
            sstMenuInferior2.PerformLayout();
            tspMenuPrincipal.ResumeLayout(false);
            tspMenuPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnuMenuPrincipal1;
        private ToolStripMenuItem tsmiAdministración;
        private ToolStripMenuItem tsmiEstudiantes;
        private ToolStripMenuItem tsmiDocentes;
        private ToolStripMenuItem tsmiCursos;
        private ToolStripMenuItem tsmiProcesos;
        private ToolStripMenuItem tsmiMatriculas;
        private ToolStripMenuItem tsmiCalificaciones;
        private ToolStripMenuItem tsmiPagos;
        private ToolStripStatusLabel sslUsuario;
        private StatusStrip sstMenuInferior2;
        private ToolStripMenuItem tsmiSalir;
        private ToolStrip tspMenuPrincipal;
        private ToolStripButton tsbEstudiantes;
        private ToolStripButton tsbDocentes;
        private ToolStripButton tsbCursos;
        private ToolStripButton tsbMatriculas;
        private ToolStripButton tsbCalificaciones;
        private ToolStripButton tsbPago;
        private ToolStripButton tsbInicio;
    }
}
