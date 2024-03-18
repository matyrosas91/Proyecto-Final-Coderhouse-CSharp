namespace Proyecto_CoderHouse
{
    partial class Vista
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
            dgbProductos = new DataGridView();
            btnCargarUsuarios = new Button();
            btnCargarProductos = new Button();
            btnBuscarPorId = new Button();
            txtId = new TextBox();
            btnAgregarUsuario = new Button();
            btnEliminarProducto = new Button();
            ((System.ComponentModel.ISupportInitialize)dgbProductos).BeginInit();
            SuspendLayout();
            // 
            // dgbProductos
            // 
            dgbProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgbProductos.Location = new Point(12, 216);
            dgbProductos.MultiSelect = false;
            dgbProductos.Name = "dgbProductos";
            dgbProductos.RowTemplate.Height = 25;
            dgbProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgbProductos.Size = new Size(776, 222);
            dgbProductos.TabIndex = 0;
            dgbProductos.CellContentClick += dgbProductos_CellContentClick;
            // 
            // btnCargarUsuarios
            // 
            btnCargarUsuarios.BackColor = SystemColors.ActiveCaption;
            btnCargarUsuarios.Location = new Point(12, 148);
            btnCargarUsuarios.Name = "btnCargarUsuarios";
            btnCargarUsuarios.Size = new Size(109, 23);
            btnCargarUsuarios.TabIndex = 1;
            btnCargarUsuarios.Text = "Cargar Usuarios";
            btnCargarUsuarios.UseVisualStyleBackColor = false;
            btnCargarUsuarios.Click += btnListar_Click;
            // 
            // btnCargarProductos
            // 
            btnCargarProductos.BackColor = SystemColors.ActiveCaption;
            btnCargarProductos.Location = new Point(12, 177);
            btnCargarProductos.Name = "btnCargarProductos";
            btnCargarProductos.Size = new Size(109, 23);
            btnCargarProductos.TabIndex = 2;
            btnCargarProductos.Text = "Cargar Productos";
            btnCargarProductos.UseVisualStyleBackColor = false;
            btnCargarProductos.Click += btnCargarDatos_Click;
            // 
            // btnBuscarPorId
            // 
            btnBuscarPorId.BackColor = SystemColors.ActiveCaption;
            btnBuscarPorId.Location = new Point(12, 119);
            btnBuscarPorId.Name = "btnBuscarPorId";
            btnBuscarPorId.Size = new Size(109, 23);
            btnBuscarPorId.TabIndex = 3;
            btnBuscarPorId.Text = "Buscar por ID";
            btnBuscarPorId.UseVisualStyleBackColor = false;
            btnBuscarPorId.Click += btnBuscarPorId_Click;
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.ControlLightLight;
            txtId.Location = new Point(127, 120);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 4;
            txtId.Text = "Ingrese ID:";
            // 
            // btnAgregarUsuario
            // 
            btnAgregarUsuario.BackColor = SystemColors.ActiveCaption;
            btnAgregarUsuario.Location = new Point(12, 90);
            btnAgregarUsuario.Name = "btnAgregarUsuario";
            btnAgregarUsuario.Size = new Size(109, 23);
            btnAgregarUsuario.TabIndex = 5;
            btnAgregarUsuario.Text = "Agregar Usuario";
            btnAgregarUsuario.UseVisualStyleBackColor = false;
            btnAgregarUsuario.Click += btnAgregarUsuario_Click;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.BackColor = SystemColors.ActiveCaption;
            btnEliminarProducto.Location = new Point(11, 61);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(110, 23);
            btnEliminarProducto.TabIndex = 6;
            btnEliminarProducto.Text = "Eliminar Producto";
            btnEliminarProducto.UseVisualStyleBackColor = false;
            btnEliminarProducto.Click += btnEliminarProducto_Click;
            // 
            // Vista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(806, 456);
            Controls.Add(btnEliminarProducto);
            Controls.Add(btnAgregarUsuario);
            Controls.Add(txtId);
            Controls.Add(btnBuscarPorId);
            Controls.Add(btnCargarProductos);
            Controls.Add(btnCargarUsuarios);
            Controls.Add(dgbProductos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Vista";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Vista_Load;
            ((System.ComponentModel.ISupportInitialize)dgbProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgbProductos;
        private Button btnCargarUsuarios;
        private Button btnCargarProductos;
        private Button btnBuscarPorId;
        private TextBox txtId;
        private Button btnAgregarUsuario;
        private Button btnEliminarProducto;
    }
}