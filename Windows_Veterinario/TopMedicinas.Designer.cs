namespace Windows_Veterinario
{
    partial class TopMedicinas
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
            this.label2 = new System.Windows.Forms.Label();
            this.cboAño = new System.Windows.Forms.ComboBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblTop = new System.Windows.Forms.Label();
            this.dtgTop = new System.Windows.Forms.DataGridView();
            this.cod_medicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.des_medicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadRecetadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboTop = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTop)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Seleccione Año:";
            // 
            // cboAño
            // 
            this.cboAño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAño.FormattingEnabled = true;
            this.cboAño.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022"});
            this.cboAño.Location = new System.Drawing.Point(141, 64);
            this.cboAño.Name = "cboAño";
            this.cboAño.Size = new System.Drawing.Size(185, 21);
            this.cboAño.TabIndex = 41;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(69, 100);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(188, 24);
            this.btnConsultar.TabIndex = 40;
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
            this.lblTop.TabIndex = 39;
            this.lblTop.Text = "Top \" \" Clientes :";
            // 
            // dtgTop
            // 
            this.dtgTop.AllowUserToAddRows = false;
            this.dtgTop.AllowUserToDeleteRows = false;
            this.dtgTop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_medicamento,
            this.des_medicamento,
            this.CantidadRecetadas});
            this.dtgTop.Location = new System.Drawing.Point(22, 167);
            this.dtgTop.Name = "dtgTop";
            this.dtgTop.ReadOnly = true;
            this.dtgTop.RowHeadersVisible = false;
            this.dtgTop.Size = new System.Drawing.Size(304, 135);
            this.dtgTop.TabIndex = 38;
            // 
            // cod_medicamento
            // 
            this.cod_medicamento.DataPropertyName = "cod_medicamento";
            this.cod_medicamento.HeaderText = "Código";
            this.cod_medicamento.Name = "cod_medicamento";
            this.cod_medicamento.ReadOnly = true;
            // 
            // des_medicamento
            // 
            this.des_medicamento.DataPropertyName = "des_medicamento";
            this.des_medicamento.HeaderText = "Medicina";
            this.des_medicamento.Name = "des_medicamento";
            this.des_medicamento.ReadOnly = true;
            // 
            // CantidadRecetadas
            // 
            this.CantidadRecetadas.DataPropertyName = "CantidadRecetadas";
            this.CantidadRecetadas.HeaderText = "Ctd. Recetadas";
            this.CantidadRecetadas.Name = "CantidadRecetadas";
            this.CantidadRecetadas.ReadOnly = true;
            // 
            // cboTop
            // 
            this.cboTop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTop.FormattingEnabled = true;
            this.cboTop.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cboTop.Location = new System.Drawing.Point(141, 25);
            this.cboTop.Name = "cboTop";
            this.cboTop.Size = new System.Drawing.Size(185, 21);
            this.cboTop.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Seleccione Top:";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(251, 327);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 43;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // TopMedicinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 362);
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
            this.Name = "TopMedicinas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TopMedicinas";
            ((System.ComponentModel.ISupportInitialize)(this.dtgTop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboAño;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.DataGridView dtgTop;
        private System.Windows.Forms.ComboBox cboTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_medicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn des_medicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadRecetadas;
        private System.Windows.Forms.Button btnSalir;
    }
}