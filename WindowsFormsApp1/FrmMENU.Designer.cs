namespace WindowsFormsApp1
{
    partial class FormMENU
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.cadastroMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.novoCadastroMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.prospectMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatoriomenu = new System.Windows.Forms.ToolStripMenuItem();
            this.analiticoPendênciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monitoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produçãoDiáriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbMensagem = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btOK = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.menuPrincipal.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroMenu,
            this.consultaMenu,
            this.relatoriomenu,
            this.sairMenu});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(1202, 24);
            this.menuPrincipal.TabIndex = 2;
            this.menuPrincipal.Text = "MenuPrincipal";
            this.menuPrincipal.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuPrincipal_ItemClicked);
            // 
            // cadastroMenu
            // 
            this.cadastroMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoCadastroMenu});
            this.cadastroMenu.Name = "cadastroMenu";
            this.cadastroMenu.Size = new System.Drawing.Size(66, 20);
            this.cadastroMenu.Text = "Cadastro";
            this.cadastroMenu.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // novoCadastroMenu
            // 
            this.novoCadastroMenu.Name = "novoCadastroMenu";
            this.novoCadastroMenu.Size = new System.Drawing.Size(180, 22);
            this.novoCadastroMenu.Text = "Novo Cadastro";
            this.novoCadastroMenu.Click += new System.EventHandler(this.novoCadastroMenu_Click);
            // 
            // consultaMenu
            // 
            this.consultaMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prospectMenu,
            this.usuáriosToolStripMenuItem});
            this.consultaMenu.Name = "consultaMenu";
            this.consultaMenu.Size = new System.Drawing.Size(96, 20);
            this.consultaMenu.Text = "Administração";
            this.consultaMenu.Click += new System.EventHandler(this.consultaToolStripMenuItem_Click);
            // 
            // prospectMenu
            // 
            this.prospectMenu.Name = "prospectMenu";
            this.prospectMenu.Size = new System.Drawing.Size(180, 22);
            this.prospectMenu.Text = "Importação";
            this.prospectMenu.Click += new System.EventHandler(this.prospectMenu_Click);
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            this.usuáriosToolStripMenuItem.Click += new System.EventHandler(this.usuáriosToolStripMenuItem_Click);
            // 
            // relatoriomenu
            // 
            this.relatoriomenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.analiticoPendênciasToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.monitoriaToolStripMenuItem,
            this.produçãoDiáriaToolStripMenuItem});
            this.relatoriomenu.Name = "relatoriomenu";
            this.relatoriomenu.Size = new System.Drawing.Size(71, 20);
            this.relatoriomenu.Text = "Relatórios";
            // 
            // analiticoPendênciasToolStripMenuItem
            // 
            this.analiticoPendênciasToolStripMenuItem.Name = "analiticoPendênciasToolStripMenuItem";
            this.analiticoPendênciasToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.analiticoPendênciasToolStripMenuItem.Text = "Analitico Pendências";
            this.analiticoPendênciasToolStripMenuItem.Click += new System.EventHandler(this.analiticoPendênciasToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.reportToolStripMenuItem.Text = "Hora a Hora";
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // monitoriaToolStripMenuItem
            // 
            this.monitoriaToolStripMenuItem.Name = "monitoriaToolStripMenuItem";
            this.monitoriaToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.monitoriaToolStripMenuItem.Text = "Monitoria";
            this.monitoriaToolStripMenuItem.Click += new System.EventHandler(this.monitoriaToolStripMenuItem_Click);
            // 
            // produçãoDiáriaToolStripMenuItem
            // 
            this.produçãoDiáriaToolStripMenuItem.Name = "produçãoDiáriaToolStripMenuItem";
            this.produçãoDiáriaToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.produçãoDiáriaToolStripMenuItem.Text = "Produção Diária";
            this.produçãoDiáriaToolStripMenuItem.Click += new System.EventHandler(this.produçãoDiáriaToolStripMenuItem_Click);
            // 
            // sairMenu
            // 
            this.sairMenu.Name = "sairMenu";
            this.sairMenu.Size = new System.Drawing.Size(38, 20);
            this.sairMenu.Text = "Sair";
            this.sairMenu.Click += new System.EventHandler(this.sairMenu_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbMensagem);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btOK);
            this.panel1.Controls.Add(this.txtSenha);
            this.panel1.Controls.Add(this.txtLogin);
            this.panel1.Location = new System.Drawing.Point(484, 163);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 157);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbMensagem
            // 
            this.lbMensagem.AutoSize = true;
            this.lbMensagem.ForeColor = System.Drawing.Color.Red;
            this.lbMensagem.Location = new System.Drawing.Point(98, 10);
            this.lbMensagem.Name = "lbMensagem";
            this.lbMensagem.Size = new System.Drawing.Size(99, 13);
            this.lbMensagem.TabIndex = 5;
            this.lbMensagem.Text = "ACESSO NEGADO";
            this.lbMensagem.Visible = false;
            this.lbMensagem.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Senha";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(98, 113);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(99, 30);
            this.btOK.TabIndex = 2;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(64, 84);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(173, 20);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSenha.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(64, 46);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(173, 20);
            this.txtLogin.TabIndex = 0;
            this.txtLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLogin.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FormMENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 362);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "FormMENU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TIM - Warm Brasil";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMENU_Load);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem cadastroMenu;
        private System.Windows.Forms.ToolStripMenuItem novoCadastroMenu;
        private System.Windows.Forms.ToolStripMenuItem consultaMenu;
        private System.Windows.Forms.ToolStripMenuItem prospectMenu;
        private System.Windows.Forms.ToolStripMenuItem sairMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbMensagem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatoriomenu;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analiticoPendênciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produçãoDiáriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monitoriaToolStripMenuItem;
    }
}

