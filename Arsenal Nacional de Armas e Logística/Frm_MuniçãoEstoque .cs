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
    public partial class Frm_MuniçãoEstoque : Form
    {
        Util Utilidade = new Util();

        public Frm_MuniçãoEstoque()
        {
            InitializeComponent();
            txt_Energia.ReadOnly = true;
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
        private void txt_Peso_Enter(object sender, EventArgs e)
        {
            Utilidade.modificarTextoPlaceholder(ref txt_Peso, "Peso em gramas", true);
            Utilidade.adicionarUnidadeDeMedida(ref txt_Peso, "Peso em gramas", "g", true);
        }


        private void txt_Peso_Leave(object sender, EventArgs e)
        {
            Utilidade.modificarTextoPlaceholder(ref txt_Peso, "Peso em gramas", false);
            Utilidade.adicionarUnidadeDeMedida(ref txt_Peso, "Peso em gramas", "g", false);
        }

        private void txt_Velocidade_Enter(object sender, EventArgs e)
        {
            Utilidade.modificarTextoPlaceholder(ref txt_Velocidade, "Velocidade em m/s", true);
            Utilidade.adicionarUnidadeDeMedida(ref txt_Velocidade, "Velocidade em m/s", "m/s", true);
        }
        private void txt_Velocidade_Leave(object sender, EventArgs e)
        {
            Utilidade.modificarTextoPlaceholder(ref txt_Velocidade, "Velocidade em m/s", false);
            Utilidade.adicionarUnidadeDeMedida(ref txt_Velocidade, "Velocidade em m/s", "m/s", false);
        }
        private void txt_Velocidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidade.aceitarSomenteNumeros(sender, e);
        }
        private void txt_Peso_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidade.aceitarSomenteNumeros(sender, e);
        }


    }
}
