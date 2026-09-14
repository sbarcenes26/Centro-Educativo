namespace Centro_Educativo
{
    partial class frmNuevoDocente
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
            label3 = new Label();
            label4 = new Label();
            mtxtTelefonoDocente = new MaskedTextBox();
            cmbEspecialidad = new ComboBox();
            txtApellidosDocentes = new TextBox();
            txtNombresDocente = new TextBox();
            btnGuardarCambios = new Button();
            btnCancelar = new Button();
            label5 = new Label();
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button2 = new Button();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            label8 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(19, 143);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombres";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(19, 196);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 1;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(19, 249);
            label3.Name = "label3";
            label3.Size = new Size(174, 20);
            label3.TabIndex = 2;
            label3.Text = "Especialidad Académica";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(19, 303);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 3;
            label4.Text = "Teléfono";
            // 
            // mtxtTelefonoDocente
            // 
            mtxtTelefonoDocente.Location = new Point(19, 326);
            mtxtTelefonoDocente.Mask = "####-####";
            mtxtTelefonoDocente.Name = "mtxtTelefonoDocente";
            mtxtTelefonoDocente.Size = new Size(359, 27);
            mtxtTelefonoDocente.TabIndex = 4;
            // 
            // cmbEspecialidad
            // 
            cmbEspecialidad.FormattingEnabled = true;
            cmbEspecialidad.Location = new Point(19, 272);
            cmbEspecialidad.Name = "cmbEspecialidad";
            cmbEspecialidad.Size = new Size(359, 28);
            cmbEspecialidad.TabIndex = 5;
            // 
            // txtApellidosDocentes
            // 
            txtApellidosDocentes.Location = new Point(19, 219);
            txtApellidosDocentes.Name = "txtApellidosDocentes";
            txtApellidosDocentes.Size = new Size(360, 27);
            txtApellidosDocentes.TabIndex = 6;
            // 
            // txtNombresDocente
            // 
            txtNombresDocente.Location = new Point(19, 166);
            txtNombresDocente.Name = "txtNombresDocente";
            txtNombresDocente.Size = new Size(359, 27);
            txtNombresDocente.TabIndex = 7;
            // 
            // btnGuardarCambios
            // 
            btnGuardarCambios.FlatStyle = FlatStyle.Flat;
            btnGuardarCambios.Location = new Point(662, 3);
            btnGuardarCambios.Name = "btnGuardarCambios";
            btnGuardarCambios.Size = new Size(94, 29);
            btnGuardarCambios.TabIndex = 8;
            btnGuardarCambios.Text = "Guardar";
            btnGuardarCambios.UseVisualStyleBackColor = true;
            btnGuardarCambios.Click += btnGuardarCambios_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Location = new Point(762, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Top;
            label5.Font = new Font("Consolas", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(859, 62);
            label5.TabIndex = 10;
            label5.Text = "Registro de Docente ";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(859, 62);
            panel1.TabIndex = 11;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ActiveCaption;
            flowLayoutPanel1.Controls.Add(btnCancelar);
            flowLayoutPanel1.Controls.Add(btnGuardarCambios);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(0, 432);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(859, 41);
            flowLayoutPanel1.TabIndex = 13;
            // 
            // button2
            // 
            button2.Location = new Point(606, 377);
            button2.Name = "button2";
            button2.Size = new Size(150, 29);
            button2.TabIndex = 30;
            button2.Text = "CARGAR FOTO";
            button2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.Location = new Point(618, 355);
            label6.Name = "label6";
            label6.Size = new Size(129, 25);
            label6.TabIndex = 29;
            label6.Text = "Foto de Registro";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._4519678;
            pictureBox1.Location = new Point(540, 78);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(282, 274);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(19, 90);
            label7.Name = "label7";
            label7.Size = new Size(108, 20);
            label7.TabIndex = 31;
            label7.Text = "NIP/Escalafón";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(19, 356);
            label8.Name = "label8";
            label8.Size = new Size(151, 20);
            label8.TabIndex = 32;
            label8.Text = "Correo Institucional ";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(19, 379);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(359, 27);
            textBox2.TabIndex = 34;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(19, 113);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(360, 27);
            textBox1.TabIndex = 35;
            // 
            // frmNuevoDocente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(859, 473);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Controls.Add(txtNombresDocente);
            Controls.Add(txtApellidosDocentes);
            Controls.Add(cmbEspecialidad);
            Controls.Add(mtxtTelefonoDocente);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmNuevoDocente";
            StartPosition = FormStartPosition.CenterParent;
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private MaskedTextBox mtxtTelefonoDocente;
        private ComboBox cmbEspecialidad;
        private TextBox txtApellidosDocentes;
        private TextBox txtNombresDocente;
        private Button btnGuardarCambios;
        private Button btnCancelar;
        private Label label5;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button2;
        private Label label6;
        private PictureBox pictureBox1;
        private Label label7;
        private Label label8;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}