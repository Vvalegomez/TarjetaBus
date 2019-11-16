namespace Presentacion
{
    partial class FormPersona
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
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.txtBoxNdni = new System.Windows.Forms.TextBox();
            this.txtBoxCuil = new System.Windows.Forms.TextBox();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.cbTdni = new System.Windows.Forms.ComboBox();
            this.dtFechaNac = new System.Windows.Forms.DateTimePicker();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblCuil = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblTdni = new System.Windows.Forms.Label();
            this.lblNacimiento = new System.Windows.Forms.Label();
            this.btGuardar = new System.Windows.Forms.Button();
            this.lblDato = new System.Windows.Forms.Label();
            this.btSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Location = new System.Drawing.Point(56, 31);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNombre.TabIndex = 0;
            this.txtBoxNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtBoxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxNombre_KeyPress);
            // 
            // txtBoxNdni
            // 
            this.txtBoxNdni.Location = new System.Drawing.Point(56, 75);
            this.txtBoxNdni.Name = "txtBoxNdni";
            this.txtBoxNdni.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNdni.TabIndex = 1;
            this.txtBoxNdni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxNdni_KeyPress);
            // 
            // txtBoxCuil
            // 
            this.txtBoxCuil.Location = new System.Drawing.Point(53, 128);
            this.txtBoxCuil.Name = "txtBoxCuil";
            this.txtBoxCuil.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCuil.TabIndex = 3;
            this.txtBoxCuil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxCuil_KeyPress);
            // 
            // cbSexo
            // 
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "F",
            "M"});
            this.cbSexo.Location = new System.Drawing.Point(53, 168);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(121, 21);
            this.cbSexo.TabIndex = 4;
            // 
            // cbTdni
            // 
            this.cbTdni.FormattingEnabled = true;
            this.cbTdni.Items.AddRange(new object[] {
            "Dni",
            "Pasaporte",
            "Extranjero",
            "Cedula"});
            this.cbTdni.Location = new System.Drawing.Point(53, 209);
            this.cbTdni.Name = "cbTdni";
            this.cbTdni.Size = new System.Drawing.Size(121, 21);
            this.cbTdni.TabIndex = 5;
            // 
            // dtFechaNac
            // 
            this.dtFechaNac.Location = new System.Drawing.Point(53, 257);
            this.dtFechaNac.Name = "dtFechaNac";
            this.dtFechaNac.Size = new System.Drawing.Size(200, 20);
            this.dtFechaNac.TabIndex = 6;
            this.dtFechaNac.ValueChanged += new System.EventHandler(this.dtFechaNac_ValueChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(56, 12);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(56, 56);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(51, 13);
            this.lblDni.TabIndex = 8;
            this.lblDni.Text = "Num. Dni";
            // 
            // lblCuil
            // 
            this.lblCuil.AutoSize = true;
            this.lblCuil.Location = new System.Drawing.Point(53, 109);
            this.lblCuil.Name = "lblCuil";
            this.lblCuil.Size = new System.Drawing.Size(47, 13);
            this.lblCuil.TabIndex = 10;
            this.lblCuil.Text = "Cuil/Cuit";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(56, 150);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(31, 13);
            this.lblSexo.TabIndex = 11;
            this.lblSexo.Text = "Sexo";
            // 
            // lblTdni
            // 
            this.lblTdni.AutoSize = true;
            this.lblTdni.Location = new System.Drawing.Point(56, 191);
            this.lblTdni.Name = "lblTdni";
            this.lblTdni.Size = new System.Drawing.Size(47, 13);
            this.lblTdni.TabIndex = 12;
            this.lblTdni.Text = "Tipo Dni";
            // 
            // lblNacimiento
            // 
            this.lblNacimiento.AutoSize = true;
            this.lblNacimiento.Location = new System.Drawing.Point(56, 237);
            this.lblNacimiento.Name = "lblNacimiento";
            this.lblNacimiento.Size = new System.Drawing.Size(93, 13);
            this.lblNacimiento.TabIndex = 13;
            this.lblNacimiento.Text = "Fecha Nacimiento";
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(49, 340);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(75, 23);
            this.btGuardar.TabIndex = 14;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // lblDato
            // 
            this.lblDato.AutoSize = true;
            this.lblDato.Location = new System.Drawing.Point(12, 389);
            this.lblDato.Name = "lblDato";
            this.lblDato.Size = new System.Drawing.Size(33, 13);
            this.lblDato.TabIndex = 15;
            this.lblDato.Text = "Dato:";
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(192, 340);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(75, 23);
            this.btSalir.TabIndex = 16;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // FormPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 428);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.lblDato);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.lblNacimiento);
            this.Controls.Add(this.lblTdni);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblCuil);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.dtFechaNac);
            this.Controls.Add(this.cbTdni);
            this.Controls.Add(this.cbSexo);
            this.Controls.Add(this.txtBoxCuil);
            this.Controls.Add(this.txtBoxNdni);
            this.Controls.Add(this.txtBoxNombre);
            this.Name = "FormPersona";
            this.Text = "FormPersona";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.TextBox txtBoxCuil;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.ComboBox cbTdni;
        private System.Windows.Forms.DateTimePicker dtFechaNac;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblCuil;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblTdni;
        private System.Windows.Forms.Label lblNacimiento;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Label lblDato;
        private System.Windows.Forms.Button btSalir;
        public System.Windows.Forms.TextBox txtBoxNdni;
    }
}