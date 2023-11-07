using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Arsenal_Nacional_de_Armas_e_Logística
{
    public partial class frm_FormPrincipal : Form
    {
        Util Utilidade = new Util();

        List<System.Windows.Forms.Label> Titulos = new List<System.Windows.
            Forms.Label>();
        PrivateFontCollection pfc = new PrivateFontCollection();
        
        public frm_FormPrincipal()
        {
            InitializeComponent();
            pfc.AddFontFile("C:\\Users\\ferna\\source\\repos\\Arsenal\\Arsenal Nacional de Armas e Logística\\Properties\\Capture it.ttf");
            Titulos.Add(lbl_titulo1);
            Titulos.Add(lbl_titulo2);
            Titulos.Add(lbl_titulo3);
            Utilidade.usarFonteCustomizada(ref Titulos, pfc, 26);
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormTestes_Resize(object sender, EventArgs e)
        {
            pfc.AddFontFile("C:\\Users\\ferna\\source\\repos\\Arsenal\\Arsenal Nacional de Armas e Logística\\Properties\\Capture it.ttf");

            Utilidade.usarFonteCustomizada(ref Titulos, pfc, 26);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btn_Estoque_Click(object sender, EventArgs e)
        {
            Frm_MuniçãoEstoque form = new Frm_MuniçãoEstoque();
            form.ShowDialog();
        }

        private void btn_Armas_Click(object sender, EventArgs e)
        {
            Frm_ArmasEstoque form = new Frm_ArmasEstoque();
            form.ShowDialog();
            
            
        }

        private void cadastroDeArmasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ArmasEstoque form = new Frm_ArmasEstoque();
            form.ShowDialog();
            
        }

        private void cadastroDeMuniçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
