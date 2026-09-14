namespace Centro_Educativo
{
    partial class FrmAgregarEstudiante
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
            btnGuardar = new Button();
            tbnCancelar = new Button();
            label1 = new Label();
            txtNombres = new TextBox();
            label2 = new Label();
            txtApellidos = new TextBox();
            label3 = new Label();
            txtCorreo = new TextBox();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            txtCarnet = new TextBox();
            label8 = new Label();
            txtGrado = new TextBox();
            label4 = new Label();
            label7 = new Label();
            label9 = new Label();
            txtSeccion = new TextBox();
            txtTelefono = new TextBox();
            txtEstado = new TextBox();
            label10 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Location = new Point(946, 3);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // tbnCancelar
            // 
            tbnCancelar.FlatStyle = FlatStyle.Flat;
            tbnCancelar.Location = new Point(1046, 3);
            tbnCancelar.Name = "tbnCancelar";
            tbnCancelar.Size = new Size(94, 29);
            tbnCancelar.TabIndex = 1;
            tbnCancelar.Text = "Cancelar";
            tbnCancelar.UseVisualStyleBackColor = true;
            tbnCancelar.Click += tbnCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(36, 134);
            label1.Name = "label1";
            label1.Size = new Size(170, 20);
            label1.TabIndex = 2;
            label1.Text = "Nombre del Estudiante";
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(37, 157);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(362, 27);
            txtNombres.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(37, 187);
            label2.Name = "label2";
            label2.Size = new Size(177, 20);
            label2.TabIndex = 4;
            label2.Text = "Apellidos del Estudiante";
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(37, 210);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(362, 27);
            txtApellidos.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(37, 399);
            label3.Name = "label3";
            label3.Size = new Size(146, 20);
            label3.TabIndex = 6;
            label3.Text = "Correo institucional";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(36, 422);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(361, 27);
            txtCorreo.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._4519678;
            pictureBox1.Location = new Point(481, 81);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(282, 274);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.Font = new Font("Consolas", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(114, 9);
            label5.Name = "label5";
            label5.Size = new Size(585, 42);
            label5.TabIndex = 12;
            label5.Text = "Registro de Estudiantes";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Location = new Point(529, 369);
            label6.Name = "label6";
            label6.Size = new Size(194, 25);
            label6.TabIndex = 13;
            label6.Text = "Foto de Registro Estudiantil";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1143, 56);
            panel1.TabIndex = 14;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ActiveCaption;
            flowLayoutPanel1.Controls.Add(tbnCancelar);
            flowLayoutPanel1.Controls.Add(btnGuardar);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(0, 518);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1143, 40);
            flowLayoutPanel1.TabIndex = 15;
            // 
            // txtCarnet
            // 
            txtCarnet.Location = new Point(37, 104);
            txtCarnet.Name = "txtCarnet";
            txtCarnet.Size = new Size(362, 27);
            txtCarnet.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(37, 81);
            label8.Name = "label8";
            label8.Size = new Size(55, 20);
            label8.TabIndex = 18;
            label8.Text = "Carnet";
            // 
            // txtGrado
            // 
            txtGrado.Location = new Point(36, 263);
            txtGrado.Name = "txtGrado";
            txtGrado.Size = new Size(361, 27);
            txtGrado.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(36, 240);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 20;
            label4.Text = "Grado";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(36, 293);
            label7.Name = "label7";
            label7.Size = new Size(61, 20);
            label7.TabIndex = 21;
            label7.Text = "Sección";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(36, 346);
            label9.Name = "label9";
            label9.Size = new Size(70, 20);
            label9.TabIndex = 22;
            label9.Text = "Teléfono";
            // 
            // txtSeccion
            // 
            txtSeccion.Location = new Point(37, 316);
            txtSeccion.Name = "txtSeccion";
            txtSeccion.Size = new Size(362, 27);
            txtSeccion.TabIndex = 23;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(36, 369);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(361, 27);
            txtTelefono.TabIndex = 24;
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(36, 475);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(363, 27);
            txtEstado.TabIndex = 25;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(36, 452);
            label10.Name = "label10";
            label10.Size = new Size(56, 20);
            label10.TabIndex = 26;
            label10.Text = "Estado";
            // 
            // button2
            // 
            button2.Location = new Point(549, 395);
            button2.Name = "button2";
            button2.Size = new Size(150, 29);
            button2.TabIndex = 27;
            button2.Text = "CARGAR FOTO";
            button2.UseVisualStyleBackColor = true;
            // 
            // FrmAgregarEstudiante
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1143, 558);
            Controls.Add(button2);
            Controls.Add(label10);
            Controls.Add(txtEstado);
            Controls.Add(txtTelefono);
            Controls.Add(txtSeccion);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(txtGrado);
            Controls.Add(label8);
            Controls.Add(txtCarnet);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(txtCorreo);
            Controls.Add(label3);
            Controls.Add(txtApellidos);
            Controls.Add(label2);
            Controls.Add(txtNombres);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmAgregarEstudiante";
            StartPosition = FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private Button tbnCancelar;
        private Label label1;
        private TextBox txtNombres;
        private Label label2;
        private TextBox txtApellidos;
        private Label label3;
        private TextBox txtCorreo;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label6;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label7;
        private TextBox txtCarnet;
        private Label label8;
        private TextBox txtGrado;
        private Label label4;
        private Label label9;
        private TextBox txtSeccion;
        private TextBox txtTelefono;
        private TextBox txtEstado;
        private Label label10;
        private Button button2;
    }
}