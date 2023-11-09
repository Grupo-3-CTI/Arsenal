using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arsenal_Nacional_de_Armas_e_Logística
{
    public partial class Frm_ArmasEstoque : Form //, Menu (Tirar comentário quando forem implementados os métodos)
    {
        Util Utilidade = new Util();
        NpgsqlConnection conexao;
        private int qtd_car = 0;
        private int qtd_cad = 0;
        private int ID;
        private string queryBusca = "SELECT tbl_arma.id, tbl_arma.numero_serie, tbl_arma.nome, tbl_arma.cadencia, " +
            "tbl_arma.data_fabricacao, tbl_arma.projeteisporcartucho, tbl_projetil.nome AS projetil " +
            "FROM tbl_arma JOIN tbl_projetil ON tbl_arma.projetil = tbl_projetil.id ORDER BY tbl_arma.id";


        public Frm_ArmasEstoque()
        {
            InitializeComponent();
            conexao = Utilidade.ConectarComDB();
            Utilidade.PreencherDataGrid("SELECT tbl_arma.id, tbl_arma.numero_serie, tbl_arma.nome, tbl_arma.cadencia, " +
            "tbl_arma.data_fabricacao, tbl_arma.projeteisporcartucho, tbl_projetil.nome AS projetil " +
            "FROM tbl_arma JOIN tbl_projetil ON tbl_arma.projetil = tbl_projetil.id ORDER BY tbl_arma.id", conexao, dgv_Armas, "tbl_arma", ref tslbl_TextoFooter);
            String[] coluna = { "calibre", "nome" };
            Utilidade.PreencherComboBox("", conexao, ref cmb_Munição, "tbl_projetil", coluna, ref tslbl_TextoFooter);
            cmb_Munição.SelectedIndex = -1;

        }

        private void Txt_Pesquisa_Enter(object sender, EventArgs e)
        {
            Utilidade.ModificarTextoPlaceholder(ref txt_Pesquisa, "Pesquisar...", true);
        }

        private void Txt_Pesquisa_Leave(object sender, EventArgs e)
        {
            Utilidade.ModificarTextoPlaceholder(ref txt_Pesquisa, "Pesquisar...", false);
        }

        private void Tsmi_Home_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Txt_Cartucho_Enter(object sender, EventArgs e)
        {
            Utilidade.ModificarTextoPlaceholder(ref txt_Cartucho, "Balas por cartucho aqui...", true);
            if (Int32.TryParse(txt_Cartucho.Text, out int qtd))
                qtd_car = qtd;
            Utilidade.ModificarUnidadeDeMedida(ref txt_Cartucho, "Balas por cartucho aqui...",
                (qtd_car > 1 ? "balas" : "bala") + " por cartucho", true);
        }

        private void Txt_Cartucho_Leave(object sender, EventArgs e)
        {
            Utilidade.ModificarTextoPlaceholder(ref txt_Cartucho, "Balas por cartucho aqui...", false);
            if(Int32.TryParse(txt_Cartucho.Text, out int qtd))
                qtd_car = qtd;

            Utilidade.ModificarUnidadeDeMedida(ref txt_Cartucho, "Balas por cartucho aqui...",
                (qtd_car > 1 ? "balas" : "bala") + " por cartucho", false);

        }

        private void Txt_Cadencia_Enter(object sender, EventArgs e)
        {
            Utilidade.ModificarTextoPlaceholder(ref txt_Cadencia, "Tiros por segundo aqui...", true);
            if (Int32.TryParse(txt_Cadencia.Text, out int qtd))
                qtd_cad = qtd;
            Utilidade.ModificarUnidadeDeMedida(ref txt_Cadencia, "Tiros por segundo aqui...",
                 (qtd_cad > 1 ? "tiros" : "tiro") + " por segundo", true);
        }

        private void Txt_Cadencia_Leave(object sender, EventArgs e)
        {
            Utilidade.ModificarTextoPlaceholder(ref txt_Cadencia, "Tiros por segundo aqui...", false);
            if (Int32.TryParse(txt_Cadencia.Text, out int qtd))
                qtd_cad = qtd;
            Utilidade.ModificarUnidadeDeMedida(ref txt_Cadencia, "Tiros por segundo aqui...",
                (qtd_cad > 1 ? "tiros" : "tiro") + " por segundo", false);
        }

        private void Txt_Cadencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidade.AceitarSomenteNumeros(sender, e);
        }

        private void Txt_Cartucho_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidade.AceitarSomenteNumeros(sender, e);
        }


        private void tsmi_Ajuda_Click(object sender, EventArgs e)
        {
            Frm_Ajuda form = new Frm_Ajuda();
            form.ShowDialog();
        }

        private void tsmi_Cadastro_Munições_Click(object sender, EventArgs e)
        {
            Frm_MuniçãoEstoque form = new Frm_MuniçãoEstoque();
            form.ShowDialog();
        }

        private void Btn_Pesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }
        private void Txt_Pesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Pesquisar();
                e.Handled = true;
            }
        }

        private void Btn_Deletar_Click(object sender, EventArgs e)
        {
            Deletar();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Limpar();
        }
        private void Btn_Cadastrar_click(object sender, EventArgs e)
        {
            Cadastrar();
        }

        private void Btn_Editar_Click(object sender, EventArgs e)
        {
            Editar();
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
                var projetil = dgv_Armas.SelectedRows[0].Cells[6].Value;

                conexao.Open();
                NpgsqlCommand cmd = new NpgsqlCommand($"SELECT id FROM tbl_projetil WHERE nome = '{projetil}'", conexao);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                projetil = dr[0];
                conexao.Close();

                data_fabricacao = data_fabricacao.ToString().Split('/');
                int d = int.Parse(data_fabricacao[0]);
                int m = int.Parse(data_fabricacao[1]);
                int Y = int.Parse(data_fabricacao[2].Split(' ')[0]);

                dtp_DataFabricacao.Value = new DateTime(Y, m, d);
                txt_Nome.Text = nome.ToString();
                txt_Cadencia.Text = cadencia.ToString();
                txt_Cartucho.Text = projeteisPorCartucho.ToString();
                txt_codigoSerial.Text = num_serial.ToString();
                cmb_Munição.SelectedValue = projetil;

                Utilidade.ModificarUnidadeDeMedida(ref txt_Cadencia, "Tiros por segundo aqui...",
                 (qtd_cad > 1 ? "tiros" : "tiro") + " por segundo", false);
                Utilidade.ModificarUnidadeDeMedida(ref txt_Cartucho, "Balas por cartucho aqui...",
                (qtd_car > 1 ? "balas" : "bala") + " por cartucho", false);


                btn_Cadastrar.Visible = false;
                btn_Cancelar.Visible = true;
                btn_Deletar.Visible = true;
                btn_Editar.Visible = true;

            }
            catch (Exception ex)
            {
                Utilidade.MostrarErro(ex.Message, ref tslbl_TextoFooter);
            }
        }

        public void Cadastrar()
        {
            dynamic[] campos = { txt_Nome, txt_Cadencia, txt_Cartucho, txt_codigoSerial };
            Label[] labels = { lbl_Nome, lbl_Cadência, lbl_Cartucho, lbl_CódigoSerial };
            if (Utilidade.NenhumCampoVazio(campos, ref labels) && cmb_Munição.SelectedIndex != -1)
            {
                if (Utilidade.RespondeuSimParaPopup("Confirmação", "Tem certeza que deseja cadastrar essa arma?"))
                {
                    Utilidade.ExecutarComandoDB($"INSERT INTO tbl_arma (nome, cadencia, projeteisporcartucho, numero_serie, data_fabricacao, projetil) VALUES ('{txt_Nome.Text}', {qtd_cad}, {qtd_car}, '{txt_codigoSerial.Text}', '{dtp_DataFabricacao.Value}', '{cmb_Munição.SelectedValue}')", conexao, ref tslbl_TextoFooter);
                    Utilidade.PreencherDataGrid(queryBusca, Utilidade.ConectarComDB(), dgv_Armas, "tbl_arma", ref tslbl_TextoFooter);
                    Limpar();
                }
            }
            else
            {
                Utilidade.MostrarErro("Preencha todos os campos!", ref tslbl_TextoFooter);
            }
        }

        public void Limpar()
        {
            txt_Cadencia.Text = "";
            txt_Cartucho.Text = "";
            txt_Nome.Text = "";
            txt_codigoSerial.Text = "";
            cmb_Munição.SelectedIndex = -1;
            dtp_DataFabricacao.Value = DateTime.Now;

            Utilidade.ModificarTextoPlaceholder(ref txt_Cadencia, "Tiros por segundo aqui...", false);
            Utilidade.ModificarTextoPlaceholder(ref txt_Cartucho, "Balas por cartucho aqui...", false);

            btn_Cadastrar.Visible = true;
            btn_Cancelar.Visible = false;
            btn_Deletar.Visible = false;
            btn_Editar.Visible = false;

        }
        public void Deletar()
        {
            if (Utilidade.RespondeuSimParaPopup("Confirmação", "ATENÇÃO, SOLDADO! VOCÊ TEM CERTEZA QUE DESEJA DELETAR A ARMA " + txt_Nome.Text + "? ESTA AÇÃO É IRREVERSÍVEL!"))
            {
                Utilidade.ExecutarComandoDB($"DELETE FROM tbl_arma WHERE id = {ID}", conexao, ref tslbl_TextoFooter);
                Utilidade.PreencherDataGrid(queryBusca, Utilidade.ConectarComDB(), dgv_Armas, "tbl_arma", ref tslbl_TextoFooter);
                Limpar();
            }
        }
        public void Editar()
        {
            dynamic[] campos = { txt_Nome, txt_Cadencia, txt_Cartucho, txt_codigoSerial };
            Label[] labels = { lbl_Nome, lbl_Cadência, lbl_Cartucho, lbl_CódigoSerial };
            if (Utilidade.NenhumCampoVazio(campos, ref labels) && cmb_Munição.SelectedIndex != -1)
            {
                if (Utilidade.RespondeuSimParaPopup("Confirmação", "Tem certeza que deseja editar essa arma?"))
                {
                    Utilidade.ExecutarComandoDB($"UPDATE tbl_arma SET nome = '{txt_Nome.Text}', cadencia = {qtd_cad}, projeteisporcartucho = {qtd_car}, numero_serie = '{txt_codigoSerial.Text}', data_fabricacao = '{dtp_DataFabricacao.Value}', projetil = '{cmb_Munição.SelectedValue}' WHERE id = {ID}", conexao, ref tslbl_TextoFooter);
                    Utilidade.PreencherDataGrid(queryBusca, Utilidade.ConectarComDB(), dgv_Armas, "tbl_arma", ref tslbl_TextoFooter);
                }
            }
            else
            {
                Utilidade.MostrarErro("Preencha todos os campos!", ref tslbl_TextoFooter);
            }
        }
        public void Pesquisar()
        {
            if (txt_Pesquisa.Text == "Pesquisar...")
            {
                queryBusca = "SELECT tbl_arma.id, tbl_arma.numero_serie, tbl_arma.nome, tbl_arma.cadencia, " +
                "tbl_arma.data_fabricacao, tbl_arma.projeteisporcartucho, tbl_projetil.nome AS projetil " +
                "FROM tbl_arma JOIN tbl_projetil ON tbl_arma.projetil = tbl_projetil.id ORDER BY tbl_arma.id";
            } else
            {
                queryBusca = "SELECT tbl_arma.id, tbl_arma.numero_serie, tbl_arma.nome, tbl_arma.cadencia, " +
                "tbl_arma.data_fabricacao, tbl_arma.projeteisporcartucho, tbl_projetil.nome AS projetil " +
                $"FROM tbl_arma JOIN tbl_projetil ON tbl_arma.projetil = tbl_projetil.id WHERE lower(tbl_arma.nome) LIKE lower('%{txt_Pesquisa.Text}%') ORDER BY tbl_arma.id";
            }
            
            Utilidade.PreencherDataGrid(queryBusca, conexao, dgv_Armas, "tbl_arma", ref tslbl_TextoFooter);

        }

    }
}
