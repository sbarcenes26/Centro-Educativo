namespace Centro_Educativo
{
    partial class frmRegistrarPago
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
            label4 = new Label();
            btnCerrar = new Button();
            btnAplicarPago = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label11 = new Label();
            panel2 = new Panel();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            label12 = new Label();
            textBox1 = new TextBox();
            label10 = new Label();
            label13 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label14 = new Label();
            label15 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(504, 53);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Consolas", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(504, 53);
            label4.TabIndex = 0;
            label4.Text = "Registrar Pago";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCerrar
            // 
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Location = new Point(407, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(94, 33);
            btnCerrar.TabIndex = 9;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnAplicarPago
            // 
            btnAplicarPago.FlatStyle = FlatStyle.Flat;
            btnAplicarPago.Location = new Point(257, 3);
            btnAplicarPago.Name = "btnAplicarPago";
            btnAplicarPago.Size = new Size(144, 33);
            btnAplicarPago.TabIndex = 8;
            btnAplicarPago.Text = "Aplicar Pago";
            btnAplicarPago.UseVisualStyleBackColor = true;
            btnAplicarPago.Click += btnAplicarPago_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ActiveCaption;
            flowLayoutPanel1.Controls.Add(btnCerrar);
            flowLayoutPanel1.Controls.Add(btnAplicarPago);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(0, 364);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(504, 49);
            flowLayoutPanel1.TabIndex = 8;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label11.Location = new Point(12, 187);
            label11.Name = "label11";
            label11.Size = new Size(174, 20);
            label11.TabIndex = 16;
            label11.Text = "Nombre del propietario";
            // 
            // panel2
            // 
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 53);
            panel2.Name = "panel2";
            panel2.Size = new Size(504, 67);
            panel2.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(361, 30);
            label9.Name = "label9";
            label9.Size = new Size(60, 20);
            label9.TabIndex = 22;
            label9.Text = "$100.00";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(242, 30);
            label8.Name = "label8";
            label8.Size = new Size(118, 20);
            label8.TabIndex = 21;
            label8.Text = "Total a Pagar: $";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(361, 10);
            label7.Name = "label7";
            label7.Size = new Size(44, 20);
            label7.TabIndex = 20;
            label7.Text = "$0.00";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(243, 10);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 19;
            label6.Text = "Recargo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(130, 30);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 18;
            label5.Text = "$100";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(130, 10);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 17;
            label2.Text = "Monto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(12, 30);
            label3.Name = "label3";
            label3.Size = new Size(113, 20);
            label3.TabIndex = 16;
            label3.Text = "Cuota Mensual";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(11, 10);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 15;
            label1.Text = "Nombre";
            // 
            // panel3
            // 
            panel3.Controls.Add(label12);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 120);
            panel3.Name = "panel3";
            panel3.Size = new Size(504, 64);
            panel3.TabIndex = 18;
            // 
            // label12
            // 
            label12.BackColor = SystemColors.ActiveCaption;
            label12.Dock = DockStyle.Fill;
            label12.Font = new Font("Consolas", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(0, 0);
            label12.Name = "label12";
            label12.Size = new Size(504, 64);
            label12.TabIndex = 1;
            label12.Text = "Centro Educativo";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 210);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(637, 27);
            textBox1.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label10.Location = new Point(12, 240);
            label10.Name = "label10";
            label10.Size = new Size(57, 20);
            label10.TabIndex = 20;
            label10.Text = "Tarjeta";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label13.Location = new Point(366, 240);
            label13.Name = "label13";
            label13.Size = new Size(34, 20);
            label13.TabIndex = 21;
            label13.Text = "Cvv";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 263);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(348, 27);
            textBox2.TabIndex = 22;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(366, 263);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 23;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label14.Location = new Point(242, 293);
            label14.Name = "label14";
            label14.Size = new Size(38, 20);
            label14.TabIndex = 24;
            label14.Text = "Mes";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label15.Location = new Point(12, 293);
            label15.Name = "label15";
            label15.Size = new Size(133, 20);
            label15.TabIndex = 25;
            label15.Text = "Vencimiento Año:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(14, 315);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 26;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(243, 316);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 27;
            // 
            // frmRegistrarPago
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(504, 413);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label13);
            Controls.Add(label10);
            Controls.Add(textBox1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label11);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Name = "frmRegistrarPago";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnAplicarPago;
        private Button btnCerrar;
        private Label label4;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label11;
        private Panel panel2;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label2;
        private Label label3;
        private Label label1;
        private Panel panel3;
        private Label label12;
        private TextBox textBox1;
        private Label label10;
        private Label label13;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label14;
        private Label label15;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
    }
}