namespace Centro_Educativo
{
    partial class frmMatriculas
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
            panel1 = new Panel();
            label1 = new Label();
            btnCerrar = new Button();
            btnRegistrarMatricula = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            grpEstudiante = new GroupBox();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel5 = new Panel();
            txtBuscarEstudiante = new TextBox();
            panel4 = new Panel();
            btnBuscar = new Button();
            cmbFiltroEstudiantes = new ComboBox();
            label2 = new Label();
            grpMatricula = new GroupBox();
            label23 = new Label();
            cmbTurno = new ComboBox();
            label22 = new Label();
            cmbSección = new ComboBox();
            label3 = new Label();
            dtpFechaInscripcion = new DateTimePicker();
            label4 = new Label();
            cmbGradoMatricular = new ComboBox();
            grpPago = new GroupBox();
            cmbConceptoPago = new ComboBox();
            chbConfirmarPago = new CheckBox();
            txtMontoTotal = new TextBox();
            label25 = new Label();
            label24 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            grpEstudiante.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            grpMatricula.SuspendLayout();
            grpPago.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1224, 49);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Consolas", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1224, 49);
            label1.TabIndex = 0;
            label1.Text = "Control de Matrículas";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCerrar
            // 
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Location = new Point(1127, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(94, 29);
            btnCerrar.TabIndex = 9;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarMatricula
            // 
            btnRegistrarMatricula.FlatStyle = FlatStyle.Flat;
            btnRegistrarMatricula.Location = new Point(860, 3);
            btnRegistrarMatricula.Name = "btnRegistrarMatricula";
            btnRegistrarMatricula.Size = new Size(261, 29);
            btnRegistrarMatricula.TabIndex = 8;
            btnRegistrarMatricula.Text = "Confirmar Matrícula ";
            btnRegistrarMatricula.UseVisualStyleBackColor = true;
            btnRegistrarMatricula.Click += btnRegistrarMatricula_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ActiveCaption;
            flowLayoutPanel1.Controls.Add(btnCerrar);
            flowLayoutPanel1.Controls.Add(btnRegistrarMatricula);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(0, 592);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1224, 39);
            flowLayoutPanel1.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(grpEstudiante, 0, 0);
            tableLayoutPanel1.Controls.Add(grpMatricula, 1, 0);
            tableLayoutPanel1.Controls.Add(grpPago, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 49);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 190F));
            tableLayoutPanel1.Size = new Size(1224, 543);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // grpEstudiante
            // 
            grpEstudiante.Controls.Add(label21);
            grpEstudiante.Controls.Add(label20);
            grpEstudiante.Controls.Add(label19);
            grpEstudiante.Controls.Add(label18);
            grpEstudiante.Controls.Add(label17);
            grpEstudiante.Controls.Add(label16);
            grpEstudiante.Controls.Add(label15);
            grpEstudiante.Controls.Add(label14);
            grpEstudiante.Controls.Add(label13);
            grpEstudiante.Controls.Add(label12);
            grpEstudiante.Controls.Add(label11);
            grpEstudiante.Controls.Add(label10);
            grpEstudiante.Controls.Add(label9);
            grpEstudiante.Controls.Add(label8);
            grpEstudiante.Controls.Add(label7);
            grpEstudiante.Controls.Add(label6);
            grpEstudiante.Controls.Add(label5);
            grpEstudiante.Controls.Add(panel2);
            grpEstudiante.Dock = DockStyle.Fill;
            grpEstudiante.Location = new Point(3, 3);
            grpEstudiante.Name = "grpEstudiante";
            grpEstudiante.Size = new Size(401, 537);
            grpEstudiante.TabIndex = 0;
            grpEstudiante.TabStop = false;
            grpEstudiante.Text = "Detalles del Estudiante:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(9, 465);
            label21.Name = "label21";
            label21.Size = new Size(51, 20);
            label21.TabIndex = 35;
            label21.Text = "Activo";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(9, 389);
            label20.Name = "label20";
            label20.Size = new Size(79, 20);
            label20.TabIndex = 34;
            label20.Text = "2345-2367";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(9, 425);
            label19.Name = "label19";
            label19.Size = new Size(235, 20);
            label19.TabIndex = 33;
            label19.Text = "roberto.6@centroeducativo.edu.sv";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(9, 189);
            label18.Name = "label18";
            label18.Size = new Size(94, 20);
            label18.TabIndex = 32;
            label18.Text = "2036-TG-603";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(9, 229);
            label17.Name = "label17";
            label17.Size = new Size(128, 20);
            label17.TabIndex = 31;
            label17.Text = "Francisco Roberto";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(9, 269);
            label16.Name = "label16";
            label16.Size = new Size(95, 20);
            label16.TabIndex = 30;
            label16.Text = "Torres García";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(9, 309);
            label15.Name = "label15";
            label15.Size = new Size(68, 20);
            label15.TabIndex = 29;
            label15.Text = "9° Grado";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(9, 349);
            label14.Name = "label14";
            label14.Size = new Size(20, 20);
            label14.TabIndex = 28;
            label14.Text = "N";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(9, 445);
            label13.Name = "label13";
            label13.Size = new Size(56, 20);
            label13.TabIndex = 27;
            label13.Text = "Estado";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label12.Location = new Point(6, 405);
            label12.Name = "label12";
            label12.Size = new Size(146, 20);
            label12.TabIndex = 24;
            label12.Text = "Correo institucional";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(9, 369);
            label11.Name = "label11";
            label11.Size = new Size(70, 20);
            label11.TabIndex = 23;
            label11.Text = "Teléfono";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label10.Location = new Point(9, 249);
            label10.Name = "label10";
            label10.Size = new Size(177, 20);
            label10.TabIndex = 16;
            label10.Text = "Apellidos del Estudiante";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(6, 209);
            label9.Name = "label9";
            label9.Size = new Size(170, 20);
            label9.TabIndex = 15;
            label9.Text = "Nombre del Estudiante";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(9, 329);
            label8.Name = "label8";
            label8.Size = new Size(61, 20);
            label8.TabIndex = 14;
            label8.Text = "Sección";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(9, 170);
            label7.Name = "label7";
            label7.Size = new Size(55, 20);
            label7.TabIndex = 13;
            label7.Text = "Carnet";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(9, 289);
            label6.Name = "label6";
            label6.Size = new Size(101, 20);
            label6.TabIndex = 12;
            label6.Text = "Grado Actual";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(9, 150);
            label5.Name = "label5";
            label5.Size = new Size(174, 20);
            label5.TabIndex = 11;
            label5.Text = "Estudiante Selecionado:";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(cmbFiltroEstudiantes);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(3, 23);
            panel2.Name = "panel2";
            panel2.Size = new Size(395, 110);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 51);
            panel3.Name = "panel3";
            panel3.Size = new Size(395, 59);
            panel3.TabIndex = 12;
            // 
            // panel5
            // 
            panel5.Controls.Add(txtBuscarEstudiante);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(298, 59);
            panel5.TabIndex = 1;
            // 
            // txtBuscarEstudiante
            // 
            txtBuscarEstudiante.Dock = DockStyle.Fill;
            txtBuscarEstudiante.Location = new Point(0, 0);
            txtBuscarEstudiante.Name = "txtBuscarEstudiante";
            txtBuscarEstudiante.Size = new Size(298, 27);
            txtBuscarEstudiante.TabIndex = 9;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnBuscar);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(298, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(97, 59);
            panel4.TabIndex = 0;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(0, 3);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 12;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // cmbFiltroEstudiantes
            // 
            cmbFiltroEstudiantes.FormattingEnabled = true;
            cmbFiltroEstudiantes.Items.AddRange(new object[] { "Todos", "Carnet", "Nombre", "Apellidos", "Grado y Sección" });
            cmbFiltroEstudiantes.Location = new Point(179, 9);
            cmbFiltroEstudiantes.Name = "cmbFiltroEstudiantes";
            cmbFiltroEstudiantes.Size = new Size(151, 28);
            cmbFiltroEstudiantes.TabIndex = 11;
            cmbFiltroEstudiantes.Text = "Todos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 9);
            label2.Name = "label2";
            label2.Size = new Size(167, 20);
            label2.TabIndex = 10;
            label2.Text = "Buscar Estudiante por:";
            // 
            // grpMatricula
            // 
            grpMatricula.Controls.Add(label23);
            grpMatricula.Controls.Add(cmbTurno);
            grpMatricula.Controls.Add(label22);
            grpMatricula.Controls.Add(cmbSección);
            grpMatricula.Controls.Add(label3);
            grpMatricula.Controls.Add(dtpFechaInscripcion);
            grpMatricula.Controls.Add(label4);
            grpMatricula.Controls.Add(cmbGradoMatricular);
            grpMatricula.Dock = DockStyle.Fill;
            grpMatricula.Location = new Point(410, 3);
            grpMatricula.Name = "grpMatricula";
            grpMatricula.Size = new Size(402, 537);
            grpMatricula.TabIndex = 1;
            grpMatricula.TabStop = false;
            grpMatricula.Text = "Detalles de Matrícula";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label23.Location = new Point(6, 139);
            label23.Name = "label23";
            label23.Size = new Size(50, 20);
            label23.TabIndex = 16;
            label23.Text = "Turno";
            // 
            // cmbTurno
            // 
            cmbTurno.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTurno.FormattingEnabled = true;
            cmbTurno.Items.AddRange(new object[] { "Matutino", "Vespertino", "Nocturno", "Sabatino" });
            cmbTurno.Location = new Point(6, 162);
            cmbTurno.Name = "cmbTurno";
            cmbTurno.Size = new Size(390, 28);
            cmbTurno.TabIndex = 17;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label22.Location = new Point(6, 83);
            label22.Name = "label22";
            label22.Size = new Size(61, 20);
            label22.TabIndex = 14;
            label22.Text = "Sección";
            // 
            // cmbSección
            // 
            cmbSección.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSección.FormattingEnabled = true;
            cmbSección.Items.AddRange(new object[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "M", "N" });
            cmbSección.Location = new Point(6, 106);
            cmbSección.Name = "cmbSección";
            cmbSección.Size = new Size(390, 28);
            cmbSección.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(6, 23);
            label3.Name = "label3";
            label3.Size = new Size(140, 20);
            label3.TabIndex = 10;
            label3.Text = "Grado a Matricular";
            // 
            // dtpFechaInscripcion
            // 
            dtpFechaInscripcion.Format = DateTimePickerFormat.Short;
            dtpFechaInscripcion.Location = new Point(11, 227);
            dtpFechaInscripcion.Name = "dtpFechaInscripcion";
            dtpFechaInscripcion.Size = new Size(385, 27);
            dtpFechaInscripcion.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(6, 193);
            label4.Name = "label4";
            label4.Size = new Size(150, 20);
            label4.TabIndex = 12;
            label4.Text = "Fecha de Inscripción";
            // 
            // cmbGradoMatricular
            // 
            cmbGradoMatricular.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGradoMatricular.FormattingEnabled = true;
            cmbGradoMatricular.Items.AddRange(new object[] { "1° Grado", "2° Grado", "3° Grado", "4° Grado", "5° Grado", "6° Grado", "7° Grado", "8° Grado", "9° Grado" });
            cmbGradoMatricular.Location = new Point(6, 46);
            cmbGradoMatricular.Name = "cmbGradoMatricular";
            cmbGradoMatricular.Size = new Size(390, 28);
            cmbGradoMatricular.TabIndex = 11;
            // 
            // grpPago
            // 
            grpPago.Controls.Add(cmbConceptoPago);
            grpPago.Controls.Add(chbConfirmarPago);
            grpPago.Controls.Add(txtMontoTotal);
            grpPago.Controls.Add(label25);
            grpPago.Controls.Add(label24);
            grpPago.Dock = DockStyle.Fill;
            grpPago.Location = new Point(818, 3);
            grpPago.Name = "grpPago";
            grpPago.Size = new Size(403, 537);
            grpPago.TabIndex = 2;
            grpPago.TabStop = false;
            grpPago.Text = "Detalles de Pago";
            // 
            // cmbConceptoPago
            // 
            cmbConceptoPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbConceptoPago.FormattingEnabled = true;
            cmbConceptoPago.Items.AddRange(new object[] { "Matrícula" });
            cmbConceptoPago.Location = new Point(4, 46);
            cmbConceptoPago.Name = "cmbConceptoPago";
            cmbConceptoPago.Size = new Size(390, 28);
            cmbConceptoPago.TabIndex = 17;
            // 
            // chbConfirmarPago
            // 
            chbConfirmarPago.AutoSize = true;
            chbConfirmarPago.Location = new Point(6, 146);
            chbConfirmarPago.Name = "chbConfirmarPago";
            chbConfirmarPago.Size = new Size(134, 24);
            chbConfirmarPago.TabIndex = 16;
            chbConfirmarPago.Text = "Confirmar Pago";
            chbConfirmarPago.UseVisualStyleBackColor = true;
            // 
            // txtMontoTotal
            // 
            txtMontoTotal.Location = new Point(6, 106);
            txtMontoTotal.Name = "txtMontoTotal";
            txtMontoTotal.Size = new Size(388, 27);
            txtMontoTotal.TabIndex = 15;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label25.Location = new Point(6, 82);
            label25.Name = "label25";
            label25.Size = new Size(95, 20);
            label25.TabIndex = 14;
            label25.Text = "Monto Total";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label24.Location = new Point(6, 23);
            label24.Name = "label24";
            label24.Size = new Size(139, 20);
            label24.TabIndex = 12;
            label24.Text = "Concepto de Pago ";
            // 
            // frmMatriculas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1224, 631);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMatriculas";
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            grpEstudiante.ResumeLayout(false);
            grpEstudiante.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            grpMatricula.ResumeLayout(false);
            grpMatricula.PerformLayout();
            grpPago.ResumeLayout(false);
            grpPago.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnCerrar;
        private Button btnRegistrarMatricula;
        private FlowLayoutPanel flowLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox grpEstudiante;
        private GroupBox grpMatricula;
        private GroupBox grpPago;
        private Panel panel2;
        private TextBox txtBuscarEstudiante;
        private Label label3;
        private DateTimePicker dtpFechaInscripcion;
        private Label label4;
        private ComboBox cmbGradoMatricular;
        private ComboBox cmbFiltroEstudiantes;
        private Label label2;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button btnBuscar;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label21;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label23;
        private ComboBox cmbTurno;
        private Label label22;
        private ComboBox cmbSección;
        private CheckBox chbConfirmarPago;
        private TextBox txtMontoTotal;
        private Label label25;
        private Label label24;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ComboBox cmbConceptoPago;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
    }
}