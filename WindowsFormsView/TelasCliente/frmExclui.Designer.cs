namespace WindowsFormsView.TelasCliente
{
    partial class frmExclui
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
            this.btnExcluiCancelar = new System.Windows.Forms.Button();
            this.lblExcluiCliente = new System.Windows.Forms.Label();
            this.txtExcluiIdNome = new System.Windows.Forms.TextBox();
            this.btnExcluiBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExclui
            // 
            this.btnExclui.Location = new System.Drawing.Point(31, 125);
            this.btnExclui.Name = "btnExclui";
            this.btnExclui.Size = new System.Drawing.Size(75, 23);
            this.btnExclui.TabIndex = 0;
            this.btnExclui.Text = "Excluir Cliente";
            this.btnExclui.UseVisualStyleBackColor = true;
            // 
            // btnExcluiCancelar
            // 
            this.btnExcluiCancelar.Location = new System.Drawing.Point(137, 125);
            this.btnExcluiCancelar.Name = "btnExcluiCancelar";
            this.btnExcluiCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnExcluiCancelar.TabIndex = 1;
            this.btnExcluiCancelar.Text = "Cancelar";
            this.btnExcluiCancelar.UseVisualStyleBackColor = true;
            // 
            // lblExcluiCliente
            // 
            this.lblExcluiCliente.AutoSize = true;
            this.lblExcluiCliente.Location = new System.Drawing.Point(28, 39);
            this.lblExcluiCliente.Name = "lblExcluiCliente";
            this.lblExcluiCliente.Size = new System.Drawing.Size(117, 13);
            this.lblExcluiCliente.TabIndex = 2;
            this.lblExcluiCliente.Text = "Digite um Nome ou ID :";
            // 
            // txtExcluiIdNome
            // 
            this.txtExcluiIdNome.Location = new System.Drawing.Point(31, 55);
            this.txtExcluiIdNome.Name = "txtExcluiIdNome";
            this.txtExcluiIdNome.Size = new System.Drawing.Size(259, 20);
            this.txtExcluiIdNome.TabIndex = 3;
            // 
            // btnExcluiBuscar
            // 
            this.btnExcluiBuscar.Location = new System.Drawing.Point(309, 52);
            this.btnExcluiBuscar.Name = "btnExcluiBuscar";
            this.btnExcluiBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnExcluiBuscar.TabIndex = 4;
            this.btnExcluiBuscar.Text = "Buscar";
            this.btnExcluiBuscar.UseVisualStyleBackColor = true;
            // 
            // frmExclui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 210);
            this.Controls.Add(this.btnExcluiBuscar);
            this.Controls.Add(this.txtExcluiIdNome);
            this.Controls.Add(this.lblExcluiCliente);
            this.Controls.Add(this.btnExcluiCancelar);
            this.Controls.Add(this.btnExclui);
            this.Name = "frmExclui";
            this.Text = "Exclusão de Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExclui;
        private System.Windows.Forms.Button btnExcluiCancelar;
        private System.Windows.Forms.Label lblExcluiCliente;
        private System.Windows.Forms.TextBox txtExcluiIdNome;
        private System.Windows.Forms.Button btnExcluiBuscar;
    }
}