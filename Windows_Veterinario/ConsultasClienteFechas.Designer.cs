namespace Windows_Veterinario
{
    partial class ConsultasClienteFechas
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
            this.label4 = new System.Windows.Forms.Label();
            this.rbtnCancelada = new System.Windows.Forms.RadioButton();
            this.rbtnPendiente = new System.Windows.Forms.RadioButton();
            this.rbtnAtendida = new System.Windows.Forms.RadioButton();
            this.dtgConsultas = new System.Windows.Forms.DataGridView();
            this.Consulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fec_consulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_mascota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgClientes = new System.Windows.Forms.DataGridView();
            this.cod_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni_cli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ape_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFecFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFecIni = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(168, 16);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(352, 20);
            this.txtFiltro.TabIndex = 53;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "Estado de consulta: ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rbtnCancelada
            // 
            this.rbtnCancelada.AutoSize = true;
            this.rbtnCancelada.Location = new System.Drawing.Point(184, 347);
            this.rbtnCancelada.Name = "rbtnCancelada";
            this.rbtnCancelada.Size = new System.Drawing.Size(81, 17);
            this.rbtnCancelada.TabIndex = 51;
            this.rbtnCancelada.TabStop = true;
            this.rbtnCancelada.Text = "Canceladas";
            this.rbtnCancelada.UseVisualStyleBackColor = true;
            // 
            // rbtnPendiente
            // 
            this.rbtnPendiente.AutoSize = true;
            this.rbtnPendiente.Location = new System.Drawing.Point(184, 324);
            this.rbtnPendiente.Name = "rbtnPendiente";
            this.rbtnPendiente.Size = new System.Drawing.Size(78, 17);
            this.rbtnPendiente.TabIndex = 50;
            this.rbtnPendiente.TabStop = true;
            this.rbtnPendiente.Text = "Pendientes";
            this.rbtnPendiente.UseVisualStyleBackColor = true;
            // 
            // rbtnAtendida
            // 
            this.rbtnAtendida.AutoSize = true;
            this.rbtnAtendida.Location = new System.Drawing.Point(184, 305);
            this.rbtnAtendida.Name = "rbtnAtendida";
            this.rbtnAtendida.Size = new System.Drawing.Size(72, 17);
            this.rbtnAtendida.TabIndex = 49;
            this.rbtnAtendida.TabStop = true;
            this.rbtnAtendida.Text = "Atendidas";
            this.rbtnAtendida.UseVisualStyleBackColor = true;
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
            this.fec_consulta,
            this.nom_mascota,
            this.Estado2,
            this.Total2});
            this.dtgConsultas.Location = new System.Drawing.Point(87, 396);
            this.dtgConsultas.Name = "dtgConsultas";
            this.dtgConsultas.ReadOnly = true;
            this.dtgConsultas.RowHeadersVisible = false;
            this.dtgConsultas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgConsultas.Size = new System.Drawing.Size(504, 142);
            this.dtgConsultas.TabIndex = 46;
            // 
            // Consulta
            // 
            this.Consulta.DataPropertyName = "id_consulta";
            this.Consulta.HeaderText = "Consulta";
            this.Consulta.Name = "Consulta";
            this.Consulta.ReadOnly = true;
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
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(543, 302);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(114, 60);
            this.btnConsultar.TabIndex = 45;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Fecha Fin: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 43;
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
            this.Estado,
            this.Sexo,
            this.tel_cliente});
            this.dtgClientes.Location = new System.Drawing.Point(52, 80);
            this.dtgClientes.Name = "dtgClientes";
            this.dtgClientes.ReadOnly = true;
            this.dtgClientes.RowHeadersVisible = false;
            this.dtgClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgClientes.Size = new System.Drawing.Size(605, 203);
            this.dtgClientes.TabIndex = 42;
            // 
            // cod_cliente
            // 
            this.cod_cliente.DataPropertyName = "cod_cliente";
            this.cod_cliente.HeaderText = "Código de Cliente";
            this.cod_cliente.Name = "cod_cliente";
            this.cod_cliente.ReadOnly = true;
            // 
            // dni_cli
            // 
            this.dni_cli.DataPropertyName = "dni_cli";
            this.dni_cli.HeaderText = "DNI";
            this.dni_cli.Name = "dni_cli";
            this.dni_cli.ReadOnly = true;
            // 
            // nom_cliente
            // 
            this.nom_cliente.DataPropertyName = "nom_cliente";
            this.nom_cliente.HeaderText = "Nombre";
            this.nom_cliente.Name = "nom_cliente";
            this.nom_cliente.ReadOnly = true;
            // 
            // ape_cliente
            // 
            this.ape_cliente.DataPropertyName = "ape_cliente";
            this.ape_cliente.HeaderText = "Apellidos";
            this.ape_cliente.Name = "ape_cliente";
            this.ape_cliente.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Visible = false;
            // 
            // Sexo
            // 
            this.Sexo.DataPropertyName = "sexo_lit";
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            // 
            // tel_cliente
            // 
            this.tel_cliente.DataPropertyName = "tel_cliente";
            this.tel_cliente.HeaderText = "Teléfono";
            this.tel_cliente.Name = "tel_cliente";
            this.tel_cliente.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Seleccione Cliente";
            // 
            // dtpFecFin
            // 
            this.dtpFecFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecFin.Location = new System.Drawing.Point(415, 349);
            this.dtpFecFin.Name = "dtpFecFin";
            this.dtpFecFin.Size = new System.Drawing.Size(105, 20);
            this.dtpFecFin.TabIndex = 40;
            // 
            // dtpFecIni
            // 
            this.dtpFecIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecIni.Location = new System.Drawing.Point(415, 309);
            this.dtpFecIni.Name = "dtpFecIni";
            this.dtpFecIni.Size = new System.Drawing.Size(105, 20);
            this.dtpFecIni.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "Buscar por nombre";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(573, 553);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 55;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // ConsultasClienteFechas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 588);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rbtnCancelada);
            this.Controls.Add(this.rbtnPendiente);
            this.Controls.Add(this.rbtnAtendida);
            this.Controls.Add(this.dtgConsultas);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgClientes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFecFin);
            this.Controls.Add(this.dtpFecIni);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ConsultasClienteFechas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultasClienteFechas";
            this.Load += new System.EventHandler(this.ConsultasClienteFechas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbtnCancelada;
        private System.Windows.Forms.RadioButton rbtnPendiente;
        private System.Windows.Forms.RadioButton rbtnAtendida;
        private System.Windows.Forms.DataGridView dtgConsultas;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFecFin;
        private System.Windows.Forms.DateTimePicker dtpFecIni;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Consulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn fec_consulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_mascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni_cli;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ape_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel_cliente;
        private System.Windows.Forms.Button btnSalir;
    }
}