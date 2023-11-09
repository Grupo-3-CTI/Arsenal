using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arsenal_Nacional_de_Armas_e_Logística
{
    public partial class Frm_MuniçãoEstoque : Form, IMenu
    {
        Util Utilidade = new Util();
        private double energia;
        private int velocidade;
        private double peso;
        private string textoEnergia;
        private int ID;
        private string queryBusca = "";
        NpgsqlConnection conexao;

        public Frm_MuniçãoEstoque()
        {
            InitializeComponent();
            txt_Energia.ReadOnly = true;
            conexao = Utilidade.ConectarComDB();
            Utilidade.PreencherDataGrid("", conexao, dgv_Munições, "tbl_projetil", ref tslbl_TextoFooter);
        }

        private void Txt_Pesquisa_TextChanged_1(object sender, EventArgs e)
        {

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
        private void Txt_Peso_Enter(object sender, EventArgs e)
        {
            Utilidade.ModificarTextoPlaceholder(ref txt_Peso, "Peso em gramas", true);
            Utilidade.ModificarUnidadeDeMedida(ref txt_Peso, "Peso em gramas", "g", true);
        }


        private void Txt_Peso_Leave(object sender, EventArgs e)
        {
            Utilidade.ModificarTextoPlaceholder(ref txt_Peso, "Peso em gramas", false);
            if (double.TryParse(Utilidade.ModificarUnidadeDeMedida(ref txt_Peso, "Peso em gramas", "g", false), out peso))
            {
                TentarCalcularEnergia();
            } else
            {
                Utilidade.MostrarErro("Peso inválido!", ref tslbl_TextoFooter);
            }
        }

        private void Txt_Velocidade_Enter(object sender, EventArgs e)
        {
            Utilidade.ModificarTextoPlaceholder(ref txt_Velocidade, "Velocidade em m/s", true);
            Utilidade.ModificarUnidadeDeMedida(ref txt_Velocidade, "Velocidade em m/s", "m/s", true);
        }
        private void Txt_Velocidade_Leave(object sender, EventArgs e)
        {
            Utilidade.ModificarTextoPlaceholder(ref txt_Velocidade, "Velocidade em m/s", false);
            if (int.TryParse(Utilidade.ModificarUnidadeDeMedida(ref txt_Velocidade, "Velocidade em m/s", "m/s", false), out velocidade))
            {
                TentarCalcularEnergia();
            }
            else
            {
                Utilidade.MostrarErro("Velocidade inválida!", ref tslbl_TextoFooter);
            }
        }
        private void Txt_Velocidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidade.AceitarSomenteNumeros(sender, e);
        }
        private void Txt_Peso_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidade.AceitarSomenteNumeros(sender, e);
        }

        private void TentarCalcularEnergia()
        {

            if (velocidade > 0 && peso > 0) {
                energia = Math.Round(((peso/1000) * Math.Pow(velocidade, 2)) / 2, 2);
                textoEnergia = energia.ToString();
                txt_Energia.Text = textoEnergia;
                Utilidade.ModificarUnidadeDeMedida(ref txt_Energia, "(Cálculo automático)", "J", false);
            }
            else
            {
                txt_Energia.Text = "(Cálculo automático)";
            }
        }

        private void Btn_Cadastrar_Click(object sender, EventArgs e)
        {
            Cadastrar();
        }
        private void Btn_Deletar_Click(object sender, EventArgs e)
        {
            Deletar();
        }
        private void Btn_Editar_Click(object sender, EventArgs e)
        {
            Editar();
        }
        private void Dgv_Munições_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                ID = (int)dgv_Munições.SelectedRows[0].Cells[0].Value;

                var calibre = dgv_Munições.SelectedRows[0].Cells[1].Value;
                var nome = dgv_Munições.SelectedRows[0].Cells[2].Value;
                var velocidade = dgv_Munições.SelectedRows[0].Cells[3].Value;
                var peso = dgv_Munições.SelectedRows[0].Cells[4].Value;
                var energia = dgv_Munições.SelectedRows[0].Cells[5].Value;

                txt_Nome.Text = nome.ToString();
                txt_Peso.Text = peso.ToString();
                txt_Velocidade.Text = velocidade.ToString();
                txt_Calibre.Text = calibre.ToString();
                txt_Energia.Text = energia.ToString();

                Utilidade.ModificarUnidadeDeMedida(ref txt_Peso, "Peso em gramas", "g", false);
                Utilidade.ModificarUnidadeDeMedida(ref txt_Velocidade, "Velocidade em m/s", "m/s", false);
                Utilidade.ModificarUnidadeDeMedida(ref txt_Energia, "(Cálculo automático)", "J", false);


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

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void Btn_Pesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void tsmi_Ajuda_Click(object sender, EventArgs e)
        {
            Frm_Ajuda form = new Frm_Ajuda();
            form.ShowDialog();
        }

        private void tsmi_Cadastro_Armas_Click(object sender, EventArgs e)
        {
            Frm_ArmasEstoque form = new Frm_ArmasEstoque();
            form.ShowDialog();
        }

        private void Txt_Pesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Pesquisar();
                e.Handled = true;
            }
        }

        public void Cadastrar()
        {
            if (Utilidade.NenhumCampoVazio(txt_Nome, txt_Peso, txt_Velocidade, txt_Calibre, txt_Energia))
            {
                if (Utilidade.RespondeuSimParaPopup("Confirmação", "Tem certeza que deseja cadastrar essa munição?"))
                {
                    string query = $"INSERT INTO tbl_projetil (nome, peso, velocidade, calibre, energia) VALUES ('{txt_Nome.Text}', '{peso}', '{velocidade}', '{txt_Calibre.Text}', '{energia.ToString(CultureInfo.InvariantCulture)}')";
                    Utilidade.ExecutarComandoDB(query, conexao, ref tslbl_TextoFooter);
                    Utilidade.PreencherDataGrid(queryBusca, Utilidade.ConectarComDB(), dgv_Munições, "tbl_projetil", ref tslbl_TextoFooter);
                    Limpar();
                }
            }
            else
            {
                Utilidade.MostrarErro("Preencha todos os campos!", ref tslbl_TextoFooter);
            }
        }
        public void Deletar()
        {
            if (Utilidade.RespondeuSimParaPopup("Confirmação", "ATENÇÃO, SOLDADO! TEM CERTEZA QUE DESEJA DELETAR A MUNIÇÃO " + txt_Calibre.Text + " " + txt_Nome.Text + "? ESTA AÇÃO É IRREVERSÍVEL!"))
            {
                string query = $"DELETE FROM tbl_projetil WHERE id = {ID}";
                Utilidade.ExecutarComandoDB(query, conexao, ref tslbl_TextoFooter);
                Utilidade.PreencherDataGrid(queryBusca, Utilidade.ConectarComDB(), dgv_Munições, "tbl_projetil", ref tslbl_TextoFooter);
                Limpar();
            }
        }
        public void Editar()
        {
            if (Utilidade.NenhumCampoVazio(txt_Nome, txt_Peso, txt_Velocidade, txt_Calibre, txt_Energia))
            {
                if (Utilidade.RespondeuSimParaPopup("Confirmação", "Tem certeza que deseja editar essa munição?"))
                {
                    string query = $"UPDATE tbl_projetil SET nome = '{txt_Nome.Text}', peso = '{peso}', velocidade = '{velocidade}', calibre = '{txt_Calibre.Text}', energia = '{energia.ToString(CultureInfo.InvariantCulture)}' WHERE id = {ID}";
                    Utilidade.ExecutarComandoDB(query, conexao, ref tslbl_TextoFooter);
                    Utilidade.PreencherDataGrid(queryBusca, Utilidade.ConectarComDB(), dgv_Munições, "tbl_projetil", ref tslbl_TextoFooter);
                }
            }
            else
            {
                Utilidade.MostrarErro("Preencha todos os campos!", ref tslbl_TextoFooter);
            }
        }
        public void Pesquisar()
        {
            queryBusca = txt_Pesquisa.Text == "Pesquisar..." ? "" : $"SELECT * FROM tbl_projetil WHERE lower(nome) LIKE lower('%{txt_Pesquisa.Text}%')";
            Utilidade.PreencherDataGrid(queryBusca, Utilidade.ConectarComDB(), dgv_Munições, "tbl_projetil", ref tslbl_TextoFooter);
        }
        public void Limpar()
        {
            txt_Calibre.Text = "";
            txt_Energia.Text = "";
            txt_Nome.Text = "";
            txt_Peso.Text = "";
            txt_Velocidade.Text = "";

            Utilidade.ModificarTextoPlaceholder(ref txt_Peso, "Peso em gramas", false);
            Utilidade.ModificarTextoPlaceholder(ref txt_Velocidade, "Velocidade em m/s", false);
            Utilidade.ModificarTextoPlaceholder(ref txt_Energia, "(Cálculo automático)", false);
            
            btn_Cadastrar.Visible = true;
            btn_Cancelar.Visible = false;
            btn_Deletar.Visible = false;
            btn_Editar.Visible = false;

        }
    }
}
