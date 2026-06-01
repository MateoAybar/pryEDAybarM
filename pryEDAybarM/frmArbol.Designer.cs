namespace pryEDAybarM
{
    partial class frmArbol
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
            this.grbListado = new System.Windows.Forms.GroupBox();
            this.rdbpreorden = new System.Windows.Forms.RadioButton();
            this.rdbInorden = new System.Windows.Forms.RadioButton();
            this.grbEliminar = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblCodigo2 = new System.Windows.Forms.Label();
            this.grbNuevo = new System.Windows.Forms.GroupBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblTramite = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.dvgArbol = new System.Windows.Forms.DataGridView();
            this.cmbCodigo = new System.Windows.Forms.ComboBox();
            this.btnEquilibrar = new System.Windows.Forms.Button();
            this.rdbpPostorden = new System.Windows.Forms.RadioButton();
            this.trvArbol = new System.Windows.Forms.TreeView();
            this.grbListado.SuspendLayout();
            this.grbEliminar.SuspendLayout();
            this.grbNuevo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgArbol)).BeginInit();
            this.SuspendLayout();
            // 
            // grbListado
            // 
            this.grbListado.Controls.Add(this.rdbpPostorden);
            this.grbListado.Controls.Add(this.rdbpreorden);
            this.grbListado.Controls.Add(this.rdbInorden);
            this.grbListado.Controls.Add(this.dvgArbol);
            this.grbListado.Location = new System.Drawing.Point(12, 262);
            this.grbListado.Name = "grbListado";
            this.grbListado.Size = new System.Drawing.Size(641, 217);
            this.grbListado.TabIndex = 22;
            this.grbListado.TabStop = false;
            this.grbListado.Text = "Listado del Árbol";
            // 
            // rdbpreorden
            // 
            this.rdbpreorden.AutoSize = true;
            this.rdbpreorden.Location = new System.Drawing.Point(37, 92);
            this.rdbpreorden.Name = "rdbpreorden";
            this.rdbpreorden.Size = new System.Drawing.Size(73, 17);
            this.rdbpreorden.TabIndex = 1;
            this.rdbpreorden.TabStop = true;
            this.rdbpreorden.Text = "Pre-Orden";
            this.rdbpreorden.UseVisualStyleBackColor = true;
            // 
            // rdbInorden
            // 
            this.rdbInorden.AutoSize = true;
            this.rdbInorden.Location = new System.Drawing.Point(37, 30);
            this.rdbInorden.Name = "rdbInorden";
            this.rdbInorden.Size = new System.Drawing.Size(66, 17);
            this.rdbInorden.TabIndex = 0;
            this.rdbInorden.TabStop = true;
            this.rdbInorden.Text = "In-Orden";
            this.rdbInorden.UseVisualStyleBackColor = true;
            // 
            // grbEliminar
            // 
            this.grbEliminar.Controls.Add(this.cmbCodigo);
            this.grbEliminar.Controls.Add(this.btnEliminar);
            this.grbEliminar.Controls.Add(this.lblCodigo2);
            this.grbEliminar.Location = new System.Drawing.Point(459, 22);
            this.grbEliminar.Name = "grbEliminar";
            this.grbEliminar.Size = new System.Drawing.Size(200, 115);
            this.grbEliminar.TabIndex = 21;
            this.grbEliminar.TabStop = false;
            this.grbEliminar.Text = "Elemento A Eliminar:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(9, 70);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(185, 32);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // lblCodigo2
            // 
            this.lblCodigo2.AutoSize = true;
            this.lblCodigo2.Location = new System.Drawing.Point(6, 34);
            this.lblCodigo2.Name = "lblCodigo2";
            this.lblCodigo2.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo2.TabIndex = 5;
            this.lblCodigo2.Text = "Codigo:";
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
            this.grbNuevo.Location = new System.Drawing.Point(253, 19);
            this.grbNuevo.Name = "grbNuevo";
            this.grbNuevo.Size = new System.Drawing.Size(200, 217);
            this.grbNuevo.TabIndex = 20;
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
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(22, 33);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "Codigo:";
            // 
            // dvgArbol
            // 
            this.dvgArbol.AllowUserToOrderColumns = true;
            this.dvgArbol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgArbol.Location = new System.Drawing.Point(241, 19);
            this.dvgArbol.Name = "dvgArbol";
            this.dvgArbol.Size = new System.Drawing.Size(393, 185);
            this.dvgArbol.TabIndex = 19;
            // 
            // cmbCodigo
            // 
            this.cmbCodigo.FormattingEnabled = true;
            this.cmbCodigo.Location = new System.Drawing.Point(73, 31);
            this.cmbCodigo.Name = "cmbCodigo";
            this.cmbCodigo.Size = new System.Drawing.Size(121, 21);
            this.cmbCodigo.TabIndex = 7;
            // 
            // btnEquilibrar
            // 
            this.btnEquilibrar.Location = new System.Drawing.Point(468, 198);
            this.btnEquilibrar.Name = "btnEquilibrar";
            this.btnEquilibrar.Size = new System.Drawing.Size(185, 32);
            this.btnEquilibrar.TabIndex = 8;
            this.btnEquilibrar.Text = "Equilibrar";
            this.btnEquilibrar.UseVisualStyleBackColor = true;
            // 
            // rdbpPostorden
            // 
            this.rdbpPostorden.AutoSize = true;
            this.rdbpPostorden.Location = new System.Drawing.Point(37, 163);
            this.rdbpPostorden.Name = "rdbpPostorden";
            this.rdbpPostorden.Size = new System.Drawing.Size(78, 17);
            this.rdbpPostorden.TabIndex = 2;
            this.rdbpPostorden.TabStop = true;
            this.rdbpPostorden.Text = "Post-Orden";
            this.rdbpPostorden.UseVisualStyleBackColor = true;
            // 
            // trvArbol
            // 
            this.trvArbol.Location = new System.Drawing.Point(12, 22);
            this.trvArbol.Name = "trvArbol";
            this.trvArbol.Size = new System.Drawing.Size(218, 214);
            this.trvArbol.TabIndex = 25;
            // 
            // frmArbol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 491);
            this.Controls.Add(this.trvArbol);
            this.Controls.Add(this.btnEquilibrar);
            this.Controls.Add(this.grbListado);
            this.Controls.Add(this.grbEliminar);
            this.Controls.Add(this.grbNuevo);
            this.Name = "frmArbol";
            this.Text = "Estructura Ramificada - Arbol";
            this.grbListado.ResumeLayout(false);
            this.grbListado.PerformLayout();
            this.grbEliminar.ResumeLayout(false);
            this.grbEliminar.PerformLayout();
            this.grbNuevo.ResumeLayout(false);
            this.grbNuevo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgArbol)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbListado;
        private System.Windows.Forms.RadioButton rdbpreorden;
        private System.Windows.Forms.RadioButton rdbInorden;
        private System.Windows.Forms.GroupBox grbEliminar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblCodigo2;
        private System.Windows.Forms.GroupBox grbNuevo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.DataGridView dvgArbol;
        private System.Windows.Forms.ComboBox cmbCodigo;
        private System.Windows.Forms.Button btnEquilibrar;
        private System.Windows.Forms.RadioButton rdbpPostorden;
        private System.Windows.Forms.TreeView trvArbol;
    }
}