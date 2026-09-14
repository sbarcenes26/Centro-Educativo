namespace Centro_Educativo
{
    partial class FrmEstudiantes
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnCerrar = new Button();
            btnEditar = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            btnAgregarEstudiante = new Button();
            btnBuscar = new Button();
            txtBuscarEstudiante = new TextBox();
            cmbFiltroEstudiantes = new ComboBox();
            label1 = new Label();
            dgvEstudiantes = new DataGridView();
            colCarnet = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colApellido = new DataGridViewTextBoxColumn();
            colGrado = new DataGridViewTextBoxColumn();
            colSección = new DataGridViewTextBoxColumn();
            colTelefono = new DataGridViewTextBoxColumn();
            colCorreo = new DataGridViewTextBoxColumn();
            colEstado = new DataGridViewTextBoxColumn();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEstudiantes).BeginInit();
            SuspendLayout();
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Location = new Point(988, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(94, 29);
            btnCerrar.TabIndex = 4;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Location = new Point(888, 3);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ActiveCaption;
            flowLayoutPanel1.Controls.Add(btnCerrar);
            flowLayoutPanel1.Controls.Add(btnEditar);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(0, 597);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1085, 37);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnAgregarEstudiante);
            panel1.Controls.Add(btnBuscar);
            panel1.Controls.Add(txtBuscarEstudiante);
            panel1.Controls.Add(cmbFiltroEstudiantes);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1085, 60);
            panel1.TabIndex = 6;
            // 
            // btnAgregarEstudiante
            // 
            btnAgregarEstudiante.Location = new Point(880, 22);
            btnAgregarEstudiante.Name = "btnAgregarEstudiante";
            btnAgregarEstudiante.Size = new Size(167, 29);
            btnAgregarEstudiante.TabIndex = 4;
            btnAgregarEstudiante.Text = "Agregar Estudiante";
            btnAgregarEstudiante.UseVisualStyleBackColor = true;
            btnAgregarEstudiante.Click += btnAgregarEstudiante_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(780, 21);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBuscarEstudiante
            // 
            txtBuscarEstudiante.Location = new Point(342, 22);
            txtBuscarEstudiante.Name = "txtBuscarEstudiante";
            txtBuscarEstudiante.Size = new Size(432, 27);
            txtBuscarEstudiante.TabIndex = 2;
            // 
            // cmbFiltroEstudiantes
            // 
            cmbFiltroEstudiantes.FormattingEnabled = true;
            cmbFiltroEstudiantes.Items.AddRange(new object[] { "Todos", "Carnet", "Nombre", "Apellidos", "Grado y Sección" });
            cmbFiltroEstudiantes.Location = new Point(185, 21);
            cmbFiltroEstudiantes.Name = "cmbFiltroEstudiantes";
            cmbFiltroEstudiantes.Size = new Size(151, 28);
            cmbFiltroEstudiantes.TabIndex = 1;
            cmbFiltroEstudiantes.Text = "Todos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(167, 20);
            label1.TabIndex = 0;
            label1.Text = "Buscar Estudiante por:";
            // 
            // dgvEstudiantes
            // 
            dgvEstudiantes.AllowUserToAddRows = false;
            dgvEstudiantes.AllowUserToDeleteRows = false;
            dgvEstudiantes.AllowUserToResizeRows = false;
            dgvEstudiantes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEstudiantes.BackgroundColor = Color.White;
            dgvEstudiantes.BorderStyle = BorderStyle.None;
            dgvEstudiantes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvEstudiantes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(35, 87, 137);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvEstudiantes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvEstudiantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstudiantes.Columns.AddRange(new DataGridViewColumn[] { colCarnet, colNombre, colApellido, colGrado, colSección, colTelefono, colCorreo, colEstado });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvEstudiantes.DefaultCellStyle = dataGridViewCellStyle2;
            dgvEstudiantes.Dock = DockStyle.Fill;
            dgvEstudiantes.EnableHeadersVisualStyles = false;
            dgvEstudiantes.GridColor = Color.Gainsboro;
            dgvEstudiantes.Location = new Point(0, 60);
            dgvEstudiantes.MultiSelect = false;
            dgvEstudiantes.Name = "dgvEstudiantes";
            dgvEstudiantes.ReadOnly = true;
            dgvEstudiantes.RowHeadersVisible = false;
            dgvEstudiantes.RowHeadersWidth = 51;
            dgvEstudiantes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEstudiantes.Size = new Size(1085, 537);
            dgvEstudiantes.TabIndex = 7;
            // 
            // colCarnet
            // 
            colCarnet.HeaderText = "Carnet";
            colCarnet.MinimumWidth = 6;
            colCarnet.Name = "colCarnet";
            colCarnet.ReadOnly = true;
            // 
            // colNombre
            // 
            colNombre.HeaderText = "Nombre";
            colNombre.MinimumWidth = 6;
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            // 
            // colApellido
            // 
            colApellido.HeaderText = "Apellido";
            colApellido.MinimumWidth = 6;
            colApellido.Name = "colApellido";
            colApellido.ReadOnly = true;
            // 
            // colGrado
            // 
            colGrado.HeaderText = "Grado";
            colGrado.MinimumWidth = 6;
            colGrado.Name = "colGrado";
            colGrado.ReadOnly = true;
            // 
            // colSección
            // 
            colSección.HeaderText = "Sección";
            colSección.MinimumWidth = 6;
            colSección.Name = "colSección";
            colSección.ReadOnly = true;
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
            colCorreo.HeaderText = "Correo Institucional";
            colCorreo.MinimumWidth = 6;
            colCorreo.Name = "colCorreo";
            colCorreo.ReadOnly = true;
            // 
            // colEstado
            // 
            colEstado.HeaderText = "Estado";
            colEstado.MinimumWidth = 6;
            colEstado.Name = "colEstado";
            colEstado.ReadOnly = true;
            // 
            // FrmEstudiantes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 634);
            Controls.Add(dgvEstudiantes);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmEstudiantes";
            WindowState = FormWindowState.Maximized;
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEstudiantes).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnCerrar;
        private Button btnEditar;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Button btnAgregarEstudiante;
        private Button btnBuscar;
        private TextBox txtBuscarEstudiante;
        private ComboBox cmbFiltroEstudiantes;
        private Label label1;
        private DataGridView dgvEstudiantes;
        private DataGridViewTextBoxColumn colCarnet;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colApellido;
        private DataGridViewTextBoxColumn colGrado;
        private DataGridViewTextBoxColumn colSección;
        private DataGridViewTextBoxColumn colTelefono;
        private DataGridViewTextBoxColumn colCorreo;
        private DataGridViewTextBoxColumn colEstado;
    }
}