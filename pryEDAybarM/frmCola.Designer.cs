namespace pryEDAybarM
{
    partial class frmCola
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
            this.dvgCola = new System.Windows.Forms.DataGridView();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.grbNuevo = new System.Windows.Forms.GroupBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblTramite = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.grbEliminar = new System.Windows.Forms.GroupBox();
            this.lblTramiteM = new System.Windows.Forms.Label();
            this.lblNombreM = new System.Windows.Forms.Label();
            this.lblCodigoM = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblTramite2 = new System.Windows.Forms.Label();
            this.lblNombre2 = new System.Windows.Forms.Label();
            this.lblCodigo2 = new System.Windows.Forms.Label();
            this.pcb1 = new System.Windows.Forms.PictureBox();
            this.lstCola = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCola)).BeginInit();
            this.grbNuevo.SuspendLayout();
            this.grbEliminar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb1)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgCola
            // 
            this.dvgCola.AllowUserToOrderColumns = true;
            this.dvgCola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCola.Location = new System.Drawing.Point(443, 273);
            this.dvgCola.Name = "dvgCola";
            this.dvgCola.Size = new System.Drawing.Size(406, 217);
            this.dvgCola.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(22, 33);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "Codigo:";
            // 
            // grbNuevo
            // 
            this.grbNuevo.Controls.Add(this.txtNombre);
            this.grbNuevo.Controls.Add(this.txtTramite);
            this.grbNuevo.Controls.Add(this.txtCodigo);
            this.grbNuevo.Controls.Add(this.btnAgregar);
            this.grbNuevo.Controls.Add(this.lblTramite);
            this.grbNuevo.Controls.Add(this.lblNombre);
            this.grbNuevo.Controls.Add(this.lblCodigo);
            this.grbNuevo.Location = new System.Drawing.Point(449, 25);
            this.grbNuevo.Name = "grbNuevo";
            this.grbNuevo.Size = new System.Drawing.Size(200, 217);
            this.grbNuevo.TabIndex = 4;
            this.grbNuevo.TabStop = false;
            this.grbNuevo.Text = "Nuevo Elemento :";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(89, 67);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 8;
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(89, 102);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(100, 20);
            this.txtTramite.TabIndex = 7;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(89, 33);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 6;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(25, 179);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(161, 32);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Location = new System.Drawing.Point(22, 105);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(45, 13);
            this.lblTramite.TabIndex = 4;
            this.lblTramite.Text = "Tramite:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(22, 67);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre:";
            // 
            // grbEliminar
            // 
            this.grbEliminar.Controls.Add(this.lblTramiteM);
            this.grbEliminar.Controls.Add(this.lblNombreM);
            this.grbEliminar.Controls.Add(this.lblCodigoM);
            this.grbEliminar.Controls.Add(this.btnEliminar);
            this.grbEliminar.Controls.Add(this.lblTramite2);
            this.grbEliminar.Controls.Add(this.lblNombre2);
            this.grbEliminar.Controls.Add(this.lblCodigo2);
            this.grbEliminar.Location = new System.Drawing.Point(655, 24);
            this.grbEliminar.Name = "grbEliminar";
            this.grbEliminar.Size = new System.Drawing.Size(200, 218);
            this.grbEliminar.TabIndex = 5;
            this.grbEliminar.TabStop = false;
            this.grbEliminar.Text = "Elemento Eliminado:";
            // 
            // lblTramiteM
            // 
            this.lblTramiteM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTramiteM.Location = new System.Drawing.Point(86, 106);
            this.lblTramiteM.Name = "lblTramiteM";
            this.lblTramiteM.Size = new System.Drawing.Size(108, 25);
            this.lblTramiteM.TabIndex = 12;
            // 
            // lblNombreM
            // 
            this.lblNombreM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombreM.Location = new System.Drawing.Point(86, 68);
            this.lblNombreM.Name = "lblNombreM";
            this.lblNombreM.Size = new System.Drawing.Size(108, 25);
            this.lblNombreM.TabIndex = 11;
            // 
            // lblCodigoM
            // 
            this.lblCodigoM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCodigoM.Location = new System.Drawing.Point(86, 33);
            this.lblCodigoM.Name = "lblCodigoM";
            this.lblCodigoM.Size = new System.Drawing.Size(108, 25);
            this.lblCodigoM.TabIndex = 10;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(22, 180);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(162, 32);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // lblTramite2
            // 
            this.lblTramite2.AutoSize = true;
            this.lblTramite2.Location = new System.Drawing.Point(19, 106);
            this.lblTramite2.Name = "lblTramite2";
            this.lblTramite2.Size = new System.Drawing.Size(45, 13);
            this.lblTramite2.TabIndex = 7;
            this.lblTramite2.Text = "Tramite:";
            // 
            // lblNombre2
            // 
            this.lblNombre2.AutoSize = true;
            this.lblNombre2.Location = new System.Drawing.Point(19, 68);
            this.lblNombre2.Name = "lblNombre2";
            this.lblNombre2.Size = new System.Drawing.Size(47, 13);
            this.lblNombre2.TabIndex = 6;
            this.lblNombre2.Text = "Nombre:";
            // 
            // lblCodigo2
            // 
            this.lblCodigo2.AutoSize = true;
            this.lblCodigo2.Location = new System.Drawing.Point(19, 34);
            this.lblCodigo2.Name = "lblCodigo2";
            this.lblCodigo2.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo2.TabIndex = 5;
            this.lblCodigo2.Text = "Codigo:";
            // 
            // pcb1
            // 
            this.pcb1.Image = global::pryEDAybarM.Properties.Resources.cola_3;
            this.pcb1.Location = new System.Drawing.Point(15, 33);
            this.pcb1.Name = "pcb1";
            this.pcb1.Size = new System.Drawing.Size(411, 209);
            this.pcb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb1.TabIndex = 7;
            this.pcb1.TabStop = false;
            // 
            // lstCola
            // 
            this.lstCola.FormattingEnabled = true;
            this.lstCola.Location = new System.Drawing.Point(25, 273);
            this.lstCola.Name = "lstCola";
            this.lstCola.Size = new System.Drawing.Size(401, 212);
            this.lstCola.TabIndex = 8;
            // 
            // frmCola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 502);
            this.Controls.Add(this.lstCola);
            this.Controls.Add(this.pcb1);
            this.Controls.Add(this.grbEliminar);
            this.Controls.Add(this.grbNuevo);
            this.Controls.Add(this.dvgCola);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmCola";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estrucutra Dinamica Lieal -Cola";
            this.Load += new System.EventHandler(this.frmCola_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgCola)).EndInit();
            this.grbNuevo.ResumeLayout(false);
            this.grbNuevo.PerformLayout();
            this.grbEliminar.ResumeLayout(false);
            this.grbEliminar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dvgCola;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.GroupBox grbNuevo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox grbEliminar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblTramite2;
        private System.Windows.Forms.Label lblNombre2;
        private System.Windows.Forms.Label lblCodigo2;
        private System.Windows.Forms.Label lblTramiteM;
        private System.Windows.Forms.Label lblNombreM;
        private System.Windows.Forms.Label lblCodigoM;
        private System.Windows.Forms.PictureBox pcb1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ListBox lstCola;
    }
}