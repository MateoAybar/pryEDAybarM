namespace pryEDAybarM
{
    partial class frmGrafo
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
            this.pnlGrafo = new System.Windows.Forms.Panel();
            this.gbCargaDatos = new System.Windows.Forms.GroupBox();
            this.lblCargaOrigen = new System.Windows.Forms.Label();
            this.cmbCargaOrigen = new System.Windows.Forms.ComboBox();
            this.lblCargaDestino = new System.Windows.Forms.Label();
            this.cmbCargaDestino = new System.Windows.Forms.ComboBox();
            this.lblCargaPrecio = new System.Windows.Forms.Label();
            this.txtCargaPrecio = new System.Windows.Forms.TextBox();
            this.btnBorrarTodo = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.gbConsultaDatos = new System.Windows.Forms.GroupBox();
            this.lblConsultaOrigen = new System.Windows.Forms.Label();
            this.cmbConsultaOrigen = new System.Windows.Forms.ComboBox();
            this.lblConsultaDestino = new System.Windows.Forms.Label();
            this.cmbConsultaDestino = new System.Windows.Forms.ComboBox();
            this.lblConsultaPrecio = new System.Windows.Forms.Label();
            this.txtConsultaPrecio = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.gbListarViajes = new System.Windows.Forms.GroupBox();
            this.lblListarDesde = new System.Windows.Forms.Label();
            this.cmbListarDesde = new System.Windows.Forms.ComboBox();
            this.btnListarDestinos = new System.Windows.Forms.Button();
            this.lblListarHasta = new System.Windows.Forms.Label();
            this.cmbListarHasta = new System.Windows.Forms.ComboBox();
            this.btnListarOrigenes = new System.Windows.Forms.Button();
            this.btnVerTodosViajes = new System.Windows.Forms.Button();
            this.dgvViajes = new System.Windows.Forms.DataGridView();
            this.lblListarViajes = new System.Windows.Forms.Label();
            this.pnlGrafo.SuspendLayout();
            this.gbCargaDatos.SuspendLayout();
            this.gbConsultaDatos.SuspendLayout();
            this.gbListarViajes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViajes)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGrafo
            // 
            this.pnlGrafo.BackColor = System.Drawing.Color.White;
            this.pnlGrafo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGrafo.Location = new System.Drawing.Point(12, 12);
            this.pnlGrafo.Name = "pnlGrafo";
            this.pnlGrafo.Size = new System.Drawing.Size(300, 300);
            this.pnlGrafo.TabIndex = 0;
            this.pnlGrafo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGrafo_Paint);
            // 
            // gbCargaDatos
            // 
            this.gbCargaDatos.Controls.Add(this.lblCargaOrigen);
            this.gbCargaDatos.Controls.Add(this.cmbCargaOrigen);
            this.gbCargaDatos.Controls.Add(this.lblCargaDestino);
            this.gbCargaDatos.Controls.Add(this.cmbCargaDestino);
            this.gbCargaDatos.Controls.Add(this.lblCargaPrecio);
            this.gbCargaDatos.Controls.Add(this.txtCargaPrecio);
            this.gbCargaDatos.Controls.Add(this.btnBorrarTodo);
            this.gbCargaDatos.Controls.Add(this.btnCargar);
            this.gbCargaDatos.Location = new System.Drawing.Point(318, 12);
            this.gbCargaDatos.Name = "gbCargaDatos";
            this.gbCargaDatos.Size = new System.Drawing.Size(350, 150);
            this.gbCargaDatos.TabIndex = 1;
            this.gbCargaDatos.TabStop = false;
            this.gbCargaDatos.Text = "Carga de Datos:";
            // 
            // lblCargaOrigen
            // 
            this.lblCargaOrigen.AutoSize = true;
            this.lblCargaOrigen.Location = new System.Drawing.Point(15, 25);
            this.lblCargaOrigen.Name = "lblCargaOrigen";
            this.lblCargaOrigen.Size = new System.Drawing.Size(41, 13);
            this.lblCargaOrigen.TabIndex = 0;
            this.lblCargaOrigen.Text = "Origen:";
            // 
            // cmbCargaOrigen
            // 
            this.cmbCargaOrigen.FormattingEnabled = true;
            this.cmbCargaOrigen.Items.AddRange(new object[] {
            "Córdoba",
            "Mendoza",
            "Santa Fe",
            "Buenos Aires",
            "Salta"});
            this.cmbCargaOrigen.Location = new System.Drawing.Point(80, 22);
            this.cmbCargaOrigen.Name = "cmbCargaOrigen";
            this.cmbCargaOrigen.Size = new System.Drawing.Size(260, 21);
            this.cmbCargaOrigen.TabIndex = 1;
            this.cmbCargaOrigen.SelectedIndex = 0;
            // 
            // lblCargaDestino
            // 
            this.lblCargaDestino.AutoSize = true;
            this.lblCargaDestino.Location = new System.Drawing.Point(15, 50);
            this.lblCargaDestino.Name = "lblCargaDestino";
            this.lblCargaDestino.Size = new System.Drawing.Size(49, 13);
            this.lblCargaDestino.TabIndex = 2;
            this.lblCargaDestino.Text = "Destino:";
            // 
            // cmbCargaDestino
            // 
            this.cmbCargaDestino.FormattingEnabled = true;
            this.cmbCargaDestino.Items.AddRange(new object[] {
            "Córdoba",
            "Mendoza",
            "Santa Fe",
            "Buenos Aires",
            "Salta"});
            this.cmbCargaDestino.Location = new System.Drawing.Point(80, 47);
            this.cmbCargaDestino.Name = "cmbCargaDestino";
            this.cmbCargaDestino.Size = new System.Drawing.Size(260, 21);
            this.cmbCargaDestino.TabIndex = 3;
            this.cmbCargaDestino.SelectedIndex = 0;
            // 
            // lblCargaPrecio
            // 
            this.lblCargaPrecio.AutoSize = true;
            this.lblCargaPrecio.Location = new System.Drawing.Point(15, 75);
            this.lblCargaPrecio.Name = "lblCargaPrecio";
            this.lblCargaPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblCargaPrecio.TabIndex = 4;
            this.lblCargaPrecio.Text = "Precio:";
            // 
            // txtCargaPrecio
            // 
            this.txtCargaPrecio.Location = new System.Drawing.Point(80, 72);
            this.txtCargaPrecio.Name = "txtCargaPrecio";
            this.txtCargaPrecio.Size = new System.Drawing.Size(260, 20);
            this.txtCargaPrecio.TabIndex = 5;
            // 
            // btnBorrarTodo
            // 
            this.btnBorrarTodo.Location = new System.Drawing.Point(15, 110);
            this.btnBorrarTodo.Name = "btnBorrarTodo";
            this.btnBorrarTodo.Size = new System.Drawing.Size(160, 25);
            this.btnBorrarTodo.TabIndex = 6;
            this.btnBorrarTodo.Text = "Borrar Todo";
            this.btnBorrarTodo.UseVisualStyleBackColor = true;
            this.btnBorrarTodo.Click += new System.EventHandler(this.btnBorrarTodo_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(180, 110);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(160, 25);
            this.btnCargar.TabIndex = 7;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // gbConsultaDatos
            // 
            this.gbConsultaDatos.Controls.Add(this.lblConsultaOrigen);
            this.gbConsultaDatos.Controls.Add(this.cmbConsultaOrigen);
            this.gbConsultaDatos.Controls.Add(this.lblConsultaDestino);
            this.gbConsultaDatos.Controls.Add(this.cmbConsultaDestino);
            this.gbConsultaDatos.Controls.Add(this.lblConsultaPrecio);
            this.gbConsultaDatos.Controls.Add(this.txtConsultaPrecio);
            this.gbConsultaDatos.Controls.Add(this.btnConsultar);
            this.gbConsultaDatos.Controls.Add(this.btnBorrar);
            this.gbConsultaDatos.Location = new System.Drawing.Point(674, 12);
            this.gbConsultaDatos.Name = "gbConsultaDatos";
            this.gbConsultaDatos.Size = new System.Drawing.Size(350, 150);
            this.gbConsultaDatos.TabIndex = 2;
            this.gbConsultaDatos.TabStop = false;
            this.gbConsultaDatos.Text = "Consulta de Datos:";
            // 
            // lblConsultaOrigen
            // 
            this.lblConsultaOrigen.AutoSize = true;
            this.lblConsultaOrigen.Location = new System.Drawing.Point(15, 25);
            this.lblConsultaOrigen.Name = "lblConsultaOrigen";
            this.lblConsultaOrigen.Size = new System.Drawing.Size(41, 13);
            this.lblConsultaOrigen.TabIndex = 0;
            this.lblConsultaOrigen.Text = "Origen:";
            // 
            // cmbConsultaOrigen
            // 
            this.cmbConsultaOrigen.FormattingEnabled = true;
            this.cmbConsultaOrigen.Items.AddRange(new object[] {
            "Córdoba",
            "Mendoza",
            "Santa Fe",
            "Buenos Aires",
            "Salta"});
            this.cmbConsultaOrigen.Location = new System.Drawing.Point(80, 22);
            this.cmbConsultaOrigen.Name = "cmbConsultaOrigen";
            this.cmbConsultaOrigen.Size = new System.Drawing.Size(260, 21);
            this.cmbConsultaOrigen.TabIndex = 1;
            this.cmbConsultaOrigen.SelectedIndex = 0;
            // 
            // lblConsultaDestino
            // 
            this.lblConsultaDestino.AutoSize = true;
            this.lblConsultaDestino.Location = new System.Drawing.Point(15, 50);
            this.lblConsultaDestino.Name = "lblConsultaDestino";
            this.lblConsultaDestino.Size = new System.Drawing.Size(49, 13);
            this.lblConsultaDestino.TabIndex = 2;
            this.lblConsultaDestino.Text = "Destino:";
            // 
            // cmbConsultaDestino
            // 
            this.cmbConsultaDestino.FormattingEnabled = true;
            this.cmbConsultaDestino.Items.AddRange(new object[] {
            "Córdoba",
            "Mendoza",
            "Santa Fe",
            "Buenos Aires",
            "Salta"});
            this.cmbConsultaDestino.Location = new System.Drawing.Point(80, 47);
            this.cmbConsultaDestino.Name = "cmbConsultaDestino";
            this.cmbConsultaDestino.Size = new System.Drawing.Size(260, 21);
            this.cmbConsultaDestino.TabIndex = 3;
            this.cmbConsultaDestino.SelectedIndex = 0;
            // 
            // lblConsultaPrecio
            // 
            this.lblConsultaPrecio.AutoSize = true;
            this.lblConsultaPrecio.Location = new System.Drawing.Point(15, 75);
            this.lblConsultaPrecio.Name = "lblConsultaPrecio";
            this.lblConsultaPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblConsultaPrecio.TabIndex = 4;
            this.lblConsultaPrecio.Text = "Precio:";
            // 
            // txtConsultaPrecio
            // 
            this.txtConsultaPrecio.Location = new System.Drawing.Point(80, 72);
            this.txtConsultaPrecio.Name = "txtConsultaPrecio";
            this.txtConsultaPrecio.ReadOnly = true;
            this.txtConsultaPrecio.Size = new System.Drawing.Size(260, 20);
            this.txtConsultaPrecio.TabIndex = 5;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(15, 110);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(160, 25);
            this.btnConsultar.TabIndex = 6;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(180, 110);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(160, 25);
            this.btnBorrar.TabIndex = 7;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // gbListarViajes
            // 
            this.gbListarViajes.Controls.Add(this.lblListarDesde);
            this.gbListarViajes.Controls.Add(this.cmbListarDesde);
            this.gbListarViajes.Controls.Add(this.btnListarDestinos);
            this.gbListarViajes.Controls.Add(this.lblListarHasta);
            this.gbListarViajes.Controls.Add(this.cmbListarHasta);
            this.gbListarViajes.Controls.Add(this.btnListarOrigenes);
            this.gbListarViajes.Controls.Add(this.btnVerTodosViajes);
            this.gbListarViajes.Location = new System.Drawing.Point(12, 318);
            this.gbListarViajes.Name = "gbListarViajes";
            this.gbListarViajes.Size = new System.Drawing.Size(1012, 50);
            this.gbListarViajes.TabIndex = 3;
            this.gbListarViajes.TabStop = false;
            this.gbListarViajes.Text = "Listar viajes .....";
            // 
            // lblListarDesde
            // 
            this.lblListarDesde.AutoSize = true;
            this.lblListarDesde.Location = new System.Drawing.Point(15, 20);
            this.lblListarDesde.Name = "lblListarDesde";
            this.lblListarDesde.Size = new System.Drawing.Size(41, 13);
            this.lblListarDesde.TabIndex = 0;
            this.lblListarDesde.Text = "Desde:";
            // 
            // cmbListarDesde
            // 
            this.cmbListarDesde.FormattingEnabled = true;
            this.cmbListarDesde.Items.AddRange(new object[] {
            "Córdoba",
            "Mendoza",
            "Santa Fe",
            "Buenos Aires",
            "Salta"});
            this.cmbListarDesde.Location = new System.Drawing.Point(60, 17);
            this.cmbListarDesde.Name = "cmbListarDesde";
            this.cmbListarDesde.Size = new System.Drawing.Size(120, 21);
            this.cmbListarDesde.TabIndex = 1;
            this.cmbListarDesde.SelectedIndex = 0;
            // 
            // btnListarDestinos
            // 
            this.btnListarDestinos.Location = new System.Drawing.Point(186, 17);
            this.btnListarDestinos.Name = "btnListarDestinos";
            this.btnListarDestinos.Size = new System.Drawing.Size(110, 23);
            this.btnListarDestinos.TabIndex = 2;
            this.btnListarDestinos.Text = "Listar Destinos";
            this.btnListarDestinos.UseVisualStyleBackColor = true;
            this.btnListarDestinos.Click += new System.EventHandler(this.btnListarDestinos_Click);
            // 
            // lblListarHasta
            // 
            this.lblListarHasta.AutoSize = true;
            this.lblListarHasta.Location = new System.Drawing.Point(312, 20);
            this.lblListarHasta.Name = "lblListarHasta";
            this.lblListarHasta.Size = new System.Drawing.Size(35, 13);
            this.lblListarHasta.TabIndex = 3;
            this.lblListarHasta.Text = "Hasta:";
            // 
            // cmbListarHasta
            // 
            this.cmbListarHasta.FormattingEnabled = true;
            this.cmbListarHasta.Items.AddRange(new object[] {
            "Córdoba",
            "Mendoza",
            "Santa Fe",
            "Buenos Aires",
            "Salta"});
            this.cmbListarHasta.Location = new System.Drawing.Point(353, 17);
            this.cmbListarHasta.Name = "cmbListarHasta";
            this.cmbListarHasta.Size = new System.Drawing.Size(120, 21);
            this.cmbListarHasta.TabIndex = 4;
            this.cmbListarHasta.SelectedIndex = 0;
            // 
            // btnListarOrigenes
            // 
            this.btnListarOrigenes.Location = new System.Drawing.Point(479, 17);
            this.btnListarOrigenes.Name = "btnListarOrigenes";
            this.btnListarOrigenes.Size = new System.Drawing.Size(110, 23);
            this.btnListarOrigenes.TabIndex = 5;
            this.btnListarOrigenes.Text = "Listar Orígenes";
            this.btnListarOrigenes.UseVisualStyleBackColor = true;
            this.btnListarOrigenes.Click += new System.EventHandler(this.btnListarOrigenes_Click);
            // 
            // btnVerTodosViajes
            // 
            this.btnVerTodosViajes.Location = new System.Drawing.Point(595, 17);
            this.btnVerTodosViajes.Name = "btnVerTodosViajes";
            this.btnVerTodosViajes.Size = new System.Drawing.Size(130, 23);
            this.btnVerTodosViajes.TabIndex = 6;
            this.btnVerTodosViajes.Text = "Ver todos los viajes";
            this.btnVerTodosViajes.UseVisualStyleBackColor = true;
            this.btnVerTodosViajes.Click += new System.EventHandler(this.btnVerTodosViajes_Click);
            // 
            // dgvViajes
            // 
            this.dgvViajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViajes.Location = new System.Drawing.Point(12, 374);
            this.dgvViajes.Name = "dgvViajes";
            this.dgvViajes.Size = new System.Drawing.Size(1012, 250);
            this.dgvViajes.TabIndex = 4;
            // 
            // lblListarViajes
            // 
            this.lblListarViajes.AutoSize = true;
            this.lblListarViajes.Location = new System.Drawing.Point(12, 358);
            this.lblListarViajes.Name = "lblListarViajes";
            this.lblListarViajes.Size = new System.Drawing.Size(0, 13);
            this.lblListarViajes.TabIndex = 5;
            // 
            // frmGrafo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 636);
            this.Controls.Add(this.lblListarViajes);
            this.Controls.Add(this.dgvViajes);
            this.Controls.Add(this.gbListarViajes);
            this.Controls.Add(this.gbConsultaDatos);
            this.Controls.Add(this.gbCargaDatos);
            this.Controls.Add(this.pnlGrafo);
            this.Name = "frmGrafo";
            this.Text = "Operaciones en un Grafo";
            this.pnlGrafo.ResumeLayout(false);
            this.gbCargaDatos.ResumeLayout(false);
            this.gbCargaDatos.PerformLayout();
            this.gbConsultaDatos.ResumeLayout(false);
            this.gbConsultaDatos.PerformLayout();
            this.gbListarViajes.ResumeLayout(false);
            this.gbListarViajes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViajes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlGrafo;
        private System.Windows.Forms.GroupBox gbCargaDatos;
        private System.Windows.Forms.Label lblCargaOrigen;
        private System.Windows.Forms.ComboBox cmbCargaOrigen;
        private System.Windows.Forms.Label lblCargaDestino;
        private System.Windows.Forms.ComboBox cmbCargaDestino;
        private System.Windows.Forms.Label lblCargaPrecio;
        private System.Windows.Forms.TextBox txtCargaPrecio;
        private System.Windows.Forms.Button btnBorrarTodo;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.GroupBox gbConsultaDatos;
        private System.Windows.Forms.Label lblConsultaOrigen;
        private System.Windows.Forms.ComboBox cmbConsultaOrigen;
        private System.Windows.Forms.Label lblConsultaDestino;
        private System.Windows.Forms.ComboBox cmbConsultaDestino;
        private System.Windows.Forms.Label lblConsultaPrecio;
        private System.Windows.Forms.TextBox txtConsultaPrecio;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.GroupBox gbListarViajes;
        private System.Windows.Forms.Label lblListarDesde;
        private System.Windows.Forms.ComboBox cmbListarDesde;
        private System.Windows.Forms.Button btnListarDestinos;
        private System.Windows.Forms.Label lblListarHasta;
        private System.Windows.Forms.ComboBox cmbListarHasta;
        private System.Windows.Forms.Button btnListarOrigenes;
        private System.Windows.Forms.Button btnVerTodosViajes;
        private System.Windows.Forms.DataGridView dgvViajes;
        private System.Windows.Forms.Label lblListarViajes;
    }
}