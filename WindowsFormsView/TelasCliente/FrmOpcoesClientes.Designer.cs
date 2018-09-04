namespace WindowsFormsView.TelasCliente
{
    partial class frmOpcoesClientes
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
            this.btnCadastrarCliente = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnTelaExclui = new System.Windows.Forms.Button();
            this.btnListarClientes = new System.Windows.Forms.Button();
            this.btnListarClientesOrdenados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.Location = new System.Drawing.Point(12, 27);
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Size = new System.Drawing.Size(174, 61);
            this.btnCadastrarCliente.TabIndex = 0;
            this.btnCadastrarCliente.Text = "Cadastrar novo  Cliente";
            this.btnCadastrarCliente.UseMnemonic = false;
            this.btnCadastrarCliente.UseVisualStyleBackColor = true;
            this.btnCadastrarCliente.Click += new System.EventHandler(this.btnCadastrarCliente_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(204, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(54, 371);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 6;
            this.btnQuit.Text = "Sair";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            
            // 
            // btnTelaExclui
            // 
            this.btnTelaExclui.Location = new System.Drawing.Point(12, 271);
            this.btnTelaExclui.Name = "btnTelaExclui";
            this.btnTelaExclui.Size = new System.Drawing.Size(174, 61);
            this.btnTelaExclui.TabIndex = 7;
            this.btnTelaExclui.Text = "Excluir um cliente";
            this.btnTelaExclui.UseVisualStyleBackColor = true;
            this.btnTelaExclui.Click += new System.EventHandler(this.btnTelaExclui_Click);
            // 
            // btnListarClientes
            // 
            this.btnListarClientes.Location = new System.Drawing.Point(12, 104);
            this.btnListarClientes.Name = "btnListarClientes";
            this.btnListarClientes.Size = new System.Drawing.Size(174, 61);
            this.btnListarClientes.TabIndex = 8;
            this.btnListarClientes.Text = "Listar Clientes";
            this.btnListarClientes.UseMnemonic = false;
            this.btnListarClientes.UseVisualStyleBackColor = true;
            this.btnListarClientes.Click += new System.EventHandler(this.btnListarClientes_Click);
            // 
            // btnListarClientesOrdenados
            // 
            this.btnListarClientesOrdenados.Location = new System.Drawing.Point(12, 181);
            this.btnListarClientesOrdenados.Name = "btnListarClientesOrdenados";
            this.btnListarClientesOrdenados.Size = new System.Drawing.Size(174, 61);
            this.btnListarClientesOrdenados.TabIndex = 9;
            this.btnListarClientesOrdenados.Text = "Listar Clientes Ordenados";
            this.btnListarClientesOrdenados.UseMnemonic = false;
            this.btnListarClientesOrdenados.UseVisualStyleBackColor = true;
            this.btnListarClientesOrdenados.Click += new System.EventHandler(this.btnListarClientesOrdenados_Click);
            // 
            // frmOpcoesClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 429);
            this.Controls.Add(this.btnListarClientesOrdenados);
            this.Controls.Add(this.btnListarClientes);
            this.Controls.Add(this.btnTelaExclui);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnCadastrarCliente);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmOpcoesClientes";
            this.Text = "Opcoes para Clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarCliente;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnTelaExclui;
        private System.Windows.Forms.Button btnListarClientes;
        private System.Windows.Forms.Button btnListarClientesOrdenados;
    }
}