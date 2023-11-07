using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arsenal_Nacional_de_Armas_e_Logística
{
    public partial class Frm_ArmasEstoque : Form
    {
        Util Utilidade = new Util();
        int qtd_car = 0;
        int qtd_cad = 0;

        public Frm_ArmasEstoque()
        {
            InitializeComponent();
        }

        private void txt_Pesquisa_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txt_Pesquisa_Enter(object sender, EventArgs e)
        {
            Utilidade.modificarTextoPlaceholder(ref txt_Pesquisa, "Pesquisar...", true);
        }

        private void txt_Pesquisa_Leave(object sender, EventArgs e)
        {
            Utilidade.modificarTextoPlaceholder(ref txt_Pesquisa, "Pesquisar...", false);
        }


        private void Frm_ArmasEstoque_Load(object sender, EventArgs e)
        {

        }

        private void tsmi_Home_Click(object sender, EventArgs e)
        {
            frm_FormPrincipal form = new frm_FormPrincipal();
            this.Close();
        }

        private void cmb_Munição_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_Cartucho_Enter(object sender, EventArgs e)
        {
            Utilidade.modificarTextoPlaceholder(ref txt_Cartucho, "Balas por cartucho aqui...", true);
            int qtd;
            if (Int32.TryParse(txt_Cartucho.Text, out qtd))
                qtd_car = qtd;
            Utilidade.adicionarUnidadeDeMedida(ref txt_Cartucho, "Balas por cartucho aqui...",
                (qtd_car > 1 ? "balas" : "bala") + " por cartucho", true);
        }

        private void txt_Cartucho_Leave(object sender, EventArgs e)
        {
            Utilidade.modificarTextoPlaceholder(ref txt_Cartucho, "Balas por cartucho aqui...", false);
            int qtd;
            if(Int32.TryParse(txt_Cartucho.Text, out qtd))
                qtd_car = qtd;

            Utilidade.adicionarUnidadeDeMedida(ref txt_Cartucho, "Balas por cartucho aqui...",
                (qtd_car > 1 ? "balas" : "bala") + " por cartucho", false);

        }

        private void txt_Cadencia_Enter(object sender, EventArgs e)
        {
            Utilidade.modificarTextoPlaceholder(ref txt_Cadencia, "Tiros por segundo aqui...", true);
            int qtd;

            if(Int32.TryParse(txt_Cadencia.Text, out qtd))
                qtd_cad = qtd;
            Utilidade.adicionarUnidadeDeMedida(ref txt_Cadencia, "Tiros por segundo aqui...",
                 (qtd_cad > 1 ? "tiros" : "tiro") + " por segundo", true);
        }

        private void txt_Cadencia_Leave(object sender, EventArgs e)
        {
            Utilidade.modificarTextoPlaceholder(ref txt_Cadencia, "Tiros por segundo aqui...", false);
            int qtd;
            if (Int32.TryParse(txt_Cadencia.Text, out qtd))
                qtd_cad = qtd;
            Utilidade.adicionarUnidadeDeMedida(ref txt_Cadencia, "Tiros por segundo aqui...",
                (qtd_cad > 1 ? "tiros" : "tiro") + " por segundo", false);
        }

        private void txt_Cadencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidade.aceitarSomenteNumeros(sender, e);
        }

        private void txt_Cartucho_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidade.aceitarSomenteNumeros(sender, e);
        }
    }
}
