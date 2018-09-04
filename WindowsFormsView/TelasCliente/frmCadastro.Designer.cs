namespace WindowsFormsView.TelasCliente
{
    partial class FrmCadastro
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCadastroSair = new System.Windows.Forms.Button();
            this.mtbCadastroTelefone = new System.Windows.Forms.MaskedTextBox();
            this.nudCadastroIdade = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudCadastroIdade)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(12, 156);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(70, 23);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome :";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(73, 34);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.ShortcutsEnabled = false;
            this.txtNome.Size = new System.Drawing.Size(270, 20);
            this.txtNome.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Idade :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefone :";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(259, 156);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(70, 23);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCadastroSair
            // 
            this.btnCadastroSair.Location = new System.Drawing.Point(103, 156);
            this.btnCadastroSair.Name = "btnCadastroSair";
            this.btnCadastroSair.Size = new System.Drawing.Size(135, 23);
            this.btnCadastroSair.TabIndex = 9;
            this.btnCadastroSair.Text = "Cancelar ou Sair";
            this.btnCadastroSair.UseVisualStyleBackColor = true;
            this.btnCadastroSair.Click += new System.EventHandler(this.btnCadastroSair_Click);
            // 
            // mtbCadastroTelefone
            // 
            this.mtbCadastroTelefone.Location = new System.Drawing.Point(73, 108);
            this.mtbCadastroTelefone.Mask = "0000000000";
            this.mtbCadastroTelefone.Name = "mtbCadastroTelefone";
            this.mtbCadastroTelefone.Size = new System.Drawing.Size(70, 20);
            this.mtbCadastroTelefone.TabIndex = 10;
            // 
            // nudCadastroIdade
            // 
            this.nudCadastroIdade.Location = new System.Drawing.Point(73, 67);
            this.nudCadastroIdade.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.nudCadastroIdade.Name = "nudCadastroIdade";
            this.nudCadastroIdade.Size = new System.Drawing.Size(44, 20);
            this.nudCadastroIdade.TabIndex = 11;
            // 
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 214);
            this.Controls.Add(this.nudCadastroIdade);
            this.Controls.Add(this.mtbCadastroTelefone);
            this.Controls.Add(this.btnCadastroSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalvar);
            this.Name = "FrmCadastro";
            this.Text = "Cadastro de Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.nudCadastroIdade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCadastroSair;
        private System.Windows.Forms.MaskedTextBox mtbCadastroTelefone;
        private System.Windows.Forms.NumericUpDown nudCadastroIdade;
    }
}