namespace Arsenal_Nacional_de_Armas_e_Logística
{
    partial class Frm_MuniçãoEstoque
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mns_Menu = new System.Windows.Forms.MenuStrip();
            this.tsmi_Cadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Cadastro_Armas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Cadastro_Munições = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Home = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Ajuda = new System.Windows.Forms.ToolStripMenuItem();
            this.ssr_Footer = new System.Windows.Forms.StatusStrip();
            this.slbl_MensagemErro = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslbl_TextoFooter = new System.Windows.Forms.ToolStripStatusLabel();
            this.grp_TelaEstoque = new System.Windows.Forms.GroupBox();
            this.txt_Energia = new System.Windows.Forms.TextBox();
            this.lbl_Energia = new System.Windows.Forms.Label();
            this.txt_Calibre = new System.Windows.Forms.TextBox();
            this.lbl_Calibre = new System.Windows.Forms.Label();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Deletar = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.txt_Velocidade = new System.Windows.Forms.TextBox();
            this.lbl_Velocidade = new System.Windows.Forms.Label();
            this.txt_Peso = new System.Windows.Forms.TextBox();
            this.lbl_Peso = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.btn_Pesquisar = new System.Windows.Forms.Button();
            this.dgv_Munições = new System.Windows.Forms.DataGridView();
            this.txt_Pesquisa = new System.Windows.Forms.TextBox();
            this.mns_Menu.SuspendLayout();
            this.ssr_Footer.SuspendLayout();
            this.grp_TelaEstoque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Munições)).BeginInit();
            this.SuspendLayout();
            // 
            // mns_Menu
            // 
            this.mns_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mns_Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mns_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Cadastro,
            this.tsmi_Home,
            this.tsmi_Ajuda});
            this.mns_Menu.Location = new System.Drawing.Point(0, 0);
            this.mns_Menu.Name = "mns_Menu";
            this.mns_Menu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mns_Menu.Size = new System.Drawing.Size(804, 24);
            this.mns_Menu.TabIndex = 10;
            this.mns_Menu.Text = "menuStrip1";
            // 
            // tsmi_Cadastro
            // 
            this.tsmi_Cadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Cadastro_Armas,
            this.tsmi_Cadastro_Munições});
            this.tsmi_Cadastro.Name = "tsmi_Cadastro";
            this.tsmi_Cadastro.Size = new System.Drawing.Size(71, 20);
            this.tsmi_Cadastro.Text = "Cadastros";
            // 
            // tsmi_Cadastro_Armas
            // 
            this.tsmi_Cadastro_Armas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tsmi_Cadastro_Armas.Name = "tsmi_Cadastro_Armas";
            this.tsmi_Cadastro_Armas.Size = new System.Drawing.Size(192, 22);
            this.tsmi_Cadastro_Armas.Text = "Cadastro de Armas";
            this.tsmi_Cadastro_Armas.Click += new System.EventHandler(this.tsmi_Cadastro_Armas_Click);
            // 
            // tsmi_Cadastro_Munições
            // 
            this.tsmi_Cadastro_Munições.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tsmi_Cadastro_Munições.Name = "tsmi_Cadastro_Munições";
            this.tsmi_Cadastro_Munições.Size = new System.Drawing.Size(192, 22);
            this.tsmi_Cadastro_Munições.Text = "Cadastro de Munições";
            // 
            // tsmi_Home
            // 
            this.tsmi_Home.Name = "tsmi_Home";
            this.tsmi_Home.Size = new System.Drawing.Size(49, 20);
            this.tsmi_Home.Text = "Voltar";
            this.tsmi_Home.Click += new System.EventHandler(this.Tsmi_Home_Click);
            // 
            // tsmi_Ajuda
            // 
            this.tsmi_Ajuda.Name = "tsmi_Ajuda";
            this.tsmi_Ajuda.Size = new System.Drawing.Size(50, 20);
            this.tsmi_Ajuda.Text = "Ajuda";
            this.tsmi_Ajuda.Click += new System.EventHandler(this.tsmi_Ajuda_Click);
            // 
            // ssr_Footer
            // 
            this.ssr_Footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ssr_Footer.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssr_Footer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slbl_MensagemErro,
            this.tslbl_TextoFooter});
            this.ssr_Footer.Location = new System.Drawing.Point(0, 439);
            this.ssr_Footer.Name = "ssr_Footer";
            this.ssr_Footer.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.ssr_Footer.Size = new System.Drawing.Size(804, 22);
            this.ssr_Footer.TabIndex = 11;
            // 
            // slbl_MensagemErro
            // 
            this.slbl_MensagemErro.ForeColor = System.Drawing.Color.FloralWhite;
            this.slbl_MensagemErro.Name = "slbl_MensagemErro";
            this.slbl_MensagemErro.Size = new System.Drawing.Size(0, 17);
            // 
            // tslbl_TextoFooter
            // 
            this.tslbl_TextoFooter.ForeColor = System.Drawing.Color.White;
            this.tslbl_TextoFooter.Name = "tslbl_TextoFooter";
            this.tslbl_TextoFooter.Size = new System.Drawing.Size(145, 17);
            this.tslbl_TextoFooter.Text = "Nenhum erro encontrado!";
            // 
            // grp_TelaEstoque
            // 
            this.grp_TelaEstoque.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grp_TelaEstoque.Controls.Add(this.txt_Energia);
            this.grp_TelaEstoque.Controls.Add(this.lbl_Energia);
            this.grp_TelaEstoque.Controls.Add(this.txt_Calibre);
            this.grp_TelaEstoque.Controls.Add(this.lbl_Calibre);
            this.grp_TelaEstoque.Controls.Add(this.btn_Cancelar);
            this.grp_TelaEstoque.Controls.Add(this.btn_Deletar);
            this.grp_TelaEstoque.Controls.Add(this.btn_Editar);
            this.grp_TelaEstoque.Controls.Add(this.btn_Cadastrar);
            this.grp_TelaEstoque.Controls.Add(this.txt_Velocidade);
            this.grp_TelaEstoque.Controls.Add(this.lbl_Velocidade);
            this.grp_TelaEstoque.Controls.Add(this.txt_Peso);
            this.grp_TelaEstoque.Controls.Add(this.lbl_Peso);
            this.grp_TelaEstoque.Controls.Add(this.txt_Nome);
            this.grp_TelaEstoque.Controls.Add(this.lbl_Nome);
            this.grp_TelaEstoque.Controls.Add(this.btn_Pesquisar);
            this.grp_TelaEstoque.Controls.Add(this.dgv_Munições);
            this.grp_TelaEstoque.Controls.Add(this.txt_Pesquisa);
            this.grp_TelaEstoque.ForeColor = System.Drawing.Color.White;
            this.grp_TelaEstoque.Location = new System.Drawing.Point(20, 41);
            this.grp_TelaEstoque.Margin = new System.Windows.Forms.Padding(2);
            this.grp_TelaEstoque.MinimumSize = new System.Drawing.Size(762, 365);
            this.grp_TelaEstoque.Name = "grp_TelaEstoque";
            this.grp_TelaEstoque.Padding = new System.Windows.Forms.Padding(2);
            this.grp_TelaEstoque.Size = new System.Drawing.Size(762, 365);
            this.grp_TelaEstoque.TabIndex = 12;
            this.grp_TelaEstoque.TabStop = false;
            this.grp_TelaEstoque.Text = "Estoque de Munições";
            // 
            // txt_Energia
            // 
            this.txt_Energia.BackColor = System.Drawing.Color.LightGray;
            this.txt_Energia.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_Energia.ForeColor = System.Drawing.Color.Black;
            this.txt_Energia.Location = new System.Drawing.Point(570, 40);
            this.txt_Energia.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Energia.Name = "txt_Energia";
            this.txt_Energia.Size = new System.Drawing.Size(138, 20);
            this.txt_Energia.TabIndex = 37;
            this.txt_Energia.Text = "(Cálculo automático)";
            // 
            // lbl_Energia
            // 
            this.lbl_Energia.AutoSize = true;
            this.lbl_Energia.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Energia.Location = new System.Drawing.Point(567, 22);
            this.lbl_Energia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Energia.Name = "lbl_Energia";
            this.lbl_Energia.Size = new System.Drawing.Size(46, 16);
            this.lbl_Energia.TabIndex = 36;
            this.lbl_Energia.Text = "Energia";
            // 
            // txt_Calibre
            // 
            this.txt_Calibre.Location = new System.Drawing.Point(152, 40);
            this.txt_Calibre.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Calibre.Name = "txt_Calibre";
            this.txt_Calibre.Size = new System.Drawing.Size(123, 20);
            this.txt_Calibre.TabIndex = 35;
            // 
            // lbl_Calibre
            // 
            this.lbl_Calibre.AutoSize = true;
            this.lbl_Calibre.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Calibre.Location = new System.Drawing.Point(149, 22);
            this.lbl_Calibre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Calibre.Name = "lbl_Calibre";
            this.lbl_Calibre.Size = new System.Drawing.Size(43, 16);
            this.lbl_Calibre.TabIndex = 34;
            this.lbl_Calibre.Text = "Calibre";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancelar.Location = new System.Drawing.Point(432, 82);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(122, 26);
            this.btn_Cancelar.TabIndex = 33;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Visible = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // btn_Deletar
            // 
            this.btn_Deletar.BackColor = System.Drawing.Color.Maroon;
            this.btn_Deletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Deletar.Location = new System.Drawing.Point(295, 82);
            this.btn_Deletar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Deletar.Name = "btn_Deletar";
            this.btn_Deletar.Size = new System.Drawing.Size(122, 26);
            this.btn_Deletar.TabIndex = 32;
            this.btn_Deletar.Text = "Deletar";
            this.btn_Deletar.UseVisualStyleBackColor = false;
            this.btn_Deletar.Visible = false;
            this.btn_Deletar.Click += new System.EventHandler(this.Btn_Deletar_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.BackColor = System.Drawing.Color.Olive;
            this.btn_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Editar.Location = new System.Drawing.Point(152, 82);
            this.btn_Editar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(122, 26);
            this.btn_Editar.TabIndex = 31;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = false;
            this.btn_Editar.Visible = false;
            this.btn_Editar.Click += new System.EventHandler(this.Btn_Editar_Click);
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.BackColor = System.Drawing.Color.Green;
            this.btn_Cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cadastrar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Cadastrar.Location = new System.Drawing.Point(22, 82);
            this.btn_Cadastrar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(110, 26);
            this.btn_Cadastrar.TabIndex = 28;
            this.btn_Cadastrar.Text = "Cadastrar";
            this.btn_Cadastrar.UseVisualStyleBackColor = false;
            this.btn_Cadastrar.Click += new System.EventHandler(this.Btn_Cadastrar_Click);
            // 
            // txt_Velocidade
            // 
            this.txt_Velocidade.ForeColor = System.Drawing.Color.DimGray;
            this.txt_Velocidade.Location = new System.Drawing.Point(432, 40);
            this.txt_Velocidade.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Velocidade.Name = "txt_Velocidade";
            this.txt_Velocidade.Size = new System.Drawing.Size(123, 20);
            this.txt_Velocidade.TabIndex = 21;
            this.txt_Velocidade.Text = "Velocidade em m/s";
            this.txt_Velocidade.Enter += new System.EventHandler(this.Txt_Velocidade_Enter);
            this.txt_Velocidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Velocidade_KeyPress);
            this.txt_Velocidade.Leave += new System.EventHandler(this.Txt_Velocidade_Leave);
            // 
            // lbl_Velocidade
            // 
            this.lbl_Velocidade.AutoSize = true;
            this.lbl_Velocidade.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Velocidade.Location = new System.Drawing.Point(429, 22);
            this.lbl_Velocidade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Velocidade.Name = "lbl_Velocidade";
            this.lbl_Velocidade.Size = new System.Drawing.Size(107, 16);
            this.lbl_Velocidade.TabIndex = 20;
            this.lbl_Velocidade.Text = "Velocidade por tiro";
            // 
            // txt_Peso
            // 
            this.txt_Peso.ForeColor = System.Drawing.Color.DimGray;
            this.txt_Peso.Location = new System.Drawing.Point(295, 40);
            this.txt_Peso.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Peso.Name = "txt_Peso";
            this.txt_Peso.Size = new System.Drawing.Size(123, 20);
            this.txt_Peso.TabIndex = 19;
            this.txt_Peso.Text = "Peso em gramas";
            this.txt_Peso.Enter += new System.EventHandler(this.Txt_Peso_Enter);
            this.txt_Peso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Peso_KeyPress);
            this.txt_Peso.Leave += new System.EventHandler(this.Txt_Peso_Leave);
            // 
            // lbl_Peso
            // 
            this.lbl_Peso.AutoSize = true;
            this.lbl_Peso.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Peso.Location = new System.Drawing.Point(292, 22);
            this.lbl_Peso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Peso.Name = "lbl_Peso";
            this.lbl_Peso.Size = new System.Drawing.Size(78, 16);
            this.lbl_Peso.TabIndex = 18;
            this.lbl_Peso.Text = "Peso por bala";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(22, 40);
            this.txt_Nome.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(112, 20);
            this.txt_Nome.TabIndex = 17;
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nome.Location = new System.Drawing.Point(20, 22);
            this.lbl_Nome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(39, 16);
            this.lbl_Nome.TabIndex = 15;
            this.lbl_Nome.Text = "Nome";
            // 
            // btn_Pesquisar
            // 
            this.btn_Pesquisar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Pesquisar.BackgroundImage = global::Arsenal_Nacional_de_Armas_e_Logística.Properties.Resources.Pesquisar;
            this.btn_Pesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Pesquisar.Location = new System.Drawing.Point(697, 123);
            this.btn_Pesquisar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Pesquisar.Name = "btn_Pesquisar";
            this.btn_Pesquisar.Size = new System.Drawing.Size(20, 21);
            this.btn_Pesquisar.TabIndex = 14;
            this.btn_Pesquisar.UseVisualStyleBackColor = true;
            this.btn_Pesquisar.Click += new System.EventHandler(this.Btn_Pesquisar_Click);
            // 
            // dgv_Munições
            // 
            this.dgv_Munições.AllowUserToAddRows = false;
            this.dgv_Munições.AllowUserToDeleteRows = false;
            this.dgv_Munições.AllowUserToOrderColumns = true;
            this.dgv_Munições.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_Munições.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Munições.BackgroundColor = System.Drawing.Color.DarkGreen;
            this.dgv_Munições.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Munições.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Munições.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_Munições.Location = new System.Drawing.Point(22, 156);
            this.dgv_Munições.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_Munições.MultiSelect = false;
            this.dgv_Munições.Name = "dgv_Munições";
            this.dgv_Munições.ReadOnly = true;
            this.dgv_Munições.RowHeadersWidth = 51;
            this.dgv_Munições.RowTemplate.Height = 24;
            this.dgv_Munições.Size = new System.Drawing.Size(694, 193);
            this.dgv_Munições.TabIndex = 13;
            this.dgv_Munições.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Dgv_Munições_RowHeaderMouseClick);
            // 
            // txt_Pesquisa
            // 
            this.txt_Pesquisa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Pesquisa.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Pesquisa.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pesquisa.ForeColor = System.Drawing.Color.DimGray;
            this.txt_Pesquisa.Location = new System.Drawing.Point(22, 123);
            this.txt_Pesquisa.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Pesquisa.Name = "txt_Pesquisa";
            this.txt_Pesquisa.Size = new System.Drawing.Size(672, 22);
            this.txt_Pesquisa.TabIndex = 0;
            this.txt_Pesquisa.Text = "Pesquisar...";
            this.txt_Pesquisa.TextChanged += new System.EventHandler(this.Txt_Pesquisa_TextChanged_1);
            this.txt_Pesquisa.Enter += new System.EventHandler(this.Txt_Pesquisa_Enter);
            this.txt_Pesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Pesquisa_KeyPress);
            this.txt_Pesquisa.Leave += new System.EventHandler(this.Txt_Pesquisa_Leave);
            // 
            // Frm_MuniçãoEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(118)))), ((int)(((byte)(29)))));
            this.BackgroundImage = global::Arsenal_Nacional_de_Armas_e_Logística.Properties.Resources.AK_Logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.grp_TelaEstoque);
            this.Controls.Add(this.ssr_Footer);
            this.Controls.Add(this.mns_Menu);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(819, 499);
            this.Name = "Frm_MuniçãoEstoque";
            this.Text = "Estoque de Munições";
            this.mns_Menu.ResumeLayout(false);
            this.mns_Menu.PerformLayout();
            this.ssr_Footer.ResumeLayout(false);
            this.ssr_Footer.PerformLayout();
            this.grp_TelaEstoque.ResumeLayout(false);
            this.grp_TelaEstoque.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Munições)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mns_Menu;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Cadastro;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Cadastro_Armas;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Cadastro_Munições;
        private System.Windows.Forms.StatusStrip ssr_Footer;
        private System.Windows.Forms.ToolStripStatusLabel slbl_MensagemErro;
        private System.Windows.Forms.ToolStripStatusLabel tslbl_TextoFooter;
        private System.Windows.Forms.GroupBox grp_TelaEstoque;
        private System.Windows.Forms.DataGridView dgv_Munições;
        private System.Windows.Forms.TextBox txt_Pesquisa;
        private System.Windows.Forms.Button btn_Pesquisar;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.TextBox txt_Peso;
        private System.Windows.Forms.Label lbl_Peso;
        private System.Windows.Forms.TextBox txt_Velocidade;
        private System.Windows.Forms.Label lbl_Velocidade;
        private System.Windows.Forms.Button btn_Cadastrar;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Deletar;
        private System.Windows.Forms.TextBox txt_Calibre;
        private System.Windows.Forms.Label lbl_Calibre;
        private System.Windows.Forms.TextBox txt_Energia;
        private System.Windows.Forms.Label lbl_Energia;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Home;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Ajuda;
    }
}