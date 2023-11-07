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
            this.btn_Pesquisar = new System.Windows.Forms.Button();
            this.dgv_Armas = new System.Windows.Forms.DataGridView();
            this.txt_Pesquisa = new System.Windows.Forms.TextBox();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_Cartucho = new System.Windows.Forms.TextBox();
            this.lbl_Cartucho = new System.Windows.Forms.Label();
            this.txt_Cadencia = new System.Windows.Forms.TextBox();
            this.lbl_Cadência = new System.Windows.Forms.Label();
            this.lbl_TipoMunição = new System.Windows.Forms.Label();
            this.cmb_Munição = new System.Windows.Forms.ComboBox();
            this.lbl_Data = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_CódigoSerial = new System.Windows.Forms.Label();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Deletar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.mns_Menu.SuspendLayout();
            this.ssr_Footer.SuspendLayout();
            this.grp_TelaEstoque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Armas)).BeginInit();
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
            this.mns_Menu.Size = new System.Drawing.Size(1070, 30);
            this.mns_Menu.TabIndex = 10;
            this.mns_Menu.Text = "menuStrip1";
            // 
            // tsmi_Cadastro
            // 
            this.tsmi_Cadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeArmasToolStripMenuItem,
            this.cadastroDeMuniçõesToolStripMenuItem});
            this.tsmi_Cadastro.Name = "tsmi_Cadastro";
            this.tsmi_Cadastro.Size = new System.Drawing.Size(82, 26);
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
            this.tsmi_Home.Size = new System.Drawing.Size(62, 26);
            this.tsmi_Home.Text = "Voltar";
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
            this.grp_TelaEstoque.Controls.Add(this.btn_Cancelar);
            this.grp_TelaEstoque.Controls.Add(this.btn_Deletar);
            this.grp_TelaEstoque.Controls.Add(this.btn_Editar);
            this.grp_TelaEstoque.Controls.Add(this.textBox1);
            this.grp_TelaEstoque.Controls.Add(this.lbl_CódigoSerial);
            this.grp_TelaEstoque.Controls.Add(this.btn_Cadastrar);
            this.grp_TelaEstoque.Controls.Add(this.dateTimePicker1);
            this.grp_TelaEstoque.Controls.Add(this.lbl_Data);
            this.grp_TelaEstoque.Controls.Add(this.cmb_Munição);
            this.grp_TelaEstoque.Controls.Add(this.lbl_TipoMunição);
            this.grp_TelaEstoque.Controls.Add(this.txt_Cadencia);
            this.grp_TelaEstoque.Controls.Add(this.lbl_Cadência);
            this.grp_TelaEstoque.Controls.Add(this.txt_Cartucho);
            this.grp_TelaEstoque.Controls.Add(this.lbl_Cartucho);
            this.grp_TelaEstoque.Controls.Add(this.txt_Nome);
            this.grp_TelaEstoque.Controls.Add(this.lbl_Nome);
            this.grp_TelaEstoque.Controls.Add(this.btn_Pesquisar);
            this.grp_TelaEstoque.Controls.Add(this.dgv_Armas);
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
            // btn_Pesquisar
            // 
            this.btn_Pesquisar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Pesquisar.BackgroundImage = global::Arsenal_Nacional_de_Armas_e_Logística.Properties.Resources.Pesquisar;
            this.btn_Pesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Pesquisar.Location = new System.Drawing.Point(929, 187);
            this.btn_Pesquisar.Name = "btn_Pesquisar";
            this.btn_Pesquisar.Size = new System.Drawing.Size(26, 26);
            this.btn_Pesquisar.TabIndex = 14;
            this.btn_Pesquisar.UseVisualStyleBackColor = true;
            // 
            // dgv_Armas
            // 
            this.dgv_Armas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_Armas.BackgroundColor = System.Drawing.Color.DarkGreen;
            this.dgv_Armas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Armas.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_Armas.Location = new System.Drawing.Point(29, 228);
            this.dgv_Armas.Name = "dgv_Armas";
            this.dgv_Armas.RowHeadersWidth = 51;
            this.dgv_Armas.RowTemplate.Height = 24;
            this.dgv_Armas.Size = new System.Drawing.Size(926, 206);
            this.dgv_Armas.TabIndex = 13;
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
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nome.Location = new System.Drawing.Point(26, 27);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(47, 19);
            this.lbl_Nome.TabIndex = 15;
            this.lbl_Nome.Text = "Nome";
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
            this.txt_Cartucho.Enter += new System.EventHandler(this.txt_Cartucho_Enter);
            this.txt_Cartucho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Cartucho_KeyPress);
            this.txt_Cartucho.Leave += new System.EventHandler(this.txt_Cartucho_Leave);
            // 
            // lbl_Cartucho
            // 
            this.lbl_Cartucho.AutoSize = true;
            this.lbl_Cartucho.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cartucho.Location = new System.Drawing.Point(199, 27);
            this.lbl_Cartucho.Name = "lbl_Cartucho";
            this.lbl_Cartucho.Size = new System.Drawing.Size(144, 19);
            this.lbl_Cartucho.TabIndex = 18;
            this.lbl_Cartucho.Text = "Tamanho de cartucho";
            // 
            // txt_Cadencia
            // 
            this.txt_Cadencia.ForeColor = System.Drawing.Color.DimGray;
            this.txt_Cadencia.Location = new System.Drawing.Point(393, 49);
            this.txt_Cadencia.Name = "txt_Cadencia";
            this.txt_Cadencia.Size = new System.Drawing.Size(154, 22);
            this.txt_Cadencia.TabIndex = 21;
            this.txt_Cadencia.Text = "Tiros por segundo aqui...";
            this.txt_Cadencia.Enter += new System.EventHandler(this.txt_Cadencia_Enter);
            this.txt_Cadencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Cadencia_KeyPress);
            this.txt_Cadencia.Leave += new System.EventHandler(this.txt_Cadencia_Leave);
            // 
            // lbl_Cadência
            // 
            this.lbl_Cadência.AutoSize = true;
            this.lbl_Cadência.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cadência.Location = new System.Drawing.Point(390, 27);
            this.lbl_Cadência.Name = "lbl_Cadência";
            this.lbl_Cadência.Size = new System.Drawing.Size(109, 19);
            this.lbl_Cadência.TabIndex = 20;
            this.lbl_Cadência.Text = "Cadência de tiro";
            // 
            // lbl_TipoMunição
            // 
            this.lbl_TipoMunição.AutoSize = true;
            this.lbl_TipoMunição.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TipoMunição.Location = new System.Drawing.Point(572, 27);
            this.lbl_TipoMunição.Name = "lbl_TipoMunição";
            this.lbl_TipoMunição.Size = new System.Drawing.Size(111, 19);
            this.lbl_TipoMunição.TabIndex = 22;
            this.lbl_TipoMunição.Text = "Tipo de munição";
            // 
            // cmb_Munição
            // 
            this.cmb_Munição.FormattingEnabled = true;
            this.cmb_Munição.Location = new System.Drawing.Point(576, 49);
            this.cmb_Munição.Name = "cmb_Munição";
            this.cmb_Munição.Size = new System.Drawing.Size(134, 24);
            this.cmb_Munição.TabIndex = 24;
            this.cmb_Munição.SelectedIndexChanged += new System.EventHandler(this.cmb_Munição_SelectedIndexChanged);
            // 
            // lbl_Data
            // 
            this.lbl_Data.AutoSize = true;
            this.lbl_Data.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Data.Location = new System.Drawing.Point(739, 27);
            this.lbl_Data.Name = "lbl_Data";
            this.lbl_Data.Size = new System.Drawing.Size(125, 19);
            this.lbl_Data.TabIndex = 25;
            this.lbl_Data.Text = "Data de fabricação";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(743, 49);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 27;
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.BackColor = System.Drawing.Color.Green;
            this.btn_Cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cadastrar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Cadastrar.Location = new System.Drawing.Point(30, 137);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(147, 32);
            this.btn_Cadastrar.TabIndex = 28;
            this.btn_Cadastrar.Text = "Cadastrar";
            this.btn_Cadastrar.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 99);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(914, 22);
            this.textBox1.TabIndex = 30;
            // 
            // lbl_CódigoSerial
            // 
            this.lbl_CódigoSerial.AutoSize = true;
            this.lbl_CódigoSerial.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CódigoSerial.Location = new System.Drawing.Point(26, 77);
            this.lbl_CódigoSerial.Name = "lbl_CódigoSerial";
            this.lbl_CódigoSerial.Size = new System.Drawing.Size(88, 19);
            this.lbl_CódigoSerial.TabIndex = 29;
            this.lbl_CódigoSerial.Text = "Código serial";
            // 
            // btn_Editar
            // 
            this.btn_Editar.BackColor = System.Drawing.Color.Olive;
            this.btn_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Editar.Location = new System.Drawing.Point(202, 137);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(163, 32);
            this.btn_Editar.TabIndex = 31;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = false;
            // 
            // btn_Deletar
            // 
            this.btn_Deletar.BackColor = System.Drawing.Color.Maroon;
            this.btn_Deletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Deletar.Location = new System.Drawing.Point(393, 137);
            this.btn_Deletar.Name = "btn_Deletar";
            this.btn_Deletar.Size = new System.Drawing.Size(163, 32);
            this.btn_Deletar.TabIndex = 32;
            this.btn_Deletar.Text = "Deletar";
            this.btn_Deletar.UseVisualStyleBackColor = false;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancelar.Location = new System.Drawing.Point(576, 137);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(163, 32);
            this.btn_Cancelar.TabIndex = 33;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
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
            this.MinimumSize = new System.Drawing.Size(1088, 606);
            this.Name = "Frm_ArmasEstoque";
            this.Text = "Estoque de Armas";
            this.Load += new System.EventHandler(this.Frm_ArmasEstoque_Load);
            this.mns_Menu.ResumeLayout(false);
            this.mns_Menu.PerformLayout();
            this.ssr_Footer.ResumeLayout(false);
            this.ssr_Footer.PerformLayout();
            this.grp_TelaEstoque.ResumeLayout(false);
            this.grp_TelaEstoque.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Armas)).EndInit();
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
        private System.Windows.Forms.DataGridView dgv_Armas;
        private System.Windows.Forms.TextBox txt_Pesquisa;
        private System.Windows.Forms.Button btn_Pesquisar;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.TextBox txt_Cartucho;
        private System.Windows.Forms.Label lbl_Cartucho;
        private System.Windows.Forms.TextBox txt_Cadencia;
        private System.Windows.Forms.Label lbl_Cadência;
        private System.Windows.Forms.ComboBox cmb_Munição;
        private System.Windows.Forms.Label lbl_TipoMunição;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbl_Data;
        private System.Windows.Forms.Button btn_Cadastrar;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_CódigoSerial;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Deletar;
    }
}