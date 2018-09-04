namespace WindowsFormsView.TelasCliente
{
    partial class FrmListarOrdenado
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
            this.dgvListaOrdenadaCliente = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaOrdenadaCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaOrdenadaCliente
            // 
            this.dgvListaOrdenadaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaOrdenadaCliente.Location = new System.Drawing.Point(12, 37);
            this.dgvListaOrdenadaCliente.Name = "dgvListaOrdenadaCliente";
            this.dgvListaOrdenadaCliente.Size = new System.Drawing.Size(433, 349);
            this.dgvListaOrdenadaCliente.TabIndex = 0;
            // 
            // FrmListarOrdenado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 423);
            this.Controls.Add(this.dgvListaOrdenadaCliente);
            this.Name = "FrmListarOrdenado";
            this.Text = "Cliente - Lista Ordenada por Idade";
            this.Load += new System.EventHandler(this.frmListarOrdenado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaOrdenadaCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaOrdenadaCliente;
    }
}