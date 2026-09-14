namespace Centro_Educativo
{
    partial class frmDocentes
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
            label1 = new Label();
            panel1 = new Panel();
            cmbFiltros = new ComboBox();
            btnAgregarDocente = new Button();
            btnBuscar = new Button();
            txtBuscarDocente = new TextBox();
            btnCerrarDocente = new Button();
            btnEditarDocente = new Button();
            dgvDocentes = new DataGridView();
            clmEscalafón = new DataGridViewTextBoxColumn();
            clmNombre = new DataGridViewTextBoxColumn();
            colApellido = new DataGridViewTextBoxColumn();
            clmEspecialidad = new DataGridViewTextBoxColumn();
            colTelefono = new DataGridViewTextBoxColumn();
            colCorreo = new DataGridViewTextBoxColumn();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDocentes).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(151, 20);
            label1.TabIndex = 0;
            label1.Text = "Buscar Docente por:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(cmbFiltros);
            panel1.Controls.Add(btnAgregarDocente);
            panel1.Controls.Add(btnBuscar);
            panel1.Controls.Add(txtBuscarDocente);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1035, 62);
            panel1.TabIndex = 1;
            // 
            // cmbFiltros
            // 
            cmbFiltros.FormattingEnabled = true;
            cmbFiltros.Items.AddRange(new object[] { "Todos", "NIP/Escalafón", "Nombre", "Apellidos", "Especialidad" });
            cmbFiltros.Location = new Point(169, 18);
            cmbFiltros.Name = "cmbFiltros";
            cmbFiltros.Size = new Size(151, 28);
            cmbFiltros.TabIndex = 6;
            cmbFiltros.Text = "Todos";
            // 
            // btnAgregarDocente
            // 
            btnAgregarDocente.Location = new Point(864, 17);
            btnAgregarDocente.Name = "btnAgregarDocente";
            btnAgregarDocente.Size = new Size(159, 29);
            btnAgregarDocente.TabIndex = 3;
            btnAgregarDocente.Text = "Agregar Docente";
            btnAgregarDocente.UseVisualStyleBackColor = true;
            btnAgregarDocente.Click += btnAgregarDocente_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(764, 17);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBuscarDocente
            // 
            txtBuscarDocente.Location = new Point(326, 19);
            txtBuscarDocente.Name = "txtBuscarDocente";
            txtBuscarDocente.Size = new Size(432, 27);
            txtBuscarDocente.TabIndex = 1;
            // 
            // btnCerrarDocente
            // 
            btnCerrarDocente.FlatStyle = FlatStyle.Flat;
            btnCerrarDocente.Location = new Point(938, 3);
            btnCerrarDocente.Name = "btnCerrarDocente";
            btnCerrarDocente.Size = new Size(94, 29);
            btnCerrarDocente.TabIndex = 1;
            btnCerrarDocente.Text = "Cerrar";
            btnCerrarDocente.UseVisualStyleBackColor = true;
            btnCerrarDocente.Click += btnCerrarDocente_Click;
            // 
            // btnEditarDocente
            // 
            btnEditarDocente.FlatStyle = FlatStyle.Flat;
            btnEditarDocente.Location = new Point(838, 3);
            btnEditarDocente.Name = "btnEditarDocente";
            btnEditarDocente.Size = new Size(94, 29);
            btnEditarDocente.TabIndex = 0;
            btnEditarDocente.Text = "Editar";
            btnEditarDocente.UseVisualStyleBackColor = true;
            // 
            // dgvDocentes
            // 
            dgvDocentes.AllowUserToAddRows = false;
            dgvDocentes.AllowUserToDeleteRows = false;
            dgvDocentes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDocentes.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(35, 87, 137);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDocentes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDocentes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDocentes.Columns.AddRange(new DataGridViewColumn[] { clmEscalafón, clmNombre, colApellido, clmEspecialidad, colTelefono, colCorreo });
            dgvDocentes.Dock = DockStyle.Fill;
            dgvDocentes.EnableHeadersVisualStyles = false;
            dgvDocentes.Location = new Point(0, 62);
            dgvDocentes.Name = "dgvDocentes";
            dgvDocentes.ReadOnly = true;
            dgvDocentes.RowHeadersWidth = 51;
            dgvDocentes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDocentes.Size = new Size(1035, 567);
            dgvDocentes.TabIndex = 3;
            // 
            // clmEscalafón
            // 
            clmEscalafón.HeaderText = "NIP/Escalafón";
            clmEscalafón.MinimumWidth = 6;
            clmEscalafón.Name = "clmEscalafón";
            clmEscalafón.ReadOnly = true;
            // 
            // clmNombre
            // 
            clmNombre.HeaderText = "Nombre";
            clmNombre.MinimumWidth = 6;
            clmNombre.Name = "clmNombre";
            clmNombre.ReadOnly = true;
            // 
            // colApellido
            // 
            colApellido.HeaderText = "Apellido";
            colApellido.MinimumWidth = 6;
            colApellido.Name = "colApellido";
            colApellido.ReadOnly = true;
            // 
            // clmEspecialidad
            // 
            clmEspecialidad.HeaderText = "Especialidad Académica";
            clmEspecialidad.MinimumWidth = 6;
            clmEspecialidad.Name = "clmEspecialidad";
            clmEspecialidad.ReadOnly = true;
            // 
            // colTelefono
            // 
            colTelefono.HeaderText = "Teléfono";
            colTelefono.MinimumWidth = 6;
            colTelefono.Name = "colTelefono";
            colTelefono.ReadOnly = true;
            // 
            // colCorreo
            // 
            colCorreo.HeaderText = "Correo Institucional ";
            colCorreo.MinimumWidth = 6;
            colCorreo.Name = "colCorreo";
            colCorreo.ReadOnly = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ActiveCaption;
            flowLayoutPanel1.Controls.Add(btnCerrarDocente);
            flowLayoutPanel1.Controls.Add(btnEditarDocente);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(0, 586);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1035, 43);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // frmDocentes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1035, 629);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(dgvDocentes);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmDocentes";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDocentes).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button btnBuscar;
        private TextBox txtBuscarDocente;
        private Button btnAgregarDocente;
        private Button btnCerrarDocente;
        private Button btnEditarDocente;
        private DataGridView dgvDocentes;
        private FlowLayoutPanel flowLayoutPanel1;
        private ComboBox cmbFiltros;
        private DataGridViewTextBoxColumn clmEscalafón;
        private DataGridViewTextBoxColumn clmNombre;
        private DataGridViewTextBoxColumn colApellido;
        private DataGridViewTextBoxColumn clmEspecialidad;
        private DataGridViewTextBoxColumn colTelefono;
        private DataGridViewTextBoxColumn colCorreo;
    }
}