namespace Windows_Veterinario
{
    partial class TopAtencionesClientes
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
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblTop = new System.Windows.Forms.Label();
            this.dtgTop = new System.Windows.Forms.DataGridView();
            this.cod_cli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_cli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ape_cli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsultasTotales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboTop = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboAño = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTop)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(126, 100);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(188, 24);
            this.btnConsultar.TabIndex = 31;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblTop
            // 
            this.lblTop.AutoSize = true;
            this.lblTop.Location = new System.Drawing.Point(19, 136);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(88, 13);
            this.lblTop.TabIndex = 30;
            this.lblTop.Text = "Top \" \" Clientes :";
            this.lblTop.Click += new System.EventHandler(this.lblTop_Click);
            // 
            // dtgTop
            // 
            this.dtgTop.AllowUserToAddRows = false;
            this.dtgTop.AllowUserToDeleteRows = false;
            this.dtgTop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_cli,
            this.nom_cli,
            this.ape_cli,
            this.ConsultasTotales});
            this.dtgTop.Location = new System.Drawing.Point(22, 167);
            this.dtgTop.Name = "dtgTop";
            this.dtgTop.ReadOnly = true;
            this.dtgTop.RowHeadersVisible = false;
            this.dtgTop.Size = new System.Drawing.Size(404, 135);
            this.dtgTop.TabIndex = 29;
            this.dtgTop.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgTop_CellContentClick);
            // 
            // cod_cli
            // 
            this.cod_cli.DataPropertyName = "cod_cli";
            this.cod_cli.HeaderText = "Código";
            this.cod_cli.Name = "cod_cli";
            this.cod_cli.ReadOnly = true;
            // 
            // nom_cli
            // 
            this.nom_cli.DataPropertyName = "nom_cli";
            this.nom_cli.HeaderText = "Nombre";
            this.nom_cli.Name = "nom_cli";
            this.nom_cli.ReadOnly = true;
            // 
            // ape_cli
            // 
            this.ape_cli.DataPropertyName = "ape_cli";
            this.ape_cli.HeaderText = "Apellido";
            this.ape_cli.Name = "ape_cli";
            this.ape_cli.ReadOnly = true;
            // 
            // ConsultasTotales
            // 
            this.ConsultasTotales.DataPropertyName = "ConsultasTotales";
            this.ConsultasTotales.HeaderText = "Consultas Totales";
            this.ConsultasTotales.Name = "ConsultasTotales";
            this.ConsultasTotales.ReadOnly = true;
            // 
            // cboTop
            // 
            this.cboTop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTop.FormattingEnabled = true;
            this.cboTop.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cboTop.Location = new System.Drawing.Point(198, 25);
            this.cboTop.Name = "cboTop";
            this.cboTop.Size = new System.Drawing.Size(185, 21);
            this.cboTop.TabIndex = 28;
            this.cboTop.SelectedIndexChanged += new System.EventHandler(this.cboTop_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Seleccione Top:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cboAño
            // 
            this.cboAño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAño.FormattingEnabled = true;
            this.cboAño.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022"});
            this.cboAño.Location = new System.Drawing.Point(198, 64);
            this.cboAño.Name = "cboAño";
            this.cboAño.Size = new System.Drawing.Size(185, 21);
            this.cboAño.TabIndex = 34;
            this.cboAño.SelectedIndexChanged += new System.EventHandler(this.cboAño_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Seleccione Año:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(351, 332);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 36;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // TopAtencionesClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 367);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboAño);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.lblTop);
            this.Controls.Add(this.dtgTop);
            this.Controls.Add(this.cboTop);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TopAtencionesClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TopAtencionesClientes";
            this.Load += new System.EventHandler(this.TopAtencionesClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.DataGridView dtgTop;
        private System.Windows.Forms.ComboBox cboTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboAño;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_cli;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_cli;
        private System.Windows.Forms.DataGridViewTextBoxColumn ape_cli;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsultasTotales;
        private System.Windows.Forms.Button btnSalir;
    }
}