namespace WindowsFormsView.TelasCliente
{
    partial class FrmExclui
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
            this.btnExclui = new System.Windows.Forms.Button();
            this.btnExcluiSairCancelar = new System.Windows.Forms.Button();
            this.lblExcluiCliente = new System.Windows.Forms.Label();
            this.btnExcluiBuscar = new System.Windows.Forms.Button();
            this.dgvExcluirCliente = new System.Windows.Forms.DataGridView();
            this.txtExcluiClienteId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcluirCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExclui
            // 
            this.btnExclui.Location = new System.Drawing.Point(24, 175);
            this.btnExclui.Name = "btnExclui";
            this.btnExclui.Size = new System.Drawing.Size(75, 23);
            this.btnExclui.TabIndex = 0;
            this.btnExclui.Text = "Excluir Cliente";
            this.btnExclui.UseVisualStyleBackColor = true;
            this.btnExclui.Click += new System.EventHandler(this.btnExclui_Click);
            // 
            // btnExcluiSairCancelar
            // 
            this.btnExcluiSairCancelar.Location = new System.Drawing.Point(204, 175);
            this.btnExcluiSairCancelar.Name = "btnExcluiSairCancelar";
            this.btnExcluiSairCancelar.Size = new System.Drawing.Size(133, 23);
            this.btnExcluiSairCancelar.TabIndex = 1;
            this.btnExcluiSairCancelar.Text = "Cancelar ou Sair";
            this.btnExcluiSairCancelar.UseVisualStyleBackColor = true;
            this.btnExcluiSairCancelar.Click += new System.EventHandler(this.btnExcluiSairCancelar_Click);
            // 
            // lblExcluiCliente
            // 
            this.lblExcluiCliente.AutoSize = true;
            this.lblExcluiCliente.Location = new System.Drawing.Point(9, 16);
            this.lblExcluiCliente.Name = "lblExcluiCliente";
            this.lblExcluiCliente.Size = new System.Drawing.Size(63, 13);
            this.lblExcluiCliente.TabIndex = 2;
            this.lblExcluiCliente.Text = "Digite o ID :";
            // 
            // btnExcluiBuscar
            // 
            this.btnExcluiBuscar.Location = new System.Drawing.Point(118, 30);
            this.btnExcluiBuscar.Name = "btnExcluiBuscar";
            this.btnExcluiBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnExcluiBuscar.TabIndex = 4;
            this.btnExcluiBuscar.Text = "Buscar";
            this.btnExcluiBuscar.UseVisualStyleBackColor = true;
            this.btnExcluiBuscar.Click += new System.EventHandler(this.btnExcluiBuscar_Click);
            // 
            // dgvExcluirCliente
            // 
            this.dgvExcluirCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExcluirCliente.Location = new System.Drawing.Point(12, 61);
            this.dgvExcluirCliente.Name = "dgvExcluirCliente";
            this.dgvExcluirCliente.Size = new System.Drawing.Size(354, 76);
            this.dgvExcluirCliente.TabIndex = 5;
            // 
            // txtExcluiClienteId
            // 
            this.txtExcluiClienteId.Location = new System.Drawing.Point(13, 33);
            this.txtExcluiClienteId.Name = "txtExcluiClienteId";
            this.txtExcluiClienteId.Size = new System.Drawing.Size(99, 20);
            this.txtExcluiClienteId.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Utilize o botão Buscar para conferir informações";
            // 
            // FrmExclui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 210);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtExcluiClienteId);
            this.Controls.Add(this.dgvExcluirCliente);
            this.Controls.Add(this.btnExcluiBuscar);
            this.Controls.Add(this.lblExcluiCliente);
            this.Controls.Add(this.btnExcluiSairCancelar);
            this.Controls.Add(this.btnExclui);
            this.Name = "FrmExclui";
            this.Text = "Exclusão de Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcluirCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExclui;
        private System.Windows.Forms.Button btnExcluiSairCancelar;
        private System.Windows.Forms.Label lblExcluiCliente;
        private System.Windows.Forms.TextBox txtExcluiIdNome;
        private System.Windows.Forms.Button btnExcluiBuscar;
        private System.Windows.Forms.DataGridView dgvExcluirCliente;
        private System.Windows.Forms.TextBox txtExcluiClienteId;
        private System.Windows.Forms.Label label1;
    }
}