
namespace Diseno
{
    partial class Empleados
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.TxtBuscarEmpleado = new System.Windows.Forms.TextBox();
            this.BtnAñadir = new System.Windows.Forms.Button();
            this.DtListaEmpleados = new System.Windows.Forms.DataGridView();
            this.PnlFormulario = new System.Windows.Forms.Panel();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblApellido = new System.Windows.Forms.Label();
            this.LblRut = new System.Windows.Forms.Label();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.LblContrasena = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblFono = new System.Windows.Forms.Label();
            this.LblRol = new System.Windows.Forms.Label();
            this.LblEstado = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtRut = new System.Windows.Forms.TextBox();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtContrasena = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtFono = new System.Windows.Forms.TextBox();
            this.CbxRol = new System.Windows.Forms.ComboBox();
            this.CbxEstado = new System.Windows.Forms.ComboBox();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnGuardarCambios = new System.Windows.Forms.Button();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtListaEmpleados)).BeginInit();
            this.PnlFormulario.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(157, 606);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.TxtBuscarEmpleado);
            this.panel2.Controls.Add(this.BtnAñadir);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1191, 58);
            this.panel2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Diseno.Properties.Resources.search;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::Diseno.Properties.Resources.search;
            this.button2.Location = new System.Drawing.Point(65, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 28);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // TxtBuscarEmpleado
            // 
            this.TxtBuscarEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBuscarEmpleado.Location = new System.Drawing.Point(102, 19);
            this.TxtBuscarEmpleado.Multiline = true;
            this.TxtBuscarEmpleado.Name = "TxtBuscarEmpleado";
            this.TxtBuscarEmpleado.Size = new System.Drawing.Size(276, 28);
            this.TxtBuscarEmpleado.TabIndex = 1;
            // 
            // BtnAñadir
            // 
            this.BtnAñadir.BackgroundImage = global::Diseno.Properties.Resources.add_user;
            this.BtnAñadir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAñadir.FlatAppearance.BorderSize = 0;
            this.BtnAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAñadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAñadir.Location = new System.Drawing.Point(12, 15);
            this.BtnAñadir.Name = "BtnAñadir";
            this.BtnAñadir.Size = new System.Drawing.Size(39, 30);
            this.BtnAñadir.TabIndex = 0;
            this.BtnAñadir.UseVisualStyleBackColor = true;
            this.BtnAñadir.Click += new System.EventHandler(this.BtnAñadir_Click);
            // 
            // DtListaEmpleados
            // 
            this.DtListaEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DtListaEmpleados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DtListaEmpleados.BackgroundColor = System.Drawing.Color.White;
            this.DtListaEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtListaEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtListaEmpleados.GridColor = System.Drawing.Color.White;
            this.DtListaEmpleados.Location = new System.Drawing.Point(0, 58);
            this.DtListaEmpleados.Name = "DtListaEmpleados";
            this.DtListaEmpleados.ReadOnly = true;
            this.DtListaEmpleados.RowHeadersWidth = 51;
            this.DtListaEmpleados.RowTemplate.Height = 24;
            this.DtListaEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtListaEmpleados.Size = new System.Drawing.Size(1191, 606);
            this.DtListaEmpleados.TabIndex = 2;
            this.DtListaEmpleados.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DtListaEmpleados_CellMouseDoubleClick);
            // 
            // PnlFormulario
            // 
            this.PnlFormulario.AutoSize = true;
            this.PnlFormulario.Controls.Add(this.TxtID);
            this.PnlFormulario.Controls.Add(this.BtnGuardarCambios);
            this.PnlFormulario.Controls.Add(this.BtnGuardar);
            this.PnlFormulario.Controls.Add(this.BtnCerrar);
            this.PnlFormulario.Controls.Add(this.CbxEstado);
            this.PnlFormulario.Controls.Add(this.CbxRol);
            this.PnlFormulario.Controls.Add(this.TxtFono);
            this.PnlFormulario.Controls.Add(this.TxtEmail);
            this.PnlFormulario.Controls.Add(this.TxtContrasena);
            this.PnlFormulario.Controls.Add(this.TxtUsuario);
            this.PnlFormulario.Controls.Add(this.TxtRut);
            this.PnlFormulario.Controls.Add(this.TxtApellido);
            this.PnlFormulario.Controls.Add(this.TxtNombre);
            this.PnlFormulario.Controls.Add(this.LblEstado);
            this.PnlFormulario.Controls.Add(this.LblRol);
            this.PnlFormulario.Controls.Add(this.LblFono);
            this.PnlFormulario.Controls.Add(this.LblEmail);
            this.PnlFormulario.Controls.Add(this.LblContrasena);
            this.PnlFormulario.Controls.Add(this.LblUsuario);
            this.PnlFormulario.Controls.Add(this.LblRut);
            this.PnlFormulario.Controls.Add(this.LblApellido);
            this.PnlFormulario.Controls.Add(this.LblNombre);
            this.PnlFormulario.Controls.Add(this.LblTitulo);
            this.PnlFormulario.Controls.Add(this.panel1);
            this.PnlFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlFormulario.Location = new System.Drawing.Point(0, 58);
            this.PnlFormulario.Name = "PnlFormulario";
            this.PnlFormulario.Size = new System.Drawing.Size(1191, 606);
            this.PnlFormulario.TabIndex = 3;
            // 
            // LblTitulo
            // 
            this.LblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(325, 27);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(190, 25);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "Edicion de Usuarios.";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.BackColor = System.Drawing.Color.Gray;
            this.LblNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblNombre.Location = new System.Drawing.Point(43, 92);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(62, 17);
            this.LblNombre.TabIndex = 1;
            this.LblNombre.Text = "Nombre:";
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.BackColor = System.Drawing.Color.Gray;
            this.LblApellido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblApellido.Location = new System.Drawing.Point(43, 141);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(62, 17);
            this.LblApellido.TabIndex = 2;
            this.LblApellido.Text = "Apellido:";
            // 
            // LblRut
            // 
            this.LblRut.AutoSize = true;
            this.LblRut.BackColor = System.Drawing.Color.Gray;
            this.LblRut.Location = new System.Drawing.Point(43, 190);
            this.LblRut.Name = "LblRut";
            this.LblRut.Size = new System.Drawing.Size(34, 17);
            this.LblRut.TabIndex = 3;
            this.LblRut.Text = "Rut:";
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.BackColor = System.Drawing.Color.Gray;
            this.LblUsuario.Location = new System.Drawing.Point(43, 244);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(61, 17);
            this.LblUsuario.TabIndex = 3;
            this.LblUsuario.Text = "Usuario:";
            // 
            // LblContrasena
            // 
            this.LblContrasena.AutoSize = true;
            this.LblContrasena.BackColor = System.Drawing.Color.Gray;
            this.LblContrasena.Location = new System.Drawing.Point(43, 294);
            this.LblContrasena.Name = "LblContrasena";
            this.LblContrasena.Size = new System.Drawing.Size(85, 17);
            this.LblContrasena.TabIndex = 3;
            this.LblContrasena.Text = "Contraseña:";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.BackColor = System.Drawing.Color.Gray;
            this.LblEmail.Location = new System.Drawing.Point(43, 343);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(46, 17);
            this.LblEmail.TabIndex = 3;
            this.LblEmail.Text = "Email:";
            // 
            // LblFono
            // 
            this.LblFono.AutoSize = true;
            this.LblFono.BackColor = System.Drawing.Color.Gray;
            this.LblFono.Location = new System.Drawing.Point(43, 392);
            this.LblFono.Name = "LblFono";
            this.LblFono.Size = new System.Drawing.Size(44, 17);
            this.LblFono.TabIndex = 3;
            this.LblFono.Text = "Fono:";
            // 
            // LblRol
            // 
            this.LblRol.AutoSize = true;
            this.LblRol.BackColor = System.Drawing.Color.Gray;
            this.LblRol.Location = new System.Drawing.Point(43, 447);
            this.LblRol.Name = "LblRol";
            this.LblRol.Size = new System.Drawing.Size(33, 17);
            this.LblRol.TabIndex = 3;
            this.LblRol.Text = "Rol:";
            // 
            // LblEstado
            // 
            this.LblEstado.AutoSize = true;
            this.LblEstado.BackColor = System.Drawing.Color.Gray;
            this.LblEstado.Location = new System.Drawing.Point(43, 500);
            this.LblEstado.Name = "LblEstado";
            this.LblEstado.Size = new System.Drawing.Size(56, 17);
            this.LblEstado.TabIndex = 3;
            this.LblEstado.Text = "Estado:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(191, 85);
            this.TxtNombre.Multiline = true;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(525, 33);
            this.TxtNombre.TabIndex = 4;
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(191, 135);
            this.TxtApellido.Multiline = true;
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(525, 33);
            this.TxtApellido.TabIndex = 4;
            // 
            // TxtRut
            // 
            this.TxtRut.Location = new System.Drawing.Point(191, 183);
            this.TxtRut.MaxLength = 12;
            this.TxtRut.Multiline = true;
            this.TxtRut.Name = "TxtRut";
            this.TxtRut.Size = new System.Drawing.Size(525, 33);
            this.TxtRut.TabIndex = 4;
            this.TxtRut.MouseLeave += new System.EventHandler(this.TxtRut_MouseLeave);
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(191, 237);
            this.TxtUsuario.Multiline = true;
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(525, 33);
            this.TxtUsuario.TabIndex = 4;
            // 
            // TxtContrasena
            // 
            this.TxtContrasena.Location = new System.Drawing.Point(191, 286);
            this.TxtContrasena.Multiline = true;
            this.TxtContrasena.Name = "TxtContrasena";
            this.TxtContrasena.Size = new System.Drawing.Size(525, 33);
            this.TxtContrasena.TabIndex = 4;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(191, 336);
            this.TxtEmail.Multiline = true;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(525, 33);
            this.TxtEmail.TabIndex = 4;
            // 
            // TxtFono
            // 
            this.TxtFono.Location = new System.Drawing.Point(191, 388);
            this.TxtFono.MaxLength = 12;
            this.TxtFono.Multiline = true;
            this.TxtFono.Name = "TxtFono";
            this.TxtFono.Size = new System.Drawing.Size(525, 33);
            this.TxtFono.TabIndex = 4;
            // 
            // CbxRol
            // 
            this.CbxRol.FormattingEnabled = true;
            this.CbxRol.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CbxRol.Items.AddRange(new object[] {
            "--Seleccion un Rol--",
            "ADMINISTRADOR",
            "COCINERO",
            "RECEPCION",
            "FINANZAS",
            "GARZON",
            "BODEGA",
            "CLIENTE"});
            this.CbxRol.Location = new System.Drawing.Point(195, 444);
            this.CbxRol.Name = "CbxRol";
            this.CbxRol.Size = new System.Drawing.Size(400, 24);
            this.CbxRol.TabIndex = 5;
            // 
            // CbxEstado
            // 
            this.CbxEstado.FormattingEnabled = true;
            this.CbxEstado.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CbxEstado.Items.AddRange(new object[] {
            "--Seleccione un estado--",
            "Activo",
            "Eliminado"});
            this.CbxEstado.Location = new System.Drawing.Point(195, 496);
            this.CbxEstado.Name = "CbxEstado";
            this.CbxEstado.Size = new System.Drawing.Size(400, 24);
            this.CbxEstado.TabIndex = 5;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Location = new System.Drawing.Point(195, 555);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(149, 39);
            this.BtnCerrar.TabIndex = 6;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(377, 555);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(149, 39);
            this.BtnGuardar.TabIndex = 6;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnGuardarCambios
            // 
            this.BtnGuardarCambios.Location = new System.Drawing.Point(549, 555);
            this.BtnGuardarCambios.Name = "BtnGuardarCambios";
            this.BtnGuardarCambios.Size = new System.Drawing.Size(149, 39);
            this.BtnGuardarCambios.TabIndex = 6;
            this.BtnGuardarCambios.Text = "Guardar Cambios";
            this.BtnGuardarCambios.UseVisualStyleBackColor = true;
            this.BtnGuardarCambios.Click += new System.EventHandler(this.BtnGuardarCambios_Click);
            // 
            // TxtID
            // 
            this.TxtID.Enabled = false;
            this.TxtID.Location = new System.Drawing.Point(618, 27);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(50, 22);
            this.TxtID.TabIndex = 7;
            this.TxtID.Visible = false;
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 664);
            this.Controls.Add(this.PnlFormulario);
            this.Controls.Add(this.DtListaEmpleados);
            this.Controls.Add(this.panel2);
            this.Name = "Empleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleados";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtListaEmpleados)).EndInit();
            this.PnlFormulario.ResumeLayout(false);
            this.PnlFormulario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TxtBuscarEmpleado;
        private System.Windows.Forms.Button BtnAñadir;
        private System.Windows.Forms.DataGridView DtListaEmpleados;
        private System.Windows.Forms.Panel PnlFormulario;
        private System.Windows.Forms.Label LblEstado;
        private System.Windows.Forms.Label LblRol;
        private System.Windows.Forms.Label LblFono;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblContrasena;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Label LblRut;
        private System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Button BtnGuardarCambios;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.ComboBox CbxEstado;
        private System.Windows.Forms.ComboBox CbxRol;
        private System.Windows.Forms.TextBox TxtFono;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtContrasena;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtRut;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtID;
    }
}