using Npgsql;
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
        NpgsqlConnection conexao;
        int qtd_car = 0;
        int qtd_cad = 0;

        public Frm_ArmasEstoque()
        {
            InitializeComponent();
            Utilidade.fillDataGrid("", conexao, dgv_Armas, "tbl_arma", ref tslbl_TextoFooter);
            conexao = Utilidade.ConectarComDB();
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
            if (Int32.TryParse(txt_Cartucho.Text, out int qtd))
                qtd_car = qtd;
            Utilidade.modificarUnidadeDeMedida(ref txt_Cartucho, "Balas por cartucho aqui...",
                (qtd_car > 1 ? "balas" : "bala") + " por cartucho", true);
        }

        private void txt_Cartucho_Leave(object sender, EventArgs e)
        {
            Utilidade.modificarTextoPlaceholder(ref txt_Cartucho, "Balas por cartucho aqui...", false);
            if(Int32.TryParse(txt_Cartucho.Text, out int qtd))
                qtd_car = qtd;

            Utilidade.modificarUnidadeDeMedida(ref txt_Cartucho, "Balas por cartucho aqui...",
                (qtd_car > 1 ? "balas" : "bala") + " por cartucho", false);

        }

        private void txt_Cadencia_Enter(object sender, EventArgs e)
        {
            Utilidade.modificarTextoPlaceholder(ref txt_Cadencia, "Tiros por segundo aqui...", true);
            if (Int32.TryParse(txt_Cadencia.Text, out int qtd))
                qtd_cad = qtd;
            Utilidade.modificarUnidadeDeMedida(ref txt_Cadencia, "Tiros por segundo aqui...",
                 (qtd_cad > 1 ? "tiros" : "tiro") + " por segundo", true);
        }

        private void txt_Cadencia_Leave(object sender, EventArgs e)
        {
            Utilidade.modificarTextoPlaceholder(ref txt_Cadencia, "Tiros por segundo aqui...", false);
            if (Int32.TryParse(txt_Cadencia.Text, out int qtd))
                qtd_cad = qtd;
            Utilidade.modificarUnidadeDeMedida(ref txt_Cadencia, "Tiros por segundo aqui...",
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

        private void btn_Cadastrar_click(object sender, EventArgs e)
        {
            if (Utilidade.nenhumCampoVazio(txt_Nome, txt_Cadencia, txt_Cartucho, txt_codigoSerial))
            {
                if (Utilidade.respondeuSimParaPopup("Confirmação", "Deseja cadastrar a arma " + txt_Nome.Text + "?"))
                {
                    Utilidade.executarComandoDB($"INSERT INTO tbl_arma (nome, cadencia, projeteisporcartucho, numero_serie, data_fabricacao, projetil) VALUES ('{txt_Nome.Text}', {qtd_cad}, {qtd_car}, '{txt_codigoSerial.Text}', '{dtp_DataFabricacao.Value}', '{cmb_Munição.Text}')", conexao, ref tslbl_TextoFooter);
                    Utilidade.fillDataGrid("", Utilidade.ConectarComDB(), dgv_Armas, "tbl_arma", ref tslbl_TextoFooter);
                }
            }
            else
            {
                Utilidade.mostrarErro("Preencha todos os campos!", ref tslbl_TextoFooter);
            }   
        }
    }
}
