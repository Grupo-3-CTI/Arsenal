namespace Arsenal_Nacional_de_Armas_e_Logística
{
    partial class frm_FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_FormPrincipal));
            this.lbl_titulo1 = new System.Windows.Forms.Label();
            this.lbl_titulo2 = new System.Windows.Forms.Label();
            this.lbl_titulo3 = new System.Windows.Forms.Label();
            this.grp_Opções = new System.Windows.Forms.GroupBox();
            this.btn_Estoque = new System.Windows.Forms.Button();
            this.btn_Armas = new System.Windows.Forms.Button();
            this.mns_Menu = new System.Windows.Forms.MenuStrip();
            this.tsmi_Cadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Cadastro_Armas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Cadastro_Munições = new System.Windows.Forms.ToolStripMenuItem();
            this.ssr_Footer = new System.Windows.Forms.StatusStrip();
            this.slbl_MensagemErro = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslbl_TextoFooter = new System.Windows.Forms.ToolStripStatusLabel();
            this.grp_Opções.SuspendLayout();
            this.mns_Menu.SuspendLayout();
            this.ssr_Footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_titulo1
            // 
            this.lbl_titulo1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_titulo1.AutoSize = true;
            this.lbl_titulo1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo1.ForeColor = System.Drawing.Color.FloralWhite;
            this.lbl_titulo1.Location = new System.Drawing.Point(183, 38);
            this.lbl_titulo1.Name = "lbl_titulo1";
            this.lbl_titulo1.Size = new System.Drawing.Size(466, 51);
            this.lbl_titulo1.TabIndex = 0;
            this.lbl_titulo1.Text = "ARSENAL NACIONAL ";
            this.lbl_titulo1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_titulo2
            // 
            this.lbl_titulo2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_titulo2.AutoSize = true;
            this.lbl_titulo2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo2.ForeColor = System.Drawing.Color.FloralWhite;
            this.lbl_titulo2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_titulo2.Location = new System.Drawing.Point(148, 106);
            this.lbl_titulo2.Name = "lbl_titulo2";
            this.lbl_titulo2.Size = new System.Drawing.Size(527, 51);
            this.lbl_titulo2.TabIndex = 6;
            this.lbl_titulo2.Text = "DE ARMAS E LOGÍSTICA";
            this.lbl_titulo2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_titulo3
            // 
            this.lbl_titulo3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_titulo3.AutoSize = true;
            this.lbl_titulo3.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo3.ForeColor = System.Drawing.Color.FloralWhite;
            this.lbl_titulo3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_titulo3.Location = new System.Drawing.Point(226, 367);
            this.lbl_titulo3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.lbl_titulo3.Name = "lbl_titulo3";
            this.lbl_titulo3.Size = new System.Drawing.Size(386, 51);
            this.lbl_titulo3.TabIndex = 7;
            this.lbl_titulo3.Text = "SEJA BEM-VINDO";
            this.lbl_titulo3.Click += new System.EventHandler(this.label3_Click);
            // 
            // grp_Opções
            // 
            this.grp_Opções.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grp_Opções.Controls.Add(this.btn_Estoque);
            this.grp_Opções.Controls.Add(this.btn_Armas);
            this.grp_Opções.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Opções.ForeColor = System.Drawing.Color.MintCream;
            this.grp_Opções.Location = new System.Drawing.Point(62, 178);
            this.grp_Opções.Name = "grp_Opções";
            this.grp_Opções.Size = new System.Drawing.Size(691, 127);
            this.grp_Opções.TabIndex = 8;
            this.grp_Opções.TabStop = false;
            this.grp_Opções.Text = "Opções";
            // 
            // btn_Estoque
            // 
            this.btn_Estoque.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_Estoque.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Estoque.FlatAppearance.BorderSize = 2;
            this.btn_Estoque.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Estoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Estoque.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Estoque.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_Estoque.Location = new System.Drawing.Point(396, 21);
            this.btn_Estoque.Name = "btn_Estoque";
            this.btn_Estoque.Size = new System.Drawing.Size(191, 100);
            this.btn_Estoque.TabIndex = 1;
            this.btn_Estoque.Text = "Estoque de munições";
            this.btn_Estoque.UseVisualStyleBackColor = false;
            this.btn_Estoque.Click += new System.EventHandler(this.btn_Estoque_Click);
            // 
            // btn_Armas
            // 
            this.btn_Armas.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_Armas.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Armas.FlatAppearance.BorderSize = 2;
            this.btn_Armas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Armas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Armas.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Armas.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_Armas.Location = new System.Drawing.Point(130, 21);
            this.btn_Armas.Name = "btn_Armas";
            this.btn_Armas.Size = new System.Drawing.Size(191, 100);
            this.btn_Armas.TabIndex = 0;
            this.btn_Armas.Text = "Estoque de armas";
            this.btn_Armas.UseVisualStyleBackColor = false;
            this.btn_Armas.Click += new System.EventHandler(this.btn_Armas_Click);
            // 
            // mns_Menu
            // 
            this.mns_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mns_Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mns_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Cadastro});
            this.mns_Menu.Location = new System.Drawing.Point(0, 0);
            this.mns_Menu.Name = "mns_Menu";
            this.mns_Menu.Size = new System.Drawing.Size(800, 28);
            this.mns_Menu.TabIndex = 9;
            this.mns_Menu.Text = "menuStrip1";
            // 
            // tsmi_Cadastro
            // 
            this.tsmi_Cadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Cadastro_Armas,
            this.tsmi_Cadastro_Munições});
            this.tsmi_Cadastro.Name = "tsmi_Cadastro";
            this.tsmi_Cadastro.Size = new System.Drawing.Size(82, 24);
            this.tsmi_Cadastro.Text = "Cadastro";
            // 
            // tsmi_Cadastro_Armas
            // 
            this.tsmi_Cadastro_Armas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tsmi_Cadastro_Armas.Name = "tsmi_Cadastro_Armas";
            this.tsmi_Cadastro_Armas.Size = new System.Drawing.Size(239, 26);
            this.tsmi_Cadastro_Armas.Text = "Cadastro de Armas";
            this.tsmi_Cadastro_Armas.Click += new System.EventHandler(this.cadastroDeArmasToolStripMenuItem_Click);
            // 
            // tsmi_Cadastro_Munições
            // 
            this.tsmi_Cadastro_Munições.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tsmi_Cadastro_Munições.Name = "tsmi_Cadastro_Munições";
            this.tsmi_Cadastro_Munições.Size = new System.Drawing.Size(239, 26);
            this.tsmi_Cadastro_Munições.Text = "Cadastro de Munições";
            this.tsmi_Cadastro_Munições.Click += new System.EventHandler(this.cadastroDeMuniçõesToolStripMenuItem_Click);
            // 
            // ssr_Footer
            // 
            this.ssr_Footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ssr_Footer.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssr_Footer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slbl_MensagemErro,
            this.toolStripStatusLabel1,
            this.tslbl_TextoFooter});
            this.ssr_Footer.Location = new System.Drawing.Point(0, 424);
            this.ssr_Footer.Name = "ssr_Footer";
            this.ssr_Footer.Size = new System.Drawing.Size(800, 26);
            this.ssr_Footer.TabIndex = 12;
            // 
            // slbl_MensagemErro
            // 
            this.slbl_MensagemErro.ForeColor = System.Drawing.Color.FloralWhite;
            this.slbl_MensagemErro.Name = "slbl_MensagemErro";
            this.slbl_MensagemErro.Size = new System.Drawing.Size(0, 20);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ActiveLinkColor = System.Drawing.Color.SaddleBrown;
            this.toolStripStatusLabel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 20);
            // 
            // tslbl_TextoFooter
            // 
            this.tslbl_TextoFooter.ForeColor = System.Drawing.Color.White;
            this.tslbl_TextoFooter.Name = "tslbl_TextoFooter";
            this.tslbl_TextoFooter.Size = new System.Drawing.Size(180, 20);
            this.tslbl_TextoFooter.Text = "Nenhum erro encontrado!";
            // 
            // frm_FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(118)))), ((int)(((byte)(29)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ssr_Footer);
            this.Controls.Add(this.grp_Opções);
            this.Controls.Add(this.lbl_titulo3);
            this.Controls.Add(this.lbl_titulo2);
            this.Controls.Add(this.lbl_titulo1);
            this.Controls.Add(this.mns_Menu);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.mns_Menu;
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "frm_FormPrincipal";
            this.Text = "Form Principal";
            this.Resize += new System.EventHandler(this.FormTestes_Resize);
            this.grp_Opções.ResumeLayout(false);
            this.mns_Menu.ResumeLayout(false);
            this.mns_Menu.PerformLayout();
            this.ssr_Footer.ResumeLayout(false);
            this.ssr_Footer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo1;
        private System.Windows.Forms.Label lbl_titulo2;
        private System.Windows.Forms.Label lbl_titulo3;
        private System.Windows.Forms.GroupBox grp_Opções;
        private System.Windows.Forms.Button btn_Armas;
        private System.Windows.Forms.Button btn_Estoque;
        private System.Windows.Forms.MenuStrip mns_Menu;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Cadastro;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Cadastro_Armas;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Cadastro_Munições;
        private System.Windows.Forms.StatusStrip ssr_Footer;
        private System.Windows.Forms.ToolStripStatusLabel slbl_MensagemErro;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tslbl_TextoFooter;
    }
}