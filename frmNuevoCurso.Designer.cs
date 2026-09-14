namespace Centro_Educativo
{
    partial class frmNuevoCurso
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
            label1 = new Label();
            label2 = new Label();
            txtCodigodeAsignatura = new TextBox();
            label3 = new Label();
            txtNombreDeasignatura = new TextBox();
            label5 = new Label();
            label6 = new Label();
            cmbSeccion = new ComboBox();
            nudCupo = new NumericUpDown();
            btnGuardar = new Button();
            btnCerrar = new Button();
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)nudCupo).BeginInit();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Consolas", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(82, 1);
            label1.Name = "label1";
            label1.Size = new Size(524, 50);
            label1.TabIndex = 0;
            label1.Text = "Configuración de Cursos";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(12, 66);
            label2.Name = "label2";
            label2.Size = new Size(254, 20);
            label2.TabIndex = 1;
            label2.Text = "Código de la Asignatura (Ej: MAT4)";
            // 
            // txtCodigodeAsignatura
            // 
            txtCodigodeAsignatura.Location = new Point(16, 97);
            txtCodigodeAsignatura.Name = "txtCodigodeAsignatura";
            txtCodigodeAsignatura.Size = new Size(278, 27);
            txtCodigodeAsignatura.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(18, 143);
            label3.Name = "label3";
            label3.Size = new Size(185, 20);
            label3.TabIndex = 3;
            label3.Text = "Nombre de la Asignatura";
            // 
            // txtNombreDeasignatura
            // 
            txtNombreDeasignatura.Location = new Point(18, 175);
            txtNombreDeasignatura.Name = "txtNombreDeasignatura";
            txtNombreDeasignatura.Size = new Size(276, 27);
            txtNombreDeasignatura.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(370, 66);
            label5.Name = "label5";
            label5.Size = new Size(120, 20);
            label5.TabIndex = 7;
            label5.Text = "Grado y Sección";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(370, 143);
            label6.Name = "label6";
            label6.Size = new Size(106, 20);
            label6.TabIndex = 8;
            label6.Text = "Cupo Máximo";
            // 
            // cmbSeccion
            // 
            cmbSeccion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSeccion.FormattingEnabled = true;
            cmbSeccion.Items.AddRange(new object[] { "A", "B", "C" });
            cmbSeccion.Location = new Point(370, 96);
            cmbSeccion.Name = "cmbSeccion";
            cmbSeccion.Size = new Size(268, 28);
            cmbSeccion.TabIndex = 9;
            // 
            // nudCupo
            // 
            nudCupo.Location = new Point(370, 175);
            nudCupo.Name = "nudCupo";
            nudCupo.Size = new Size(268, 27);
            nudCupo.TabIndex = 10;
            nudCupo.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // btnGuardar
            // 
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Location = new Point(470, 3);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(120, 29);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar Curso";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Location = new Point(596, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(94, 29);
            btnCerrar.TabIndex = 12;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(693, 51);
            panel1.TabIndex = 13;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ActiveCaption;
            flowLayoutPanel1.Controls.Add(btnCerrar);
            flowLayoutPanel1.Controls.Add(btnGuardar);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(0, 261);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(693, 44);
            flowLayoutPanel1.TabIndex = 15;
            // 
            // frmNuevoCurso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(693, 305);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Controls.Add(nudCupo);
            Controls.Add(cmbSeccion);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtNombreDeasignatura);
            Controls.Add(label3);
            Controls.Add(txtCodigodeAsignatura);
            Controls.Add(label2);
            Name = "frmNuevoCurso";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)nudCupo).EndInit();
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtCodigodeAsignatura;
        private Label label3;
        private TextBox txtNombreDeasignatura;
        private Label label5;
        private Label label6;
        private ComboBox cmbSeccion;
        private NumericUpDown nudCupo;
        private Button btnGuardar;
        private Button btnCerrar;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}