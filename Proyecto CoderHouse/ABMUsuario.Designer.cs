namespace Proyecto_CoderHouse
{
    partial class ABMUsuario
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
            btnAceptar = new Button();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtNombreUsuario = new TextBox();
            txtMail = new TextBox();
            txtContraseña = new TextBox();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(12, 168);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(185, 71);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(46, 12);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 1;
            txtNombre.Text = "Ingrese nombre:";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(46, 41);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 2;
            txtApellido.Text = "Ingrese Apellido";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(46, 70);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(100, 23);
            txtNombreUsuario.TabIndex = 3;
            txtNombreUsuario.Text = "Ingrese Usuario";
            // 
            // txtMail
            // 
            txtMail.Location = new Point(46, 128);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(100, 23);
            txtMail.TabIndex = 5;
            txtMail.Text = "Ingrese Mail";
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(46, 99);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(100, 23);
            txtContraseña.TabIndex = 4;
            txtContraseña.Text = "Ingrese Contraseña";
            // 
            // ABMUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(214, 252);
            Controls.Add(txtMail);
            Controls.Add(txtContraseña);
            Controls.Add(txtNombreUsuario);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(btnAceptar);
            Name = "ABMUsuario";
            Text = "ABMUsuario";
            Load += ABMUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtNombreUsuario;
        private TextBox txtMail;
        private TextBox txtContraseña;
    }
}