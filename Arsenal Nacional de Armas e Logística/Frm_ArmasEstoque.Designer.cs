namespace Arsenal_Nacional_de_Armas_e_Logística
{
    partial class Frm_ArmasEstoque
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
            this.mns_Menu = new System.Windows.Forms.MenuStrip();
            this.tsmi_Cadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeArmasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeMuniçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Home = new System.Windows.Forms.ToolStripMenuItem();
            this.ssr_Footer = new System.Windows.Forms.StatusStrip();
            this.slbl_MensagemErro = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslbl_TextoFooter = new System.Windows.Forms.ToolStripStatusLabel();
            this.grp_TelaEstoque = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_Pesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_Cartucho = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Cadencia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.mns_Menu.SuspendLayout();
            this.ssr_Footer.SuspendLayout();
            this.grp_TelaEstoque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mns_Menu
            // 
            this.mns_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mns_Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mns_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Cadastro,
            this.tsmi_Home});
            this.mns_Menu.Location = new System.Drawing.Point(0, 0);
            this.mns_Menu.Name = "mns_Menu";
            this.mns_Menu.Size = new System.Drawing.Size(1070, 28);
            this.mns_Menu.TabIndex = 10;
            this.mns_Menu.Text = "menuStrip1";
            // 
            // tsmi_Cadastro
            // 
            this.tsmi_Cadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeArmasToolStripMenuItem,
            this.cadastroDeMuniçõesToolStripMenuItem});
            this.tsmi_Cadastro.Name = "tsmi_Cadastro";
            this.tsmi_Cadastro.Size = new System.Drawing.Size(82, 24);
            this.tsmi_Cadastro.Text = "Cadastro";
            // 
            // cadastroDeArmasToolStripMenuItem
            // 
            this.cadastroDeArmasToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cadastroDeArmasToolStripMenuItem.Name = "cadastroDeArmasToolStripMenuItem";
            this.cadastroDeArmasToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.cadastroDeArmasToolStripMenuItem.Text = "Cadastro de Armas";
            // 
            // cadastroDeMuniçõesToolStripMenuItem
            // 
            this.cadastroDeMuniçõesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cadastroDeMuniçõesToolStripMenuItem.Name = "cadastroDeMuniçõesToolStripMenuItem";
            this.cadastroDeMuniçõesToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.cadastroDeMuniçõesToolStripMenuItem.Text = "Cadastro de Munições";
            // 
            // tsmi_Home
            // 
            this.tsmi_Home.Name = "tsmi_Home";
            this.tsmi_Home.Size = new System.Drawing.Size(64, 24);
            this.tsmi_Home.Text = "Home";
            this.tsmi_Home.Click += new System.EventHandler(this.tsmi_Home_Click);
            // 
            // ssr_Footer
            // 
            this.ssr_Footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ssr_Footer.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssr_Footer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slbl_MensagemErro,
            this.tslbl_TextoFooter});
            this.ssr_Footer.Location = new System.Drawing.Point(0, 533);
            this.ssr_Footer.Name = "ssr_Footer";
            this.ssr_Footer.Size = new System.Drawing.Size(1070, 26);
            this.ssr_Footer.TabIndex = 11;
            // 
            // slbl_MensagemErro
            // 
            this.slbl_MensagemErro.ForeColor = System.Drawing.Color.FloralWhite;
            this.slbl_MensagemErro.Name = "slbl_MensagemErro";
            this.slbl_MensagemErro.Size = new System.Drawing.Size(0, 20);
            // 
            // tslbl_TextoFooter
            // 
            this.tslbl_TextoFooter.ForeColor = System.Drawing.Color.White;
            this.tslbl_TextoFooter.Name = "tslbl_TextoFooter";
            this.tslbl_TextoFooter.Size = new System.Drawing.Size(180, 20);
            this.tslbl_TextoFooter.Text = "Nenhum erro encontrado!";
            // 
            // grp_TelaEstoque
            // 
            this.grp_TelaEstoque.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grp_TelaEstoque.Controls.Add(this.comboBox1);
            this.grp_TelaEstoque.Controls.Add(this.txt_Cadencia);
            this.grp_TelaEstoque.Controls.Add(this.label3);
            this.grp_TelaEstoque.Controls.Add(this.txt_Cartucho);
            this.grp_TelaEstoque.Controls.Add(this.label2);
            this.grp_TelaEstoque.Controls.Add(this.txt_Nome);
            this.grp_TelaEstoque.Controls.Add(this.label1);
            this.grp_TelaEstoque.Controls.Add(this.button1);
            this.grp_TelaEstoque.Controls.Add(this.dataGridView1);
            this.grp_TelaEstoque.Controls.Add(this.txt_Pesquisa);
            this.grp_TelaEstoque.ForeColor = System.Drawing.Color.White;
            this.grp_TelaEstoque.Location = new System.Drawing.Point(27, 50);
            this.grp_TelaEstoque.MinimumSize = new System.Drawing.Size(1016, 449);
            this.grp_TelaEstoque.Name = "grp_TelaEstoque";
            this.grp_TelaEstoque.Size = new System.Drawing.Size(1016, 449);
            this.grp_TelaEstoque.TabIndex = 12;
            this.grp_TelaEstoque.TabStop = false;
            this.grp_TelaEstoque.Text = "Estoque de Armas";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackgroundImage = global::Arsenal_Nacional_de_Armas_e_Logística.Properties.Resources.Pesquisar;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(929, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 26);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkGreen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(29, 228);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(926, 206);
            this.dataGridView1.TabIndex = 13;
            // 
            // txt_Pesquisa
            // 
            this.txt_Pesquisa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Pesquisa.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Pesquisa.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pesquisa.ForeColor = System.Drawing.Color.DimGray;
            this.txt_Pesquisa.Location = new System.Drawing.Point(29, 187);
            this.txt_Pesquisa.Name = "txt_Pesquisa";
            this.txt_Pesquisa.Size = new System.Drawing.Size(894, 26);
            this.txt_Pesquisa.TabIndex = 0;
            this.txt_Pesquisa.Text = "Pesquisar...";
            this.txt_Pesquisa.TextChanged += new System.EventHandler(this.txt_Pesquisa_TextChanged_1);
            this.txt_Pesquisa.Enter += new System.EventHandler(this.txt_Pesquisa_Enter);
            this.txt_Pesquisa.Leave += new System.EventHandler(this.txt_Pesquisa_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nome:";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(29, 49);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(148, 22);
            this.txt_Nome.TabIndex = 17;
            // 
            // txt_Cartucho
            // 
            this.txt_Cartucho.ForeColor = System.Drawing.Color.DimGray;
            this.txt_Cartucho.Location = new System.Drawing.Point(202, 49);
            this.txt_Cartucho.Name = "txt_Cartucho";
            this.txt_Cartucho.Size = new System.Drawing.Size(163, 22);
            this.txt_Cartucho.TabIndex = 19;
            this.txt_Cartucho.Text = "Balas por cartucho aqui...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(199, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tamanho de cartucho";
            // 
            // txt_Cadencia
            // 
            this.txt_Cadencia.ForeColor = System.Drawing.Color.DimGray;
            this.txt_Cadencia.Location = new System.Drawing.Point(393, 49);
            this.txt_Cadencia.Name = "txt_Cadencia";
            this.txt_Cadencia.Size = new System.Drawing.Size(154, 22);
            this.txt_Cadencia.TabIndex = 21;
            this.txt_Cadencia.Text = "Tiros por segundo aqui...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(390, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "Cadência de tiro";
            // 
            // comboBox1
            // 
            this.comboBox1.Location = new System.Drawing.Point(639, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Frm_ArmasEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(118)))), ((int)(((byte)(29)))));
            this.BackgroundImage = global::Arsenal_Nacional_de_Armas_e_Logística.Properties.Resources.AK_Logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1070, 559);
            this.Controls.Add(this.grp_TelaEstoque);
            this.Controls.Add(this.ssr_Footer);
            this.Controls.Add(this.mns_Menu);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "Frm_ArmasEstoque";
            this.Text = "Estoque de Armas";
            this.Load += new System.EventHandler(this.Frm_ArmasEstoque_Load);
            this.mns_Menu.ResumeLayout(false);
            this.mns_Menu.PerformLayout();
            this.ssr_Footer.ResumeLayout(false);
            this.ssr_Footer.PerformLayout();
            this.grp_TelaEstoque.ResumeLayout(false);
            this.grp_TelaEstoque.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mns_Menu;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Cadastro;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeArmasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeMuniçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Home;
        private System.Windows.Forms.StatusStrip ssr_Footer;
        private System.Windows.Forms.ToolStripStatusLabel slbl_MensagemErro;
        private System.Windows.Forms.ToolStripStatusLabel tslbl_TextoFooter;
        private System.Windows.Forms.GroupBox grp_TelaEstoque;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_Pesquisa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Cartucho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Cadencia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}