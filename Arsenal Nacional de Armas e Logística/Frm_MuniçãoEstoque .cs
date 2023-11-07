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
        int energia;
        string texto;

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
            tentarCalcularEnergia();
            Utilidade.adicionarUnidadeDeMedida(ref txt_Peso, "Peso em gramas", "g", true);
        }


        private void txt_Peso_Leave(object sender, EventArgs e)
        {
            Utilidade.modificarTextoPlaceholder(ref txt_Peso, "Peso em gramas", false);
            tentarCalcularEnergia();
            Utilidade.adicionarUnidadeDeMedida(ref txt_Peso, "Peso em gramas", "g", false);
        }

        private void txt_Velocidade_Enter(object sender, EventArgs e)
        {
            Utilidade.modificarTextoPlaceholder(ref txt_Velocidade, "Velocidade em m/s", true);
            tentarCalcularEnergia();
            Utilidade.adicionarUnidadeDeMedida(ref txt_Velocidade, "Velocidade em m/s", "m/s", true);
        }
        private void txt_Velocidade_Leave(object sender, EventArgs e)
        {
            Utilidade.modificarTextoPlaceholder(ref txt_Velocidade, "Velocidade em m/s", false);
            tentarCalcularEnergia();
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

        private void tentarCalcularEnergia()
        {
            int peso;
            int velocidade;
            if (Int32.TryParse(txt_Peso.Text,out peso) && Int32.TryParse(txt_Velocidade.Text, out velocidade)) {
                energia = peso * velocidade;
                string texto = energia.ToString();
                txt_Energia.Text = texto;
            }
            else
            {
                txt_Energia.Text = "(Cálculo automático)";
            }
        }
    }
}
