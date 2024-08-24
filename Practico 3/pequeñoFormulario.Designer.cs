namespace Practico_3
{
    partial class pequeñoFormulario
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pequeñoFormulario));
            lblNombreCompleto = new Label();
            lblNombre = new Label();
            lblDNI = new Label();
            lblTelefono = new Label();
            lblApellido = new Label();
            lblTarjetas = new Label();
            lblModificar = new Label();
            txtDNI = new TextBox();
            txtTelefono = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            cbVisa = new CheckBox();
            cbMastercard = new CheckBox();
            cbNaranja = new CheckBox();
            rbMujer = new RadioButton();
            rbHombre = new RadioButton();
            btnEliminar = new Button();
            btnGuardar = new Button();
            btnSalir = new Button();
            imgSeleccionar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)imgSeleccionar).BeginInit();
            SuspendLayout();
            // 
            // lblNombreCompleto
            // 
            lblNombreCompleto.AutoSize = true;
            lblNombreCompleto.Location = new Point(46, 41);
            lblNombreCompleto.Name = "lblNombreCompleto";
            lblNombreCompleto.Size = new Size(110, 15);
            lblNombreCompleto.TabIndex = 0;
            lblNombreCompleto.Text = "Nombre y Apellido:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(46, 134);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(46, 93);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(30, 15);
            lblDNI.TabIndex = 2;
            lblDNI.Text = "DNI:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(46, 217);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(55, 15);
            lblTelefono.TabIndex = 3;
            lblTelefono.Text = "Telefono:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(46, 178);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(54, 15);
            lblApellido.TabIndex = 4;
            lblApellido.Text = "Apellido:";
            // 
            // lblTarjetas
            // 
            lblTarjetas.AutoSize = true;
            lblTarjetas.Location = new Point(46, 271);
            lblTarjetas.Name = "lblTarjetas";
            lblTarjetas.Size = new Size(107, 15);
            lblTarjetas.TabIndex = 5;
            lblTarjetas.Text = "Tarjetas de Crédito:";
            // 
            // lblModificar
            // 
            lblModificar.AutoSize = true;
            lblModificar.ForeColor = Color.Red;
            lblModificar.Location = new Point(190, 41);
            lblModificar.Name = "lblModificar";
            lblModificar.Size = new Size(58, 15);
            lblModificar.TabIndex = 6;
            lblModificar.Text = "modificar";
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(190, 85);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(159, 23);
            txtDNI.TabIndex = 7;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(190, 209);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(159, 23);
            txtTelefono.TabIndex = 8;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(190, 170);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(159, 23);
            txtApellido.TabIndex = 9;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(190, 126);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(159, 23);
            txtNombre.TabIndex = 10;
            // 
            // cbVisa
            // 
            cbVisa.AutoSize = true;
            cbVisa.Location = new Point(190, 267);
            cbVisa.Name = "cbVisa";
            cbVisa.Size = new Size(47, 19);
            cbVisa.TabIndex = 11;
            cbVisa.Text = "Visa";
            cbVisa.UseVisualStyleBackColor = true;
            // 
            // cbMastercard
            // 
            cbMastercard.AutoSize = true;
            cbMastercard.Location = new Point(190, 302);
            cbMastercard.Name = "cbMastercard";
            cbMastercard.Size = new Size(85, 19);
            cbMastercard.TabIndex = 12;
            cbMastercard.Text = "Mastercard";
            cbMastercard.UseVisualStyleBackColor = true;
            // 
            // cbNaranja
            // 
            cbNaranja.AutoSize = true;
            cbNaranja.Location = new Point(190, 343);
            cbNaranja.Name = "cbNaranja";
            cbNaranja.Size = new Size(67, 19);
            cbNaranja.TabIndex = 13;
            cbNaranja.Text = "Naranja";
            cbNaranja.UseVisualStyleBackColor = true;
            // 
            // rbMujer
            // 
            rbMujer.AutoSize = true;
            rbMujer.Location = new Point(398, 188);
            rbMujer.Name = "rbMujer";
            rbMujer.Size = new Size(56, 19);
            rbMujer.TabIndex = 14;
            rbMujer.TabStop = true;
            rbMujer.Text = "Mujer";
            rbMujer.UseVisualStyleBackColor = true;
            rbMujer.CheckedChanged += rbMujer_CheckedChanged;
            // 
            // rbHombre
            // 
            rbHombre.AutoSize = true;
            rbHombre.Location = new Point(514, 188);
            rbHombre.Name = "rbHombre";
            rbHombre.Size = new Size(69, 19);
            rbHombre.TabIndex = 15;
            rbHombre.TabStop = true;
            rbHombre.Text = "Hombre";
            rbHombre.UseVisualStyleBackColor = true;
            rbHombre.CheckedChanged += rbHombre_CheckedChanged;
            // 
            // btnEliminar
            // 
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(216, 399);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(133, 68);
            btnEliminar.TabIndex = 16;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextAlign = ContentAlignment.MiddleRight;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(46, 399);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(121, 68);
            btnGuardar.TabIndex = 17;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalir.Location = new Point(471, 399);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(112, 68);
            btnSalir.TabIndex = 18;
            btnSalir.Text = "Salir";
            btnSalir.TextAlign = ContentAlignment.MiddleRight;
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // imgSeleccionar
            // 
            imgSeleccionar.Image = Properties.Resources.varon;
            imgSeleccionar.Location = new Point(426, 41);
            imgSeleccionar.Name = "imgSeleccionar";
            imgSeleccionar.Size = new Size(134, 133);
            imgSeleccionar.SizeMode = PictureBoxSizeMode.Zoom;
            imgSeleccionar.TabIndex = 19;
            imgSeleccionar.TabStop = false;
            // 
            // pequeñoFormulario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 476);
            Controls.Add(imgSeleccionar);
            Controls.Add(btnSalir);
            Controls.Add(btnGuardar);
            Controls.Add(btnEliminar);
            Controls.Add(rbHombre);
            Controls.Add(rbMujer);
            Controls.Add(cbNaranja);
            Controls.Add(cbMastercard);
            Controls.Add(cbVisa);
            Controls.Add(txtNombre);
            Controls.Add(txtApellido);
            Controls.Add(txtTelefono);
            Controls.Add(txtDNI);
            Controls.Add(lblModificar);
            Controls.Add(lblTarjetas);
            Controls.Add(lblApellido);
            Controls.Add(lblTelefono);
            Controls.Add(lblDNI);
            Controls.Add(lblNombre);
            Controls.Add(lblNombreCompleto);
            Name = "pequeñoFormulario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pequeño Formulario";
            ((System.ComponentModel.ISupportInitialize)imgSeleccionar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombreCompleto;
        private Label lblNombre;
        private Label lblDNI;
        private Label lblTelefono;
        private Label lblApellido;
        private Label lblTarjetas;
        private Label lblModificar;
        private TextBox txtDNI;
        private TextBox txtTelefono;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private CheckBox cbVisa;
        private CheckBox cbMastercard;
        private CheckBox cbNaranja;
        private RadioButton rbMujer;
        private RadioButton rbHombre;
        private Button btnEliminar;
        private Button btnGuardar;
        private Button btnSalir;
        private PictureBox imgSeleccionar;
    }
}
