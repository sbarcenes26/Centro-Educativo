namespace Centro_Educativo
{
    partial class frmPagos
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
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnBuscarPago = new Button();
            txtBuscarEstudiante = new TextBox();
            label1 = new Label();
            btnCerrar = new Button();
            btnRegistrarPago = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnTalonario = new Button();
            dgvMensualidades = new DataGridView();
            coLGrado = new DataGridViewTextBoxColumn();
            colNPE = new DataGridViewTextBoxColumn();
            colNCuota = new DataGridViewTextBoxColumn();
            colFechaVenc = new DataGridViewTextBoxColumn();
            colFechaPago = new DataGridViewTextBoxColumn();
            colMonto = new DataGridViewTextBoxColumn();
            colEstado = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMensualidades).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnBuscarPago);
            panel1.Controls.Add(txtBuscarEstudiante);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(895, 112);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 47);
            panel2.Name = "panel2";
            panel2.Size = new Size(895, 65);
            panel2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(687, 32);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(184, 27);
            textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(181, 32);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(500, 27);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(163, 27);
            textBox1.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(687, 9);
            label4.Name = "label4";
            label4.Size = new Size(116, 20);
            label4.TabIndex = 2;
            label4.Text = "Grado y Sección";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(181, 12);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 1;
            label3.Text = "Estudiante";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 12);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 0;
            label2.Text = "Carnet";
            // 
            // btnBuscarPago
            // 
            btnBuscarPago.FlatStyle = FlatStyle.Flat;
            btnBuscarPago.Location = new Point(546, 12);
            btnBuscarPago.Name = "btnBuscarPago";
            btnBuscarPago.Size = new Size(187, 29);
            btnBuscarPago.TabIndex = 3;
            btnBuscarPago.Text = "Consultar Estado";
            btnBuscarPago.UseVisualStyleBackColor = true;
            // 
            // txtBuscarEstudiante
            // 
            txtBuscarEstudiante.Location = new Point(82, 13);
            txtBuscarEstudiante.Name = "txtBuscarEstudiante";
            txtBuscarEstudiante.Size = new Size(458, 27);
            txtBuscarEstudiante.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(7, 13);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 0;
            label1.Text = "Alumno:";
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Location = new Point(341, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(94, 29);
            btnCerrar.TabIndex = 4;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnRegistrarPago
            // 
            btnRegistrarPago.FlatStyle = FlatStyle.Flat;
            btnRegistrarPago.Location = new Point(669, 3);
            btnRegistrarPago.Name = "btnRegistrarPago";
            btnRegistrarPago.Size = new Size(223, 29);
            btnRegistrarPago.TabIndex = 3;
            btnRegistrarPago.Text = "Registrar Pago de Cuota";
            btnRegistrarPago.UseVisualStyleBackColor = true;
            btnRegistrarPago.Click += btnRegistrarPago_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ActiveCaption;
            flowLayoutPanel1.Controls.Add(btnRegistrarPago);
            flowLayoutPanel1.Controls.Add(btnTalonario);
            flowLayoutPanel1.Controls.Add(btnCerrar);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(0, 442);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(895, 48);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // btnTalonario
            // 
            btnTalonario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnTalonario.FlatStyle = FlatStyle.Flat;
            btnTalonario.Location = new Point(441, 3);
            btnTalonario.Name = "btnTalonario";
            btnTalonario.Size = new Size(222, 29);
            btnTalonario.TabIndex = 6;
            btnTalonario.Text = "Descargar Talonario";
            btnTalonario.UseVisualStyleBackColor = true;
            // 
            // dgvMensualidades
            // 
            dgvMensualidades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMensualidades.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(35, 87, 137);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvMensualidades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvMensualidades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMensualidades.Columns.AddRange(new DataGridViewColumn[] { coLGrado, colNPE, colNCuota, colFechaVenc, colFechaPago, colMonto, colEstado });
            dgvMensualidades.Dock = DockStyle.Fill;
            dgvMensualidades.EnableHeadersVisualStyles = false;
            dgvMensualidades.Location = new Point(0, 112);
            dgvMensualidades.Name = "dgvMensualidades";
            dgvMensualidades.RowHeadersWidth = 51;
            dgvMensualidades.Size = new Size(895, 330);
            dgvMensualidades.TabIndex = 8;
            // 
            // coLGrado
            // 
            coLGrado.HeaderText = "Grado";
            coLGrado.MinimumWidth = 6;
            coLGrado.Name = "coLGrado";
            // 
            // colNPE
            // 
            colNPE.HeaderText = "NPE";
            colNPE.MinimumWidth = 6;
            colNPE.Name = "colNPE";
            // 
            // colNCuota
            // 
            colNCuota.HeaderText = "N°Cuota";
            colNCuota.MinimumWidth = 6;
            colNCuota.Name = "colNCuota";
            // 
            // colFechaVenc
            // 
            colFechaVenc.HeaderText = "Fecha de Vencimiento";
            colFechaVenc.MinimumWidth = 6;
            colFechaVenc.Name = "colFechaVenc";
            // 
            // colFechaPago
            // 
            colFechaPago.HeaderText = "Fecha de Pago";
            colFechaPago.MinimumWidth = 6;
            colFechaPago.Name = "colFechaPago";
            // 
            // colMonto
            // 
            colMonto.HeaderText = "Monto ($)";
            colMonto.MinimumWidth = 6;
            colMonto.Name = "colMonto";
            // 
            // colEstado
            // 
            colEstado.HeaderText = "Estado de Cuota";
            colEstado.MinimumWidth = 6;
            colEstado.Name = "colEstado";
            // 
            // frmPagos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 490);
            Controls.Add(dgvMensualidades);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPagos";
            Load += frmPagos_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMensualidades).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtBuscarEstudiante;
        private Button btnBuscarPago;
        private Button btnCerrar;
        private Button btnRegistrarPago;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox3;
        private Button btnTalonario;
        private DataGridView dgvMensualidades;
        private DataGridViewTextBoxColumn coLGrado;
        private DataGridViewTextBoxColumn colNPE;
        private DataGridViewTextBoxColumn colNCuota;
        private DataGridViewTextBoxColumn colFechaVenc;
        private DataGridViewTextBoxColumn colFechaPago;
        private DataGridViewTextBoxColumn colMonto;
        private DataGridViewTextBoxColumn colEstado;
    }
}