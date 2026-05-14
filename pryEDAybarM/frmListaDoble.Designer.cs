namespace pryEDAybarM
{

    partial class frmListaDoble

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
        this.pictureBox1 = new System.Windows.Forms.PictureBox();
        this.groupBox3 = new System.Windows.Forms.GroupBox();
        this.btnAgregar = new System.Windows.Forms.Button();
        this.lblTramiteN = new System.Windows.Forms.Label();
        this.txtTramite = new System.Windows.Forms.TextBox();
        this.lblNombreN = new System.Windows.Forms.Label();
        this.txtNombre = new System.Windows.Forms.TextBox();
        this.lblCodigoN = new System.Windows.Forms.Label();
        this.txtCodigo = new System.Windows.Forms.TextBox();
        this.groupBox2 = new System.Windows.Forms.GroupBox();
        this.cmbLista = new System.Windows.Forms.ComboBox();
        this.btnBorrar = new System.Windows.Forms.Button();
        this.label3 = new System.Windows.Forms.Label();
        this.groupBox1 = new System.Windows.Forms.GroupBox();
        this.dgvListaDoble = new System.Windows.Forms.DataGridView();
        this.columCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.columnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.columnTramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.lstListaDoble = new System.Windows.Forms.ListBox();
        this.groupBox4 = new System.Windows.Forms.GroupBox();
        this.rdbDescendente = new System.Windows.Forms.RadioButton();
        this.rdbAscendente = new System.Windows.Forms.RadioButton();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
        this.groupBox3.SuspendLayout();
        this.groupBox2.SuspendLayout();
        this.groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvListaDoble)).BeginInit();
        this.groupBox4.SuspendLayout();
        this.SuspendLayout();
        // 
        // pictureBox1
        // 
        this.pictureBox1.Image = global::pryEDSampaolesiI.Properties.Resources.ListaDoble;
        this.pictureBox1.Location = new System.Drawing.Point(17, 10);
        this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
        this.pictureBox1.Name = "pictureBox1";
        this.pictureBox1.Size = new System.Drawing.Size(259, 213);
        this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        this.pictureBox1.TabIndex = 15;
        this.pictureBox1.TabStop = false;
        // 
        // groupBox3
        // 
        this.groupBox3.Controls.Add(this.btnAgregar);
        this.groupBox3.Controls.Add(this.lblTramiteN);
        this.groupBox3.Controls.Add(this.txtTramite);
        this.groupBox3.Controls.Add(this.lblNombreN);
        this.groupBox3.Controls.Add(this.txtNombre);
        this.groupBox3.Controls.Add(this.lblCodigoN);
        this.groupBox3.Controls.Add(this.txtCodigo);
        this.groupBox3.Location = new System.Drawing.Point(297, 10);
        this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
        this.groupBox3.Name = "groupBox3";
        this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
        this.groupBox3.Size = new System.Drawing.Size(235, 213);
        this.groupBox3.TabIndex = 14;
        this.groupBox3.TabStop = false;
        this.groupBox3.Text = "Nuevo Elemento";
        // 
        // btnAgregar
        // 
        this.btnAgregar.Enabled = false;
        this.btnAgregar.Location = new System.Drawing.Point(32, 153);
        this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
        this.btnAgregar.Name = "btnAgregar";
        this.btnAgregar.Size = new System.Drawing.Size(173, 39);
        this.btnAgregar.TabIndex = 6;
        this.btnAgregar.Text = "Agregar";
        this.btnAgregar.UseVisualStyleBackColor = true;
        this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
        // 
        // lblTramiteN
        // 
        this.lblTramiteN.AutoSize = true;
        this.lblTramiteN.Location = new System.Drawing.Point(8, 124);
        this.lblTramiteN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        this.lblTramiteN.Name = "lblTramiteN";
        this.lblTramiteN.Size = new System.Drawing.Size(56, 16);
        this.lblTramiteN.TabIndex = 5;
        this.lblTramiteN.Text = "Tramite:";
        // 
        // txtTramite
        // 
        this.txtTramite.Location = new System.Drawing.Point(93, 121);
        this.txtTramite.Margin = new System.Windows.Forms.Padding(4);
        this.txtTramite.Name = "txtTramite";
        this.txtTramite.Size = new System.Drawing.Size(132, 22);
        this.txtTramite.TabIndex = 4;
        this.txtTramite.TextChanged += new System.EventHandler(this.txtTramite_TextChanged);
        // 
        // lblNombreN
        // 
        this.lblNombreN.AutoSize = true;
        this.lblNombreN.Location = new System.Drawing.Point(8, 84);
        this.lblNombreN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        this.lblNombreN.Name = "lblNombreN";
        this.lblNombreN.Size = new System.Drawing.Size(59, 16);
        this.lblNombreN.TabIndex = 3;
        this.lblNombreN.Text = "Nombre:";
        // 
        // txtNombre
        // 
        this.txtNombre.Location = new System.Drawing.Point(93, 80);
        this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
        this.txtNombre.Name = "txtNombre";
        this.txtNombre.Size = new System.Drawing.Size(132, 22);
        this.txtNombre.TabIndex = 2;
        this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
        // 
        // lblCodigoN
        // 
        this.lblCodigoN.AutoSize = true;
        this.lblCodigoN.Location = new System.Drawing.Point(8, 44);
        this.lblCodigoN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        this.lblCodigoN.Name = "lblCodigoN";
        this.lblCodigoN.Size = new System.Drawing.Size(54, 16);
        this.lblCodigoN.TabIndex = 1;
        this.lblCodigoN.Text = "Codigo:";
        // 
        // txtCodigo
        // 
        this.txtCodigo.Location = new System.Drawing.Point(117, 41);
        this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
        this.txtCodigo.Name = "txtCodigo";
        this.txtCodigo.Size = new System.Drawing.Size(108, 22);
        this.txtCodigo.TabIndex = 0;
        this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
        // 
        // groupBox2
        // 
        this.groupBox2.Controls.Add(this.cmbLista);
        this.groupBox2.Controls.Add(this.btnBorrar);
        this.groupBox2.Controls.Add(this.label3);
        this.groupBox2.Location = new System.Drawing.Point(540, 10);
        this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
        this.groupBox2.Name = "groupBox2";
        this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
        this.groupBox2.Size = new System.Drawing.Size(235, 116);
        this.groupBox2.TabIndex = 13;
        this.groupBox2.TabStop = false;
        this.groupBox2.Text = "Eliminar Elemento";
        // 
        // cmbLista
        // 
        this.cmbLista.FormattingEnabled = true;
        this.cmbLista.Location = new System.Drawing.Point(96, 28);
        this.cmbLista.Margin = new System.Windows.Forms.Padding(4);
        this.cmbLista.Name = "cmbLista";
        this.cmbLista.Size = new System.Drawing.Size(108, 24);
        this.cmbLista.TabIndex = 8;
        this.cmbLista.SelectedIndexChanged += new System.EventHandler(this.cmbLista_SelectedIndexChanged);
        // 
        // btnBorrar
        // 
        this.btnBorrar.Enabled = false;
        this.btnBorrar.Location = new System.Drawing.Point(32, 60);
        this.btnBorrar.Margin = new System.Windows.Forms.Padding(4);
        this.btnBorrar.Name = "btnBorrar";
        this.btnBorrar.Size = new System.Drawing.Size(173, 39);
        this.btnBorrar.TabIndex = 7;
        this.btnBorrar.Text = "Eliminar";
        this.btnBorrar.UseVisualStyleBackColor = true;
        this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Location = new System.Drawing.Point(15, 32);
        this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(54, 16);
        this.label3.TabIndex = 6;
        this.label3.Text = "Codigo:";
        // 
        // groupBox1
        // 
        this.groupBox1.Controls.Add(this.dgvListaDoble);
        this.groupBox1.Controls.Add(this.lstListaDoble);
        this.groupBox1.Location = new System.Drawing.Point(17, 230);
        this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
        this.groupBox1.Size = new System.Drawing.Size(757, 254);
        this.groupBox1.TabIndex = 12;
        this.groupBox1.TabStop = false;
        this.groupBox1.Text = "Listado en Lista y en Grilla";
        // 
        // dgvListaDoble
        // 
            this.dgvListaDoble.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaDoble.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.columCodigo,
                this.columnNombre,
                this.columnTramite});
            this.dgvListaDoble.Location = new System.Drawing.Point(267, 23);
            this.dgvListaDoble.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListaDoble.Name = "dgvListaDoble";
            this.dgvListaDoble.RowHeadersWidth = 51;
            this.dgvListaDoble.Size = new System.Drawing.Size(481, 212);
            this.dgvListaDoble.TabIndex = 1;
            // 
            // columCodigo
            // 
            this.columCodigo.HeaderText = "Codigo";
            this.columCodigo.MinimumWidth = 6;
            this.columCodigo.Name = "columCodigo";
            this.columCodigo.Width = 60;
            // 
            // columnNombre
            // 
            this.columnNombre.HeaderText = "Nombre";
            this.columnNombre.MinimumWidth = 6;
            this.columnNombre.Name = "columnNombre";
            this.columnNombre.Width = 180;
            // 
            // columnTramite
            // 
            this.columnTramite.HeaderText = "Tramite";
            this.columnTramite.MinimumWidth = 6;
            this.columnTramite.Name = "columnTramite";
            this.columnTramite.Width = 75;
            // 
            // lstListaDoble
            // 
            this.lstListaDoble.FormattingEnabled = true;
            this.lstListaDoble.ItemHeight = 16;
            this.lstListaDoble.Location = new System.Drawing.Point(8, 23);
            this.lstListaDoble.Margin = new System.Windows.Forms.Padding(4);
            this.lstListaDoble.Name = "lstListaDoble";
            this.lstListaDoble.Size = new System.Drawing.Size(245, 212);
            this.lstListaDoble.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdbDescendente);
            this.groupBox4.Controls.Add(this.rdbAscendente);
            this.groupBox4.Location = new System.Drawing.Point(541, 130);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(235, 92);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Listar Datos";
            // 
            // rdbDescendente
            // 
            this.rdbDescendente.AutoSize = true;
            this.rdbDescendente.Location = new System.Drawing.Point(17, 52);
            this.rdbDescendente.Margin = new System.Windows.Forms.Padding(4);
            this.rdbDescendente.Name = "rdbDescendente";
            this.rdbDescendente.Size = new System.Drawing.Size(109, 20);
            this.rdbDescendente.TabIndex = 1;
            this.rdbDescendente.TabStop = true;
            this.rdbDescendente.Text = "Descendente";
            this.rdbDescendente.UseVisualStyleBackColor = true;
            this.rdbDescendente.CheckedChanged += new System.EventHandler(this.rdbDescendente_CheckedChanged);
            // 
            // rdbAscendente
            // 
            this.rdbAscendente.AutoSize = true;
            this.rdbAscendente.Location = new System.Drawing.Point(17, 23);
            this.rdbAscendente.Margin = new System.Windows.Forms.Padding(4);
            this.rdbAscendente.Name = "rdbAscendente";
            this.rdbAscendente.Size = new System.Drawing.Size(100, 20);
            this.rdbAscendente.TabIndex = 0;
            this.rdbAscendente.TabStop = true;
            this.rdbAscendente.Text = "Ascendente";
            this.rdbAscendente.UseVisualStyleBackColor = true;
            // 
            // frmListaDoble
            // 
            this.AcceptButton = this.btnAgregar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 492);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmListaDoble";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista Doblemente enlazada";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDoble)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

         #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblTramiteN;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.Label lblNombreN;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblCodigoN;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbLista;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvListaDoble;
        private System.Windows.Forms.DataGridViewTextBoxColumn columCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTramite;
        private System.Windows.Forms.ListBox lstListaDoble;
        private System.Windows.Forms.GroupBox groupBox4;
         private System.Windows.Forms.RadioButton rdbDescendente;
         private System.Windows.Forms.RadioButton rdbAscendente;
    }
