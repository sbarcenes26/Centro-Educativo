namespace Centro_Educativo
{
    partial class frmCursos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnNuevoCurso = new Button();
            btnBuscar = new Button();
            txtBuscarCurso = new TextBox();
            label1 = new Label();
            Cerrar = new Button();
            btnEditarCurso = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            dgvCursos = new DataGridView();
            clmCodigodeCurso = new DataGridViewTextBoxColumn();
            clmNombreMateria = new DataGridViewTextBoxColumn();
            clmGrado = new DataGridViewTextBoxColumn();
            colCupo = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCursos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnNuevoCurso);
            panel1.Controls.Add(btnBuscar);
            panel1.Controls.Add(txtBuscarCurso);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(868, 51);
            panel1.TabIndex = 0;
            // 
            // btnNuevoCurso
            // 
            btnNuevoCurso.Location = new Point(670, 12);
            btnNuevoCurso.Name = "btnNuevoCurso";
            btnNuevoCurso.Size = new Size(156, 29);
            btnNuevoCurso.TabIndex = 3;
            btnNuevoCurso.Text = "Agregar Curso";
            btnNuevoCurso.UseVisualStyleBackColor = true;
            btnNuevoCurso.Click += btnNuevoCurso_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(570, 12);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBuscarCurso
            // 
            txtBuscarCurso.Location = new Point(175, 14);
            txtBuscarCurso.Name = "txtBuscarCurso";
            txtBuscarCurso.Size = new Size(389, 27);
            txtBuscarCurso.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 16);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 0;
            label1.Text = "Buscar Curso:";
            // 
            // Cerrar
            // 
            Cerrar.FlatStyle = FlatStyle.Flat;
            Cerrar.Location = new Point(622, 3);
            Cerrar.Name = "Cerrar";
            Cerrar.Size = new Size(94, 29);
            Cerrar.TabIndex = 1;
            Cerrar.Text = "Cerrar";
            Cerrar.UseVisualStyleBackColor = true;
            Cerrar.Click += button2_Click;
            // 
            // btnEditarCurso
            // 
            btnEditarCurso.FlatStyle = FlatStyle.Flat;
            btnEditarCurso.Location = new Point(722, 3);
            btnEditarCurso.Name = "btnEditarCurso";
            btnEditarCurso.Size = new Size(143, 29);
            btnEditarCurso.TabIndex = 0;
            btnEditarCurso.Text = "Editar Curso";
            btnEditarCurso.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ActiveCaption;
            flowLayoutPanel1.Controls.Add(btnEditarCurso);
            flowLayoutPanel1.Controls.Add(Cerrar);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(0, 420);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(868, 44);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // dgvCursos
            // 
            dgvCursos.AllowUserToAddRows = false;
            dgvCursos.AllowUserToDeleteRows = false;
            dgvCursos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCursos.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(35, 87, 137);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCursos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCursos.Columns.AddRange(new DataGridViewColumn[] { clmCodigodeCurso, clmNombreMateria, clmGrado, colCupo });
            dgvCursos.Dock = DockStyle.Fill;
            dgvCursos.EnableHeadersVisualStyles = false;
            dgvCursos.Location = new Point(0, 51);
            dgvCursos.Name = "dgvCursos";
            dgvCursos.ReadOnly = true;
            dgvCursos.RowHeadersWidth = 51;
            dgvCursos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCursos.Size = new Size(868, 369);
            dgvCursos.TabIndex = 4;
            // 
            // clmCodigodeCurso
            // 
            clmCodigodeCurso.HeaderText = "Código de la Asignatura ";
            clmCodigodeCurso.MinimumWidth = 6;
            clmCodigodeCurso.Name = "clmCodigodeCurso";
            clmCodigodeCurso.ReadOnly = true;
            // 
            // clmNombreMateria
            // 
            clmNombreMateria.HeaderText = "Nombre de la Asignatura";
            clmNombreMateria.MinimumWidth = 6;
            clmNombreMateria.Name = "clmNombreMateria";
            clmNombreMateria.ReadOnly = true;
            // 
            // clmGrado
            // 
            clmGrado.HeaderText = "Grado y Sección";
            clmGrado.MinimumWidth = 6;
            clmGrado.Name = "clmGrado";
            clmGrado.ReadOnly = true;
            // 
            // colCupo
            // 
            colCupo.HeaderText = "Cupo Máximo";
            colCupo.MinimumWidth = 6;
            colCupo.Name = "colCupo";
            colCupo.ReadOnly = true;
            // 
            // frmCursos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(868, 464);
            Controls.Add(dgvCursos);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCursos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCursos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnNuevoCurso;
        private Button btnBuscar;
        private TextBox txtBuscarCurso;
        private Button Cerrar;
        private Button btnEditarCurso;
        private FlowLayoutPanel flowLayoutPanel1;
        private DataGridView dgvCursos;
        private DataGridViewTextBoxColumn clmCodigodeCurso;
        private DataGridViewTextBoxColumn clmNombreMateria;
        private DataGridViewTextBoxColumn clmGrado;
        private DataGridViewTextBoxColumn colCupo;
    }
}