namespace pryEDAybarM
{
    partial class frmListaDoble
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
            this.lstListaDoble = new System.Windows.Forms.ListBox();
            this.pcb1 = new System.Windows.Forms.PictureBox();
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
            this.dvgListaDoble = new System.Windows.Forms.DataGridView();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.rdbAscendentes = new System.Windows.Forms.RadioButton();
            this.rdbDescendentes = new System.Windows.Forms.RadioButton();
            this.cmbCodigo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcb1)).BeginInit();
            this.grbEliminar.SuspendLayout();
            this.grbNuevo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgListaDoble)).BeginInit();
            this.grpDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstListaDoble
            // 
            this.lstListaDoble.FormattingEnabled = true;
            this.lstListaDoble.Location = new System.Drawing.Point(34, 272);
            this.lstListaDoble.Name = "lstListaDoble";
            this.lstListaDoble.Size = new System.Drawing.Size(411, 212);
            this.lstListaDoble.TabIndex = 18;
            // 
            // pcb1
            // 
            this.pcb1.Image = global::pryEDAybarM.Properties.Resources.maxresdefault;
            this.pcb1.Location = new System.Drawing.Point(34, 32);
            this.pcb1.Name = "pcb1";
            this.pcb1.Size = new System.Drawing.Size(411, 209);
            this.pcb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb1.TabIndex = 17;
            this.pcb1.TabStop = false;
            // 
            // grbEliminar
            // 
            this.grbEliminar.Controls.Add(this.cmbCodigo);
            this.grbEliminar.Controls.Add(this.btnEliminar);
            this.grbEliminar.Controls.Add(this.lblCodigo2);
            this.grbEliminar.Location = new System.Drawing.Point(674, 23);
            this.grbEliminar.Name = "grbEliminar";
            this.grbEliminar.Size = new System.Drawing.Size(200, 119);
            this.grbEliminar.TabIndex = 16;
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
            this.grbNuevo.Location = new System.Drawing.Point(468, 24);
            this.grbNuevo.Name = "grbNuevo";
            this.grbNuevo.Size = new System.Drawing.Size(200, 217);
            this.grbNuevo.TabIndex = 15;
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
            // dvgListaDoble
            // 
            this.dvgListaDoble.AllowUserToOrderColumns = true;
            this.dvgListaDoble.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgListaDoble.Location = new System.Drawing.Point(462, 272);
            this.dvgListaDoble.Name = "dvgListaDoble";
            this.dvgListaDoble.Size = new System.Drawing.Size(406, 217);
            this.dvgListaDoble.TabIndex = 14;
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.rdbAscendentes);
            this.grpDatos.Controls.Add(this.rdbDescendentes);
            this.grpDatos.Location = new System.Drawing.Point(674, 148);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(200, 93);
            this.grpDatos.TabIndex = 17;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Listar Datos";
            this.grpDatos.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdbAscendentes
            // 
            this.rdbAscendentes.AutoSize = true;
            this.rdbAscendentes.Location = new System.Drawing.Point(9, 63);
            this.rdbAscendentes.Name = "rdbAscendentes";
            this.rdbAscendentes.Size = new System.Drawing.Size(87, 17);
            this.rdbAscendentes.TabIndex = 1;
            this.rdbAscendentes.TabStop = true;
            this.rdbAscendentes.Text = "Ascendentes";
            this.rdbAscendentes.UseVisualStyleBackColor = true;
            // 
            // rdbDescendentes
            // 
            this.rdbDescendentes.AutoSize = true;
            this.rdbDescendentes.Location = new System.Drawing.Point(9, 30);
            this.rdbDescendentes.Name = "rdbDescendentes";
            this.rdbDescendentes.Size = new System.Drawing.Size(94, 17);
            this.rdbDescendentes.TabIndex = 0;
            this.rdbDescendentes.TabStop = true;
            this.rdbDescendentes.Text = "Descendentes";
            this.rdbDescendentes.UseVisualStyleBackColor = true;
            // 
            // cmbCodigo
            // 
            this.cmbCodigo.FormattingEnabled = true;
            this.cmbCodigo.Location = new System.Drawing.Point(55, 31);
            this.cmbCodigo.Name = "cmbCodigo";
            this.cmbCodigo.Size = new System.Drawing.Size(139, 21);
            this.cmbCodigo.TabIndex = 7;
            // 
            // frmListaDoble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 512);
            this.Controls.Add(this.grpDatos);
            this.Controls.Add(this.lstListaDoble);
            this.Controls.Add(this.pcb1);
            this.Controls.Add(this.grbEliminar);
            this.Controls.Add(this.grbNuevo);
            this.Controls.Add(this.dvgListaDoble);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmListaDoble";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructura - Lista Doblemente Enlazada";
            ((System.ComponentModel.ISupportInitialize)(this.pcb1)).EndInit();
            this.grbEliminar.ResumeLayout(false);
            this.grbEliminar.PerformLayout();
            this.grbNuevo.ResumeLayout(false);
            this.grbNuevo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgListaDoble)).EndInit();
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstListaDoble;
        private System.Windows.Forms.PictureBox pcb1;
        private System.Windows.Forms.GroupBox grbEliminar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox grbNuevo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.DataGridView dvgListaDoble;
        private System.Windows.Forms.Label lblCodigo2;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.RadioButton rdbAscendentes;
        private System.Windows.Forms.RadioButton rdbDescendentes;
        private System.Windows.Forms.ComboBox cmbCodigo;
    }
}