namespace Presentacion
{
    partial class FormTarjeta
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
            this.btGrabar = new System.Windows.Forms.Button();
            this.txtNtarjeta = new System.Windows.Forms.TextBox();
            this.txtDtarjeta = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.dgvTarjeta = new System.Windows.Forms.DataGridView();
            this.btAgregarPers = new System.Windows.Forms.Button();
            this.lblNtarjeta = new System.Windows.Forms.Label();
            this.lblDtarjeta = new System.Windows.Forms.Label();
            this.lblStarjeta = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btSumar = new System.Windows.Forms.Button();
            this.btRestar = new System.Windows.Forms.Button();
            this.txtBoxMonto = new System.Windows.Forms.TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarjeta)).BeginInit();
            this.SuspendLayout();
            // 
            // btGrabar
            // 
            this.btGrabar.Location = new System.Drawing.Point(133, 47);
            this.btGrabar.Name = "btGrabar";
            this.btGrabar.Size = new System.Drawing.Size(75, 23);
            this.btGrabar.TabIndex = 0;
            this.btGrabar.Text = "Grabar";
            this.btGrabar.UseVisualStyleBackColor = true;
            this.btGrabar.Click += new System.EventHandler(this.btGrabar_Click);
            // 
            // txtNtarjeta
            // 
            this.txtNtarjeta.Location = new System.Drawing.Point(15, 32);
            this.txtNtarjeta.Name = "txtNtarjeta";
            this.txtNtarjeta.Size = new System.Drawing.Size(100, 20);
            this.txtNtarjeta.TabIndex = 2;
            this.txtNtarjeta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNtarjeta_KeyPress);
            // 
            // txtDtarjeta
            // 
            this.txtDtarjeta.Location = new System.Drawing.Point(15, 75);
            this.txtDtarjeta.Name = "txtDtarjeta";
            this.txtDtarjeta.Size = new System.Drawing.Size(100, 20);
            this.txtDtarjeta.TabIndex = 3;
            this.txtDtarjeta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDtarjeta_KeyPress);
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(15, 121);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(100, 20);
            this.txtSaldo.TabIndex = 4;
            this.txtSaldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSaldo_KeyPress);
            // 
            // dgvTarjeta
            // 
            this.dgvTarjeta.AllowUserToAddRows = false;
            this.dgvTarjeta.AllowUserToDeleteRows = false;
            this.dgvTarjeta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarjeta.Location = new System.Drawing.Point(45, 172);
            this.dgvTarjeta.Name = "dgvTarjeta";
            this.dgvTarjeta.ReadOnly = true;
            this.dgvTarjeta.Size = new System.Drawing.Size(311, 193);
            this.dgvTarjeta.TabIndex = 5;
            this.dgvTarjeta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTarjeta_CellContentClick);
            // 
            // btAgregarPers
            // 
            this.btAgregarPers.Location = new System.Drawing.Point(45, 392);
            this.btAgregarPers.Name = "btAgregarPers";
            this.btAgregarPers.Size = new System.Drawing.Size(98, 32);
            this.btAgregarPers.TabIndex = 6;
            this.btAgregarPers.Text = "Agregar persona";
            this.btAgregarPers.UseVisualStyleBackColor = true;
            this.btAgregarPers.Click += new System.EventHandler(this.btAgregarPers_Click);
            // 
            // lblNtarjeta
            // 
            this.lblNtarjeta.AutoSize = true;
            this.lblNtarjeta.Location = new System.Drawing.Point(12, 16);
            this.lblNtarjeta.Name = "lblNtarjeta";
            this.lblNtarjeta.Size = new System.Drawing.Size(63, 13);
            this.lblNtarjeta.TabIndex = 7;
            this.lblNtarjeta.Text = "Nro. Tarjeta";
            // 
            // lblDtarjeta
            // 
            this.lblDtarjeta.AutoSize = true;
            this.lblDtarjeta.Location = new System.Drawing.Point(12, 57);
            this.lblDtarjeta.Name = "lblDtarjeta";
            this.lblDtarjeta.Size = new System.Drawing.Size(62, 13);
            this.lblDtarjeta.TabIndex = 8;
            this.lblDtarjeta.Text = "Dni. Tarjeta";
            // 
            // lblStarjeta
            // 
            this.lblStarjeta.AutoSize = true;
            this.lblStarjeta.Location = new System.Drawing.Point(12, 103);
            this.lblStarjeta.Name = "lblStarjeta";
            this.lblStarjeta.Size = new System.Drawing.Size(34, 13);
            this.lblStarjeta.TabIndex = 9;
            this.lblStarjeta.Text = "Saldo";
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(178, 402);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(13, 13);
            this.lblMensaje.TabIndex = 10;
            this.lblMensaje.Text = "--";
            // 
            // btSumar
            // 
            this.btSumar.Location = new System.Drawing.Point(284, 16);
            this.btSumar.Name = "btSumar";
            this.btSumar.Size = new System.Drawing.Size(75, 23);
            this.btSumar.TabIndex = 11;
            this.btSumar.Text = "Aumentar";
            this.btSumar.UseVisualStyleBackColor = true;
            this.btSumar.Click += new System.EventHandler(this.btSumar_Click);
            // 
            // btRestar
            // 
            this.btRestar.Location = new System.Drawing.Point(284, 57);
            this.btRestar.Name = "btRestar";
            this.btRestar.Size = new System.Drawing.Size(75, 23);
            this.btRestar.TabIndex = 12;
            this.btRestar.Text = "Descontar";
            this.btRestar.UseVisualStyleBackColor = true;
            this.btRestar.Click += new System.EventHandler(this.btRestar_Click);
            // 
            // txtBoxMonto
            // 
            this.txtBoxMonto.Location = new System.Drawing.Point(284, 103);
            this.txtBoxMonto.Name = "txtBoxMonto";
            this.txtBoxMonto.Size = new System.Drawing.Size(100, 20);
            this.txtBoxMonto.TabIndex = 13;
            this.txtBoxMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxMonto_KeyPress);
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(284, 84);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(37, 13);
            this.lblMonto.TabIndex = 14;
            this.lblMonto.Text = "Monto";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(13, 148);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(10, 13);
            this.lblNombre.TabIndex = 15;
            this.lblNombre.Text = "-";
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(133, 148);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(10, 13);
            this.lblEdad.TabIndex = 16;
            this.lblEdad.Text = "-";
            // 
            // FormTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 471);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.txtBoxMonto);
            this.Controls.Add(this.btRestar);
            this.Controls.Add(this.btSumar);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.lblStarjeta);
            this.Controls.Add(this.lblDtarjeta);
            this.Controls.Add(this.lblNtarjeta);
            this.Controls.Add(this.btAgregarPers);
            this.Controls.Add(this.dgvTarjeta);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.txtDtarjeta);
            this.Controls.Add(this.txtNtarjeta);
            this.Controls.Add(this.btGrabar);
            this.Name = "FormTarjeta";
            this.Text = "FormTarjeta";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarjeta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btGrabar;
        private System.Windows.Forms.TextBox txtNtarjeta;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.DataGridView dgvTarjeta;
        private System.Windows.Forms.Button btAgregarPers;
        private System.Windows.Forms.Label lblNtarjeta;
        private System.Windows.Forms.Label lblDtarjeta;
        private System.Windows.Forms.Label lblStarjeta;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btSumar;
        private System.Windows.Forms.Button btRestar;
        private System.Windows.Forms.TextBox txtBoxMonto;
        private System.Windows.Forms.Label lblMonto;
        public System.Windows.Forms.TextBox txtDtarjeta;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEdad;
    }
}