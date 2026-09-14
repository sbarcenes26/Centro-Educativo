namespace Centro_Educativo
{
    partial class fmrReportedeNotas
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
            panel2 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel3 = new Panel();
            btnImprimir = new Button();
            btnCerrar = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            dataGridView1 = new DataGridView();
            colMateria = new DataGridViewTextBoxColumn();
            colSeccion = new DataGridViewTextBoxColumn();
            colPrimerPeriodo = new DataGridViewTextBoxColumn();
            colSegundoPerido = new DataGridViewTextBoxColumn();
            colTercerPeriodo = new DataGridViewTextBoxColumn();
            colPromedio = new DataGridViewTextBoxColumn();
            colNotafinal = new DataGridViewTextBoxColumn();
            colAsistencia = new DataGridViewTextBoxColumn();
            colEstado = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 87);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 57);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 30);
            panel2.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(422, 7);
            label7.Name = "label7";
            label7.Size = new Size(68, 20);
            label7.TabIndex = 3;
            label7.Text = "9° Grado";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(360, 7);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 2;
            label6.Text = "Grado:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(101, 7);
            label5.Name = "label5";
            label5.Size = new Size(218, 20);
            label5.TabIndex = 1;
            label5.Text = "Francisco Roberto Torres García";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 7);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 0;
            label4.Text = "Estudiante:";
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Consolas", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(800, 87);
            label1.TabIndex = 0;
            label1.Text = "REPORTE DE NOTAS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 5);
            label2.Name = "label2";
            label2.Size = new Size(239, 28);
            label2.TabIndex = 1;
            label2.Text = "Asignatura: Matemática";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(473, 5);
            label3.Name = "label3";
            label3.Size = new Size(297, 28);
            label3.TabIndex = 2;
            label3.Text = "Docente: Ing. Giovanni Acosta";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.InactiveCaption;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(0, 54);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 46);
            panel3.TabIndex = 7;
            // 
            // btnImprimir
            // 
            btnImprimir.FlatStyle = FlatStyle.Flat;
            btnImprimir.Location = new Point(518, 3);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(179, 29);
            btnImprimir.TabIndex = 4;
            btnImprimir.Text = "Imprimir Reporte";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Location = new Point(703, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(94, 29);
            btnCerrar.TabIndex = 5;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ActiveCaption;
            flowLayoutPanel1.Controls.Add(btnCerrar);
            flowLayoutPanel1.Controls.Add(btnImprimir);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(0, 413);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(800, 37);
            flowLayoutPanel1.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(35, 87, 137);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colMateria, colSeccion, colPrimerPeriodo, colSegundoPerido, colTercerPeriodo, colPromedio, colNotafinal, colAsistencia, colEstado });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(0, 87);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(800, 326);
            dataGridView1.TabIndex = 12;
            // 
            // colMateria
            // 
            colMateria.HeaderText = "Materia";
            colMateria.MinimumWidth = 6;
            colMateria.Name = "colMateria";
            colMateria.ReadOnly = true;
            // 
            // colSeccion
            // 
            colSeccion.HeaderText = "Sección";
            colSeccion.MinimumWidth = 6;
            colSeccion.Name = "colSeccion";
            colSeccion.ReadOnly = true;
            // 
            // colPrimerPeriodo
            // 
            colPrimerPeriodo.HeaderText = "Primer Periodo";
            colPrimerPeriodo.MinimumWidth = 6;
            colPrimerPeriodo.Name = "colPrimerPeriodo";
            colPrimerPeriodo.ReadOnly = true;
            // 
            // colSegundoPerido
            // 
            colSegundoPerido.HeaderText = "Segundo Periodo";
            colSegundoPerido.MinimumWidth = 6;
            colSegundoPerido.Name = "colSegundoPerido";
            colSegundoPerido.ReadOnly = true;
            // 
            // colTercerPeriodo
            // 
            colTercerPeriodo.HeaderText = "Tercer Periodo";
            colTercerPeriodo.MinimumWidth = 6;
            colTercerPeriodo.Name = "colTercerPeriodo";
            colTercerPeriodo.ReadOnly = true;
            // 
            // colPromedio
            // 
            colPromedio.HeaderText = "Promedio";
            colPromedio.MinimumWidth = 6;
            colPromedio.Name = "colPromedio";
            colPromedio.ReadOnly = true;
            // 
            // colNotafinal
            // 
            colNotafinal.HeaderText = "Nota Final";
            colNotafinal.MinimumWidth = 6;
            colNotafinal.Name = "colNotafinal";
            colNotafinal.ReadOnly = true;
            // 
            // colAsistencia
            // 
            colAsistencia.HeaderText = "Asistencia";
            colAsistencia.MinimumWidth = 6;
            colAsistencia.Name = "colAsistencia";
            colAsistencia.ReadOnly = true;
            // 
            // colEstado
            // 
            colEstado.HeaderText = "Estado (Aprobado/Reprobado).";
            colEstado.MinimumWidth = 6;
            colEstado.Name = "colEstado";
            colEstado.ReadOnly = true;
            // 
            // fmrReportedeNotas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "fmrReportedeNotas";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel3;
        private Button btnImprimir;
        private Button btnCerrar;
        private FlowLayoutPanel flowLayoutPanel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colMateria;
        private DataGridViewTextBoxColumn colSeccion;
        private DataGridViewTextBoxColumn colPrimerPeriodo;
        private DataGridViewTextBoxColumn colSegundoPerido;
        private DataGridViewTextBoxColumn colTercerPeriodo;
        private DataGridViewTextBoxColumn colPromedio;
        private DataGridViewTextBoxColumn colNotafinal;
        private DataGridViewTextBoxColumn colAsistencia;
        private DataGridViewTextBoxColumn colEstado;
        private Panel panel2;
        private Label label5;
        private Label label4;
        private Label label7;
        private Label label6;
    }
}