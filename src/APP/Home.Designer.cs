namespace APP
{
    partial class Home
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
            this.pnlRoot = new System.Windows.Forms.Panel();
            this.pnlConteudoXml = new System.Windows.Forms.Panel();
            this.txtRConteudoXml = new System.Windows.Forms.RichTextBox();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lblXml = new System.Windows.Forms.Label();
            this.pnlOpcoes = new System.Windows.Forms.Panel();
            this.cboOpcaoAmbiente = new System.Windows.Forms.ComboBox();
            this.lblAmbiente = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pnlRoot.SuspendLayout();
            this.pnlConteudoXml.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            this.pnlOpcoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRoot
            // 
            this.pnlRoot.Controls.Add(this.pnlConteudoXml);
            this.pnlRoot.Controls.Add(this.pnlBotoes);
            this.pnlRoot.Controls.Add(this.lblXml);
            this.pnlRoot.Controls.Add(this.pnlOpcoes);
            this.pnlRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRoot.Location = new System.Drawing.Point(0, 0);
            this.pnlRoot.Name = "pnlRoot";
            this.pnlRoot.Size = new System.Drawing.Size(384, 561);
            this.pnlRoot.TabIndex = 0;
            // 
            // pnlConteudoXml
            // 
            this.pnlConteudoXml.Controls.Add(this.txtRConteudoXml);
            this.pnlConteudoXml.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConteudoXml.Location = new System.Drawing.Point(0, 133);
            this.pnlConteudoXml.Name = "pnlConteudoXml";
            this.pnlConteudoXml.Size = new System.Drawing.Size(384, 362);
            this.pnlConteudoXml.TabIndex = 1;
            // 
            // txtRConteudoXml
            // 
            this.txtRConteudoXml.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRConteudoXml.Location = new System.Drawing.Point(0, 0);
            this.txtRConteudoXml.Name = "txtRConteudoXml";
            this.txtRConteudoXml.Size = new System.Drawing.Size(384, 362);
            this.txtRConteudoXml.TabIndex = 0;
            this.txtRConteudoXml.Text = "";
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Controls.Add(this.btnFechar);
            this.pnlBotoes.Controls.Add(this.btnEnviar);
            this.pnlBotoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotoes.Location = new System.Drawing.Point(0, 495);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.pnlBotoes.Size = new System.Drawing.Size(384, 66);
            this.pnlBotoes.TabIndex = 3;
            // 
            // btnFechar
            // 
            this.btnFechar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFechar.Location = new System.Drawing.Point(0, 33);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(384, 30);
            this.btnFechar.TabIndex = 8;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEnviar.Location = new System.Drawing.Point(0, 3);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(384, 30);
            this.btnEnviar.TabIndex = 7;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            // 
            // lblXml
            // 
            this.lblXml.AutoSize = true;
            this.lblXml.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblXml.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblXml.Location = new System.Drawing.Point(0, 118);
            this.lblXml.Name = "lblXml";
            this.lblXml.Size = new System.Drawing.Size(35, 15);
            this.lblXml.TabIndex = 2;
            this.lblXml.Text = "XML:";
            // 
            // pnlOpcoes
            // 
            this.pnlOpcoes.Controls.Add(this.cboOpcaoAmbiente);
            this.pnlOpcoes.Controls.Add(this.lblAmbiente);
            this.pnlOpcoes.Controls.Add(this.txtSenha);
            this.pnlOpcoes.Controls.Add(this.lblSenha);
            this.pnlOpcoes.Controls.Add(this.txtUsuario);
            this.pnlOpcoes.Controls.Add(this.lblUsuario);
            this.pnlOpcoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOpcoes.Location = new System.Drawing.Point(0, 0);
            this.pnlOpcoes.Name = "pnlOpcoes";
            this.pnlOpcoes.Size = new System.Drawing.Size(384, 118);
            this.pnlOpcoes.TabIndex = 0;
            // 
            // cboOpcaoAmbiente
            // 
            this.cboOpcaoAmbiente.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboOpcaoAmbiente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOpcaoAmbiente.FormattingEnabled = true;
            this.cboOpcaoAmbiente.Location = new System.Drawing.Point(0, 91);
            this.cboOpcaoAmbiente.Name = "cboOpcaoAmbiente";
            this.cboOpcaoAmbiente.Size = new System.Drawing.Size(384, 23);
            this.cboOpcaoAmbiente.TabIndex = 5;
            // 
            // lblAmbiente
            // 
            this.lblAmbiente.AutoSize = true;
            this.lblAmbiente.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAmbiente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAmbiente.Location = new System.Drawing.Point(0, 76);
            this.lblAmbiente.Name = "lblAmbiente";
            this.lblAmbiente.Size = new System.Drawing.Size(65, 15);
            this.lblAmbiente.TabIndex = 4;
            this.lblAmbiente.Text = "Ambiente:";
            // 
            // txtSenha
            // 
            this.txtSenha.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSenha.Location = new System.Drawing.Point(0, 53);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(384, 23);
            this.txtSenha.TabIndex = 3;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSenha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSenha.Location = new System.Drawing.Point(0, 38);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(44, 15);
            this.lblSenha.TabIndex = 1;
            this.lblSenha.Text = "Senha:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtUsuario.Location = new System.Drawing.Point(0, 15);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(384, 23);
            this.txtUsuario.TabIndex = 2;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsuario.Location = new System.Drawing.Point(0, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(52, 15);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuário:";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.pnlRoot);
            this.Name = "Home";
            this.Text = "Home";
            this.pnlRoot.ResumeLayout(false);
            this.pnlRoot.PerformLayout();
            this.pnlConteudoXml.ResumeLayout(false);
            this.pnlBotoes.ResumeLayout(false);
            this.pnlOpcoes.ResumeLayout(false);
            this.pnlOpcoes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlRoot;
        private Panel pnlOpcoes;
        private Label lblUsuario;
        private Label lblSenha;
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Label lblAmbiente;
        private ComboBox cboOpcaoAmbiente;
        private Label lblXml;
        private Panel pnlConteudoXml;
        private RichTextBox txtRConteudoXml;
        private Panel pnlBotoes;
        private Button btnFechar;
        private Button btnEnviar;
    }
}