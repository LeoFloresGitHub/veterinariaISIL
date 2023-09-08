namespace Windows_Veterinario
{
    partial class ConsultasVeterinarioFechas
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
            this.dtpFecIni = new System.Windows.Forms.DateTimePicker();
            this.dtpFecFin = new System.Windows.Forms.DateTimePicker();
            this.dtgVeterinarios = new System.Windows.Forms.DataGridView();
            this.cod_veterinario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni_vet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_veterinario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ape_veterinario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel_veterinario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.des_especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.rbtnAtendida = new System.Windows.Forms.RadioButton();
            this.rbtnPendiente = new System.Windows.Forms.RadioButton();
            this.rbtnCancelada = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.dtgConsultas = new System.Windows.Forms.DataGridView();
            this.Consulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fec_consulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_mascota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVeterinarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFecIni
            // 
            this.dtpFecIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecIni.Location = new System.Drawing.Point(366, 292);
            this.dtpFecIni.Name = "dtpFecIni";
            this.dtpFecIni.Size = new System.Drawing.Size(105, 20);
            this.dtpFecIni.TabIndex = 0;
            // 
            // dtpFecFin
            // 
            this.dtpFecFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecFin.Location = new System.Drawing.Point(366, 331);
            this.dtpFecFin.Name = "dtpFecFin";
            this.dtpFecFin.Size = new System.Drawing.Size(105, 20);
            this.dtpFecFin.TabIndex = 1;
            // 
            // dtgVeterinarios
            // 
            this.dtgVeterinarios.AllowUserToAddRows = false;
            this.dtgVeterinarios.AllowUserToDeleteRows = false;
            this.dtgVeterinarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgVeterinarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVeterinarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_veterinario,
            this.dni_vet,
            this.nom_veterinario,
            this.ape_veterinario,
            this.tel_veterinario,
            this.des_especialidad,
            this.Estado});
            this.dtgVeterinarios.Location = new System.Drawing.Point(31, 81);
            this.dtgVeterinarios.Name = "dtgVeterinarios";
            this.dtgVeterinarios.ReadOnly = true;
            this.dtgVeterinarios.RowHeadersVisible = false;
            this.dtgVeterinarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgVeterinarios.Size = new System.Drawing.Size(610, 196);
            this.dtgVeterinarios.TabIndex = 27;
            // 
            // cod_veterinario
            // 
            this.cod_veterinario.DataPropertyName = "cod_veterinario";
            this.cod_veterinario.HeaderText = "Código de Veterinario";
            this.cod_veterinario.Name = "cod_veterinario";
            this.cod_veterinario.ReadOnly = true;
            // 
            // dni_vet
            // 
            this.dni_vet.DataPropertyName = "dni_vet";
            this.dni_vet.HeaderText = "DNI";
            this.dni_vet.Name = "dni_vet";
            this.dni_vet.ReadOnly = true;
            // 
            // nom_veterinario
            // 
            this.nom_veterinario.DataPropertyName = "nom_veterinario";
            this.nom_veterinario.HeaderText = "Nombre";
            this.nom_veterinario.Name = "nom_veterinario";
            this.nom_veterinario.ReadOnly = true;
            // 
            // ape_veterinario
            // 
            this.ape_veterinario.DataPropertyName = "ape_veterinario";
            this.ape_veterinario.HeaderText = "Apellidos";
            this.ape_veterinario.Name = "ape_veterinario";
            this.ape_veterinario.ReadOnly = true;
            // 
            // tel_veterinario
            // 
            this.tel_veterinario.DataPropertyName = "tel_veterinario";
            this.tel_veterinario.HeaderText = "Teléfono";
            this.tel_veterinario.Name = "tel_veterinario";
            this.tel_veterinario.ReadOnly = true;
            // 
            // des_especialidad
            // 
            this.des_especialidad.DataPropertyName = "des_especialidad";
            this.des_especialidad.HeaderText = "Especialidad";
            this.des_especialidad.Name = "des_especialidad";
            this.des_especialidad.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Seleccione Veterinario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Fecha Inicio: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Fecha Fin: ";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(490, 292);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(132, 60);
            this.btnConsultar.TabIndex = 30;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // rbtnAtendida
            // 
            this.rbtnAtendida.AutoSize = true;
            this.rbtnAtendida.Location = new System.Drawing.Point(170, 288);
            this.rbtnAtendida.Name = "rbtnAtendida";
            this.rbtnAtendida.Size = new System.Drawing.Size(72, 17);
            this.rbtnAtendida.TabIndex = 34;
            this.rbtnAtendida.TabStop = true;
            this.rbtnAtendida.Text = "Atendidas";
            this.rbtnAtendida.UseVisualStyleBackColor = true;
            // 
            // rbtnPendiente
            // 
            this.rbtnPendiente.AutoSize = true;
            this.rbtnPendiente.Location = new System.Drawing.Point(170, 312);
            this.rbtnPendiente.Name = "rbtnPendiente";
            this.rbtnPendiente.Size = new System.Drawing.Size(78, 17);
            this.rbtnPendiente.TabIndex = 35;
            this.rbtnPendiente.TabStop = true;
            this.rbtnPendiente.Text = "Pendientes";
            this.rbtnPendiente.UseVisualStyleBackColor = true;
            // 
            // rbtnCancelada
            // 
            this.rbtnCancelada.AutoSize = true;
            this.rbtnCancelada.Location = new System.Drawing.Point(170, 335);
            this.rbtnCancelada.Name = "rbtnCancelada";
            this.rbtnCancelada.Size = new System.Drawing.Size(81, 17);
            this.rbtnCancelada.TabIndex = 36;
            this.rbtnCancelada.TabStop = true;
            this.rbtnCancelada.Text = "Canceladas";
            this.rbtnCancelada.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Estado de consultas:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(160, 17);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(352, 20);
            this.txtFiltro.TabIndex = 38;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
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
            this.Estado2});
            this.dtgConsultas.Location = new System.Drawing.Point(124, 367);
            this.dtgConsultas.Name = "dtgConsultas";
            this.dtgConsultas.ReadOnly = true;
            this.dtgConsultas.RowHeadersVisible = false;
            this.dtgConsultas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgConsultas.Size = new System.Drawing.Size(403, 148);
            this.dtgConsultas.TabIndex = 71;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 72;
            this.label5.Text = "Buscar por nombre";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(535, 531);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 73;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // ConsultasVeterinarioFechas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 566);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtgConsultas);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rbtnCancelada);
            this.Controls.Add(this.rbtnPendiente);
            this.Controls.Add(this.rbtnAtendida);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgVeterinarios);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFecFin);
            this.Controls.Add(this.dtpFecIni);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ConsultasVeterinarioFechas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultasVeterinarioFechas";
            this.Load += new System.EventHandler(this.ConsultasVeterinarioFechas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgVeterinarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFecIni;
        private System.Windows.Forms.DateTimePicker dtpFecFin;
        private System.Windows.Forms.DataGridView dtgVeterinarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.RadioButton rbtnAtendida;
        private System.Windows.Forms.RadioButton rbtnPendiente;
        private System.Windows.Forms.RadioButton rbtnCancelada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_veterinario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni_vet;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_veterinario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ape_veterinario;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel_veterinario;
        private System.Windows.Forms.DataGridViewTextBoxColumn des_especialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridView dtgConsultas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Consulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn fec_consulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_mascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSalir;
    }
}