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
        private int qtd_car = 0;
        private int qtd_cad = 0;
        private int ID;

        public Frm_ArmasEstoque()
        {
            InitializeComponent();
            conexao = Utilidade.ConectarComDB();
            Utilidade.fillDataGrid("", conexao, dgv_Armas, "tbl_arma", ref tslbl_TextoFooter);
        }

        private void Txt_Pesquisa_Enter(object sender, EventArgs e)
        {
            Utilidade.modificarTextoPlaceholder(ref txt_Pesquisa, "Pesquisar...", true);
        }

        private void Txt_Pesquisa_Leave(object sender, EventArgs e)
        {
            Utilidade.modificarTextoPlaceholder(ref txt_Pesquisa, "Pesquisar...", false);
        }


        private void Frm_ArmasEstoque_Load(object sender, EventArgs e)
        {

        }

        private void Tsmi_Home_Click(object sender, EventArgs e)
        {
            frm_FormPrincipal form = new frm_FormPrincipal();
            this.Close();
        }

        private void Cmb_Munição_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Cartucho_Enter(object sender, EventArgs e)
        {
            Utilidade.modificarTextoPlaceholder(ref txt_Cartucho, "Balas por cartucho aqui...", true);
            if (Int32.TryParse(txt_Cartucho.Text, out int qtd))
                qtd_car = qtd;
            Utilidade.modificarUnidadeDeMedida(ref txt_Cartucho, "Balas por cartucho aqui...",
                (qtd_car > 1 ? "balas" : "bala") + " por cartucho", true);
        }

        private void Txt_Cartucho_Leave(object sender, EventArgs e)
        {
            Utilidade.modificarTextoPlaceholder(ref txt_Cartucho, "Balas por cartucho aqui...", false);
            if(Int32.TryParse(txt_Cartucho.Text, out int qtd))
                qtd_car = qtd;

            Utilidade.modificarUnidadeDeMedida(ref txt_Cartucho, "Balas por cartucho aqui...",
                (qtd_car > 1 ? "balas" : "bala") + " por cartucho", false);

        }

        private void Txt_Cadencia_Enter(object sender, EventArgs e)
        {
            Utilidade.modificarTextoPlaceholder(ref txt_Cadencia, "Tiros por segundo aqui...", true);
            if (Int32.TryParse(txt_Cadencia.Text, out int qtd))
                qtd_cad = qtd;
            Utilidade.modificarUnidadeDeMedida(ref txt_Cadencia, "Tiros por segundo aqui...",
                 (qtd_cad > 1 ? "tiros" : "tiro") + " por segundo", true);
        }

        private void Txt_Cadencia_Leave(object sender, EventArgs e)
        {
            Utilidade.modificarTextoPlaceholder(ref txt_Cadencia, "Tiros por segundo aqui...", false);
            if (Int32.TryParse(txt_Cadencia.Text, out int qtd))
                qtd_cad = qtd;
            Utilidade.modificarUnidadeDeMedida(ref txt_Cadencia, "Tiros por segundo aqui...",
                (qtd_cad > 1 ? "tiros" : "tiro") + " por segundo", false);
        }

        private void Txt_Cadencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidade.aceitarSomenteNumeros(sender, e);
        }

        private void Txt_Cartucho_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidade.aceitarSomenteNumeros(sender, e);
        }
        private void Dgv_Armas_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                ID = (int)dgv_Armas.SelectedRows[0].Cells[0].Value;

                var num_serial = dgv_Armas.SelectedRows[0].Cells[1].Value;
                var nome = dgv_Armas.SelectedRows[0].Cells[2].Value;
                var cadencia = dgv_Armas.SelectedRows[0].Cells[3].Value;
                dynamic data_fabricacao = dgv_Armas.SelectedRows[0].Cells[4].Value;
                var projeteisPorCartucho = dgv_Armas.SelectedRows[0].Cells[5].Value;
                dynamic projetil = dgv_Armas.SelectedRows[0].Cells[6].Value;

                conexao.Open();
                string queryProj = $"SELECT nome FROM tbl_projetil WHERE lower(nome) LIKE lower('%{projetil.toString()}%')";
                using (NpgsqlCommand command = new NpgsqlCommand())


                data_fabricacao = data_fabricacao.ToString().Split('/');
                int d = int.Parse(data_fabricacao[0]);
                int m = int.Parse(data_fabricacao[1]);
                int Y = int.Parse(data_fabricacao[2].Split(' ')[0]);

                dtp_DataFabricacao.Value = new DateTime(Y, m, d);
                txt_Nome.Text = nome.ToString();
                txt_Cadencia.Text = cadencia.ToString();
                txt_Cartucho.Text = projeteisPorCartucho.ToString();
                txt_codigoSerial.Text = num_serial.ToString();

                Utilidade.modificarUnidadeDeMedida(ref txt_Cadencia, "Tiros por segundo aqui...",
                 (qtd_cad > 1 ? "tiros" : "tiro") + " por segundo", false);
                Utilidade.modificarUnidadeDeMedida(ref txt_Cartucho, "Balas por cartucho aqui...",
                (qtd_car > 1 ? "balas" : "bala") + " por cartucho", true);


                btn_Cadastrar.Visible = false;
                btn_Cancelar.Visible = true;
                btn_Deletar.Visible = true;
                btn_Editar.Visible = true;

            }
            catch (Exception ex)
            {
                Utilidade.mostrarErro(ex.Message, ref tslbl_TextoFooter);
            }
        }

        private void Btn_Cadastrar_click(object sender, EventArgs e)
        {
            Cadastrar();
        }
        
        public void Cadastrar()
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

        private void Txt_Pesquisa_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void mns_Menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
