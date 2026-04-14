namespace pryEDAybarM
{
    partial class frmEstrctDatoLineal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstCola = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblListado = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTramite = new System.Windows.Forms.Label();
            this.lblCodigo2 = new System.Windows.Forms.Label();
            this.lblNombre2 = new System.Windows.Forms.Label();
            this.lblTramite2 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblCodigoM = new System.Windows.Forms.Label();
            this.lblNombreM = new System.Windows.Forms.Label();
            this.lblTramiteM = new System.Windows.Forms.Label();
            this.lblCodigoM2 = new System.Windows.Forms.Label();
            this.llbNombreM2 = new System.Windows.Forms.Label();
            this.lblTramiteM2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCola)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgCola
            // 
            this.dvgCola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCola.Location = new System.Drawing.Point(374, 310);
            this.dvgCola.Name = "dvgCola";
            this.dvgCola.Size = new System.Drawing.Size(481, 180);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTramiteM);
            this.groupBox1.Controls.Add(this.lblNombreM);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.lblCodigoM);
            this.groupBox1.Controls.Add(this.lblTramite);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.lblCodigo);
            this.groupBox1.Location = new System.Drawing.Point(449, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 217);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nuevo Elemento :";
            // 
            // lstCola
            // 
            this.lstCola.HideSelection = false;
            this.lstCola.Location = new System.Drawing.Point(30, 310);
            this.lstCola.Name = "lstCola";
            this.lstCola.Size = new System.Drawing.Size(338, 180);
            this.lstCola.TabIndex = 5;
            this.lstCola.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTramiteM2);
            this.groupBox2.Controls.Add(this.llbNombreM2);
            this.groupBox2.Controls.Add(this.lblCodigoM2);
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.lblTramite2);
            this.groupBox2.Controls.Add(this.lblNombre2);
            this.groupBox2.Controls.Add(this.lblCodigo2);
            this.groupBox2.Location = new System.Drawing.Point(655, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 218);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Elemento Eliminado:";
            // 
            // lblListado
            // 
            this.lblListado.AutoSize = true;
            this.lblListado.Location = new System.Drawing.Point(36, 294);
            this.lblListado.Name = "lblListado";
            this.lblListado.Size = new System.Drawing.Size(139, 13);
            this.lblListado.TabIndex = 6;
            this.lblListado.Text = "Listado en un lista y un grilla";
            this.lblListado.Click += new System.EventHandler(this.lblListado_Click);
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
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Location = new System.Drawing.Point(22, 105);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(45, 13);
            this.lblTramite.TabIndex = 4;
            this.lblTramite.Text = "Tramite:";
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
            // lblNombre2
            // 
            this.lblNombre2.AutoSize = true;
            this.lblNombre2.Location = new System.Drawing.Point(19, 68);
            this.lblNombre2.Name = "lblNombre2";
            this.lblNombre2.Size = new System.Drawing.Size(47, 13);
            this.lblNombre2.TabIndex = 6;
            this.lblNombre2.Text = "Nombre:";
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
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(25, 179);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(161, 32);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(22, 180);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(162, 32);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // lblCodigoM
            // 
            this.lblCodigoM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCodigoM.Location = new System.Drawing.Point(86, 32);
            this.lblCodigoM.Name = "lblCodigoM";
            this.lblCodigoM.Size = new System.Drawing.Size(108, 25);
            this.lblCodigoM.TabIndex = 7;
            this.lblCodigoM.Text = "label1";
            // 
            // lblNombreM
            // 
            this.lblNombreM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombreM.Location = new System.Drawing.Point(86, 67);
            this.lblNombreM.Name = "lblNombreM";
            this.lblNombreM.Size = new System.Drawing.Size(108, 25);
            this.lblNombreM.TabIndex = 8;
            this.lblNombreM.Text = "label2";
            // 
            // lblTramiteM
            // 
            this.lblTramiteM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTramiteM.Location = new System.Drawing.Point(86, 104);
            this.lblTramiteM.Name = "lblTramiteM";
            this.lblTramiteM.Size = new System.Drawing.Size(108, 25);
            this.lblTramiteM.TabIndex = 9;
            this.lblTramiteM.Text = "label3";
            // 
            // lblCodigoM2
            // 
            this.lblCodigoM2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCodigoM2.Location = new System.Drawing.Point(86, 33);
            this.lblCodigoM2.Name = "lblCodigoM2";
            this.lblCodigoM2.Size = new System.Drawing.Size(108, 25);
            this.lblCodigoM2.TabIndex = 10;
            this.lblCodigoM2.Text = "label4";
            // 
            // llbNombreM2
            // 
            this.llbNombreM2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.llbNombreM2.Location = new System.Drawing.Point(86, 68);
            this.llbNombreM2.Name = "llbNombreM2";
            this.llbNombreM2.Size = new System.Drawing.Size(108, 25);
            this.llbNombreM2.TabIndex = 11;
            this.llbNombreM2.Text = "label5";
            // 
            // lblTramiteM2
            // 
            this.lblTramiteM2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTramiteM2.Location = new System.Drawing.Point(86, 106);
            this.lblTramiteM2.Name = "lblTramiteM2";
            this.lblTramiteM2.Size = new System.Drawing.Size(108, 25);
            this.lblTramiteM2.TabIndex = 12;
            this.lblTramiteM2.Text = "label6";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pryEDAybarM.Properties.Resources.cola_3;
            this.pictureBox1.Location = new System.Drawing.Point(15, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(411, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // frmEstrctDatoLineal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 502);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblListado);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lstCola);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dvgCola);
            this.Name = "frmEstrctDatoLineal";
            this.Text = "frmEstrctDatoLineal";
            ((System.ComponentModel.ISupportInitialize)(this.dvgCola)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dvgCola;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ListView lstCola;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblTramite2;
        private System.Windows.Forms.Label lblNombre2;
        private System.Windows.Forms.Label lblCodigo2;
        private System.Windows.Forms.Label lblListado;
        private System.Windows.Forms.Label lblCodigoM;
        private System.Windows.Forms.Label lblTramiteM;
        private System.Windows.Forms.Label lblNombreM;
        private System.Windows.Forms.Label lblTramiteM2;
        private System.Windows.Forms.Label llbNombreM2;
        private System.Windows.Forms.Label lblCodigoM2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}