namespace Centro_Educativo
{
    partial class frmCalificaciones
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label5 = new Label();
            btnCerrar = new Button();
            btnReporte = new Button();
            btnCalcularPromedio = new Button();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtPorcentaje1 = new TextBox();
            txtPorcentaje2 = new TextBox();
            txtPorcentaje3 = new TextBox();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            textBox4 = new TextBox();
            label13 = new Label();
            textBox3 = new TextBox();
            label12 = new Label();
            textBox2 = new TextBox();
            label10 = new Label();
            textBox1 = new TextBox();
            label9 = new Label();
            panel3 = new Panel();
            comboBox2 = new ComboBox();
            label11 = new Label();
            cmbPeriodo = new ComboBox();
            label8 = new Label();
            cmbSeccion = new ComboBox();
            label7 = new Label();
            cmbGrado = new ComboBox();
            label6 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            dataGridView1 = new DataGridView();
            colEva01 = new DataGridViewTextBoxColumn();
            colEva02 = new DataGridViewTextBoxColumn();
            colEva03 = new DataGridViewTextBoxColumn();
            colEva04 = new DataGridViewTextBoxColumn();
            colEva05 = new DataGridViewTextBoxColumn();
            colExamenFinal = new DataGridViewTextBoxColumn();
            colAsistencia = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1250, 58);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Consolas", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(1250, 58);
            label5.TabIndex = 0;
            label5.Text = "Centro de Calificaciones";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCerrar
            // 
            btnCerrar.AutoSize = true;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Location = new Point(628, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(94, 32);
            btnCerrar.TabIndex = 12;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnReporte
            // 
            btnReporte.AutoSize = true;
            btnReporte.FlatStyle = FlatStyle.Flat;
            btnReporte.Location = new Point(464, 3);
            btnReporte.Name = "btnReporte";
            btnReporte.Size = new Size(158, 32);
            btnReporte.TabIndex = 11;
            btnReporte.Text = "Reporte de Notas";
            btnReporte.UseVisualStyleBackColor = true;
            btnReporte.Click += btnReporte_Click;
            // 
            // btnCalcularPromedio
            // 
            btnCalcularPromedio.AutoSize = true;
            btnCalcularPromedio.Dock = DockStyle.Bottom;
            btnCalcularPromedio.FlatStyle = FlatStyle.Flat;
            btnCalcularPromedio.Location = new Point(315, 3);
            btnCalcularPromedio.Name = "btnCalcularPromedio";
            btnCalcularPromedio.Size = new Size(143, 32);
            btnCalcularPromedio.TabIndex = 10;
            btnCalcularPromedio.Text = "Calcular Promedio";
            btnCalcularPromedio.UseVisualStyleBackColor = true;
            btnCalcularPromedio.Click += btnCalcularPromedio_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(12, 108);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 2;
            label1.Text = "Asignatura";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Sociales", "Matemática", "Lenguaje" });
            comboBox1.Location = new Point(12, 131);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(204, 28);
            comboBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(16, 51);
            label2.Name = "label2";
            label2.Size = new Size(146, 20);
            label2.TabIndex = 4;
            label2.Text = "Ponderación Eva.01";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(16, 336);
            label3.Name = "label3";
            label3.Size = new Size(192, 20);
            label3.TabIndex = 5;
            label3.Text = "Ponderación Examen Final";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(16, 395);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 6;
            label4.Text = "Asistencia";
            // 
            // txtPorcentaje1
            // 
            txtPorcentaje1.Location = new Point(16, 75);
            txtPorcentaje1.Name = "txtPorcentaje1";
            txtPorcentaje1.Size = new Size(125, 27);
            txtPorcentaje1.TabIndex = 7;
            txtPorcentaje1.Text = "35%";
            // 
            // txtPorcentaje2
            // 
            txtPorcentaje2.Location = new Point(16, 359);
            txtPorcentaje2.Name = "txtPorcentaje2";
            txtPorcentaje2.Size = new Size(125, 27);
            txtPorcentaje2.TabIndex = 8;
            txtPorcentaje2.Text = "35%";
            // 
            // txtPorcentaje3
            // 
            txtPorcentaje3.Location = new Point(16, 429);
            txtPorcentaje3.Name = "txtPorcentaje3";
            txtPorcentaje3.Size = new Size(125, 27);
            txtPorcentaje3.TabIndex = 9;
            txtPorcentaje3.Text = "30%";
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 58);
            panel2.Name = "panel2";
            panel2.Size = new Size(525, 575);
            panel2.TabIndex = 10;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtPorcentaje3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtPorcentaje2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtPorcentaje1);
            groupBox1.Controls.Add(label2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(264, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(261, 575);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Configuración de Ponderaciones";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(16, 301);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 17;
            textBox4.Text = "35%";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label13.Location = new Point(16, 277);
            label13.Name = "label13";
            label13.Size = new Size(146, 20);
            label13.TabIndex = 16;
            label13.Text = "Ponderación Eva.05";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(16, 245);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 15;
            textBox3.Text = "35%";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label12.Location = new Point(16, 221);
            label12.Name = "label12";
            label12.Size = new Size(146, 20);
            label12.TabIndex = 14;
            label12.Text = "Ponderación Eva.04";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(16, 187);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 13;
            textBox2.Text = "35%";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label10.Location = new Point(16, 163);
            label10.Name = "label10";
            label10.Size = new Size(146, 20);
            label10.TabIndex = 12;
            label10.Text = "Ponderación Eva.03";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(16, 134);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 11;
            textBox1.Text = "35%";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(16, 110);
            label9.Name = "label9";
            label9.Size = new Size(146, 20);
            label9.TabIndex = 10;
            label9.Text = "Ponderación Eva.02";
            // 
            // panel3
            // 
            panel3.Controls.Add(comboBox2);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(cmbPeriodo);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(cmbSeccion);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(cmbGrado);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(comboBox1);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(264, 575);
            panel3.TabIndex = 10;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(12, 77);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(204, 28);
            comboBox2.TabIndex = 11;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label11.Location = new Point(12, 54);
            label11.Name = "label11";
            label11.Size = new Size(83, 20);
            label11.TabIndex = 10;
            label11.Text = "Estudiante";
            // 
            // cmbPeriodo
            // 
            cmbPeriodo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPeriodo.FormattingEnabled = true;
            cmbPeriodo.Location = new Point(12, 314);
            cmbPeriodo.Name = "cmbPeriodo";
            cmbPeriodo.Size = new Size(204, 28);
            cmbPeriodo.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(12, 291);
            label8.Name = "label8";
            label8.Size = new Size(63, 20);
            label8.TabIndex = 8;
            label8.Text = "Período";
            // 
            // cmbSeccion
            // 
            cmbSeccion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSeccion.FormattingEnabled = true;
            cmbSeccion.Location = new Point(12, 254);
            cmbSeccion.Name = "cmbSeccion";
            cmbSeccion.Size = new Size(204, 28);
            cmbSeccion.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(12, 231);
            label7.Name = "label7";
            label7.Size = new Size(61, 20);
            label7.TabIndex = 6;
            label7.Text = "Sección";
            // 
            // cmbGrado
            // 
            cmbGrado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGrado.FormattingEnabled = true;
            cmbGrado.Location = new Point(12, 191);
            cmbGrado.Name = "cmbGrado";
            cmbGrado.Size = new Size(204, 28);
            cmbGrado.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(12, 168);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 4;
            label6.Text = "Grado";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ActiveCaption;
            flowLayoutPanel1.Controls.Add(btnCerrar);
            flowLayoutPanel1.Controls.Add(btnReporte);
            flowLayoutPanel1.Controls.Add(btnCalcularPromedio);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(525, 588);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(725, 45);
            flowLayoutPanel1.TabIndex = 12;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(35, 87, 137);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colEva01, colEva02, colEva03, colEva04, colEva05, colExamenFinal, colAsistencia });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(525, 58);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(725, 530);
            dataGridView1.TabIndex = 13;
            // 
            // colEva01
            // 
            colEva01.HeaderText = "Eva.01";
            colEva01.MinimumWidth = 6;
            colEva01.Name = "colEva01";
            colEva01.ReadOnly = true;
            // 
            // colEva02
            // 
            colEva02.HeaderText = "Eva.02";
            colEva02.MinimumWidth = 6;
            colEva02.Name = "colEva02";
            colEva02.ReadOnly = true;
            // 
            // colEva03
            // 
            colEva03.HeaderText = "Eva.03";
            colEva03.MinimumWidth = 6;
            colEva03.Name = "colEva03";
            colEva03.ReadOnly = true;
            // 
            // colEva04
            // 
            colEva04.HeaderText = "Eva04";
            colEva04.MinimumWidth = 6;
            colEva04.Name = "colEva04";
            colEva04.ReadOnly = true;
            // 
            // colEva05
            // 
            colEva05.HeaderText = "Eva.05";
            colEva05.MinimumWidth = 6;
            colEva05.Name = "colEva05";
            colEva05.ReadOnly = true;
            // 
            // colExamenFinal
            // 
            colExamenFinal.HeaderText = "Examen Final";
            colExamenFinal.MinimumWidth = 6;
            colExamenFinal.Name = "colExamenFinal";
            colExamenFinal.ReadOnly = true;
            // 
            // colAsistencia
            // 
            colAsistencia.HeaderText = "Asistencia";
            colAsistencia.MinimumWidth = 6;
            colAsistencia.Name = "colAsistencia";
            colAsistencia.ReadOnly = true;
            // 
            // frmCalificaciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1250, 633);
            Controls.Add(dataGridView1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCalificaciones";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtPorcentaje1;
        private TextBox txtPorcentaje2;
        private TextBox txtPorcentaje3;
        private Panel panel2;
        private Button btnCerrar;
        private Button btnReporte;
        private Button btnCalcularPromedio;
        private Label label5;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel3;
        private GroupBox groupBox1;
        private ComboBox cmbPeriodo;
        private Label label8;
        private ComboBox cmbSeccion;
        private Label label7;
        private ComboBox cmbGrado;
        private Label label6;
        private TextBox textBox2;
        private Label label10;
        private TextBox textBox1;
        private Label label9;
        private ComboBox comboBox2;
        private Label label11;
        private TextBox textBox3;
        private Label label12;
        private TextBox textBox4;
        private Label label13;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colEva01;
        private DataGridViewTextBoxColumn colEva02;
        private DataGridViewTextBoxColumn colEva03;
        private DataGridViewTextBoxColumn colEva04;
        private DataGridViewTextBoxColumn colEva05;
        private DataGridViewTextBoxColumn colExamenFinal;
        private DataGridViewTextBoxColumn colAsistencia;
    }
}