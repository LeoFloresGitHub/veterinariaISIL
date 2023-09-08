namespace Windows_Veterinario
{
    partial class ConsultasMascotaFechas
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
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgClientes = new System.Windows.Forms.DataGridView();
            this.cod_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni_cli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ape_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFecFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFecIni = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtgConsultas = new System.Windows.Forms.DataGridView();
            this.Consulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fec_consulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_mascota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(209, 12);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(342, 20);
            this.txtFiltro.TabIndex = 68;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(629, 316);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(117, 54);
            this.btnConsultar.TabIndex = 60;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(423, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "Fecha Fin: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "Fecha Inicio: ";
            // 
            // dtgClientes
            // 
            this.dtgClientes.AllowUserToAddRows = false;
            this.dtgClientes.AllowUserToDeleteRows = false;
            this.dtgClientes.AllowUserToResizeColumns = false;
            this.dtgClientes.AllowUserToResizeRows = false;
            this.dtgClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_cliente,
            this.dni_cli,
            this.nom_cliente,
            this.ape_cliente,
            this.Estado});
            this.dtgClientes.Location = new System.Drawing.Point(125, 87);
            this.dtgClientes.Name = "dtgClientes";
            this.dtgClientes.ReadOnly = true;
            this.dtgClientes.RowHeadersVisible = false;
            this.dtgClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgClientes.Size = new System.Drawing.Size(503, 211);
            this.dtgClientes.TabIndex = 57;
            // 
            // cod_cliente
            // 
            this.cod_cliente.DataPropertyName = "cod_mascota";
            this.cod_cliente.HeaderText = "Código de Mascota";
            this.cod_cliente.Name = "cod_cliente";
            this.cod_cliente.ReadOnly = true;
            // 
            // dni_cli
            // 
            this.dni_cli.DataPropertyName = "nom_mascota";
            this.dni_cli.HeaderText = "Nombre";
            this.dni_cli.Name = "dni_cli";
            this.dni_cli.ReadOnly = true;
            // 
            // nom_cliente
            // 
            this.nom_cliente.DataPropertyName = "des_esp";
            this.nom_cliente.HeaderText = "Especie";
            this.nom_cliente.Name = "nom_cliente";
            this.nom_cliente.ReadOnly = true;
            // 
            // ape_cliente
            // 
            this.ape_cliente.DataPropertyName = "sexoLit";
            this.ape_cliente.HeaderText = "Sexo";
            this.ape_cliente.Name = "ape_cliente";
            this.ape_cliente.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "color";
            this.Estado.HeaderText = "Color";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Seleccione Mascota: ";
            // 
            // dtpFecFin
            // 
            this.dtpFecFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecFin.Location = new System.Drawing.Point(504, 331);
            this.dtpFecFin.Name = "dtpFecFin";
            this.dtpFecFin.Size = new System.Drawing.Size(105, 20);
            this.dtpFecFin.TabIndex = 55;
            // 
            // dtpFecIni
            // 
            this.dtpFecIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecIni.Location = new System.Drawing.Point(209, 331);
            this.dtpFecIni.Name = "dtpFecIni";
            this.dtpFecIni.Size = new System.Drawing.Size(105, 20);
            this.dtpFecIni.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 69;
            this.label5.Text = "Buscar por nombre";
            // 
            // dtgConsultas
            // 
            this.dtgConsultas.AllowUserToAddRows = false;
            this.dtgConsultas.AllowUserToDeleteRows = false;
            this.dtgConsultas.AllowUserToResizeColumns = false;
            this.dtgConsultas.AllowUserToResizeRows = false;
            this.dtgConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgConsultas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Consulta,
            this.Nombre,
            this.Apellido,
            this.fec_consulta,
            this.nom_mascota,
            this.Estado2,
            this.Total2});
            this.dtgConsultas.Location = new System.Drawing.Point(42, 385);
            this.dtgConsultas.Name = "dtgConsultas";
            this.dtgConsultas.ReadOnly = true;
            this.dtgConsultas.RowHeadersVisible = false;
            this.dtgConsultas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgConsultas.Size = new System.Drawing.Size(704, 167);
            this.dtgConsultas.TabIndex = 70;
            // 
            // Consulta
            // 
            this.Consulta.DataPropertyName = "id_consulta";
            this.Consulta.HeaderText = "Consulta";
            this.Consulta.Name = "Consulta";
            this.Consulta.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "nom_cliente";
            this.Nombre.HeaderText = "Nombre Dueño";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.DataPropertyName = "ape_cliente";
            this.Apellido.HeaderText = "Apellido Dueño";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // fec_consulta
            // 
            this.fec_consulta.DataPropertyName = "fec_consulta";
            this.fec_consulta.HeaderText = "Fecha";
            this.fec_consulta.Name = "fec_consulta";
            this.fec_consulta.ReadOnly = true;
            // 
            // nom_mascota
            // 
            this.nom_mascota.DataPropertyName = "nom_mascota";
            this.nom_mascota.HeaderText = "Mascota";
            this.nom_mascota.Name = "nom_mascota";
            this.nom_mascota.ReadOnly = true;
            // 
            // Estado2
            // 
            this.Estado2.DataPropertyName = "Estado";
            this.Estado2.HeaderText = "Estado";
            this.Estado2.Name = "Estado2";
            this.Estado2.ReadOnly = true;
            // 
            // Total2
            // 
            this.Total2.DataPropertyName = "Total";
            this.Total2.HeaderText = "Total";
            this.Total2.Name = "Total2";
            this.Total2.ReadOnly = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(671, 578);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 71;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // ConsultasMascotaFechas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 613);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dtgConsultas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgClientes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFecFin);
            this.Controls.Add(this.dtpFecIni);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ConsultasMascotaFechas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultasMascotaFechas";
            this.Load += new System.EventHandler(this.ConsultasMascotaFechas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFecFin;
        private System.Windows.Forms.DateTimePicker dtpFecIni;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtgConsultas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Consulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn fec_consulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_mascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni_cli;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ape_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.Button btnSalir;
    }
}