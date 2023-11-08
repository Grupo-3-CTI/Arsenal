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
    public partial class Frm_MuniçãoEstoque : Form
    {
        Util Utilidade = new Util();
        private double energia;
        private int velocidade;
        private double peso;
        private string textoEnergia;
        private int ID;
        private string query = "";
        NpgsqlConnection conexao;

        public Frm_MuniçãoEstoque()
        {
            InitializeComponent();
            txt_Energia.ReadOnly = true;
            conexao = Utilidade.ConectarComDB();
            Utilidade.fillDataGrid("", conexao, dgv_Munições, "tbl_projetil", ref tslbl_TextoFooter);
        }

        private void Txt_Pesquisa_TextChanged_1(object sender, EventArgs e)
        {

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
        private void Txt_Peso_Enter(object sender, EventArgs e)
        {
            Utilidade.modificarTextoPlaceholder(ref txt_Peso, "Peso em gramas", true);
            Utilidade.modificarUnidadeDeMedida(ref txt_Peso, "Peso em gramas", "g", true);
        }


        private void Txt_Peso_Leave(object sender, EventArgs e)
        {
            Utilidade.modificarTextoPlaceholder(ref txt_Peso, "Peso em gramas", false);
            if (double.TryParse(Utilidade.modificarUnidadeDeMedida(ref txt_Peso, "Peso em gramas", "g", false), out peso))
            {
                TentarCalcularEnergia();
            } else
            {
                Utilidade.mostrarErro("Peso inválido!", ref tslbl_TextoFooter);
            }
        }

        private void Txt_Velocidade_Enter(object sender, EventArgs e)
        {
            Utilidade.modificarTextoPlaceholder(ref txt_Velocidade, "Velocidade em m/s", true);
            Utilidade.modificarUnidadeDeMedida(ref txt_Velocidade, "Velocidade em m/s", "m/s", true);
        }
        private void Txt_Velocidade_Leave(object sender, EventArgs e)
        {
            Utilidade.modificarTextoPlaceholder(ref txt_Velocidade, "Velocidade em m/s", false);
            if (int.TryParse(Utilidade.modificarUnidadeDeMedida(ref txt_Velocidade, "Velocidade em m/s", "m/s", false), out velocidade))
            {
                TentarCalcularEnergia();
            }
            else
            {
                Utilidade.mostrarErro("Velocidade inválida!", ref tslbl_TextoFooter);
            }
        }
        private void Txt_Velocidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidade.aceitarSomenteNumeros(sender, e);
        }
        private void Txt_Peso_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidade.aceitarSomenteNumeros(sender, e);
        }

        private void TentarCalcularEnergia()
        {

            if (velocidade > 0 && peso > 0) {
                energia = Math.Round(((peso/1000) * Math.Pow(velocidade, 2)) / 2, 2);
                textoEnergia = energia.ToString();
                txt_Energia.Text = textoEnergia;
                Utilidade.modificarUnidadeDeMedida(ref txt_Energia, "(Cálculo automático)", "J", false);
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

                Utilidade.modificarUnidadeDeMedida(ref txt_Peso, "Peso em gramas", "g", false);
                Utilidade.modificarUnidadeDeMedida(ref txt_Velocidade, "Velocidade em m/s", "m/s", false);
                Utilidade.modificarUnidadeDeMedida(ref txt_Energia, "(Cálculo automático)", "J", false);


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

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        public void Cadastrar()
        {
            if (Utilidade.nenhumCampoVazio(txt_Nome, txt_Peso, txt_Velocidade, txt_Calibre, txt_Energia))
            {
                if (Utilidade.respondeuSimParaPopup("Confirmação", "Tem certeza que deseja cadastrar essa munição?"))
                {
                    string query = $"INSERT INTO tbl_projetil (nome, peso, velocidade, calibre, energia) VALUES ('{txt_Nome.Text}', '{peso}', '{velocidade}', '{txt_Calibre.Text}', '{energia.ToString(CultureInfo.InvariantCulture)}')";
                    Utilidade.executarComandoDB(query, conexao, ref tslbl_TextoFooter);
                    Utilidade.fillDataGrid(query, Utilidade.ConectarComDB(), dgv_Munições, "tbl_projetil", ref tslbl_TextoFooter);
                }
                else
                {
                    Utilidade.mostrarErro("Preencha todos os campos!", ref tslbl_TextoFooter);
                }
            }
        }
        public void Deletar()
        {
            if (Utilidade.respondeuSimParaPopup("Confirmação", "ATENÇÃO, SOLDADO! TEM CERTEZA QUE DESEJA DELETAR ESSA MUNIÇÃO? ESSA AÇÃO É IRREVERSÍVEL"))
            {
                string query = $"DELETE FROM tbl_projetil WHERE id = {ID}";
                Utilidade.executarComandoDB(query, conexao, ref tslbl_TextoFooter);
                Utilidade.fillDataGrid(query, Utilidade.ConectarComDB(), dgv_Munições, "tbl_projetil", ref tslbl_TextoFooter);
            }
        }
        public void Editar()
        {
            if (Utilidade.nenhumCampoVazio(txt_Nome, txt_Peso, txt_Velocidade, txt_Calibre, txt_Energia))
            {
                if (Utilidade.respondeuSimParaPopup("Confirmação", "Tem certeza que deseja editar essa munição?"))
                {
                    string query = $"UPDATE tbl_projetil SET nome = '{txt_Nome.Text}', peso = '{peso}', velocidade = '{velocidade}', calibre = '{txt_Calibre.Text}', energia = '{energia.ToString(CultureInfo.InvariantCulture)}' WHERE id = {ID}";
                    Utilidade.executarComandoDB(query, conexao, ref tslbl_TextoFooter);
                    Utilidade.fillDataGrid(query, Utilidade.ConectarComDB(), dgv_Munições, "tbl_projetil", ref tslbl_TextoFooter);
                    
                }
            }
            else
            {
                Utilidade.mostrarErro("Preencha todos os campos!", ref tslbl_TextoFooter);
            }
        }
        public void Limpar()
        {
            txt_Calibre.Text = "";
            txt_Energia.Text = "";
            txt_Nome.Text = "";
            txt_Peso.Text = "";
            txt_Velocidade.Text = "";

            Utilidade.modificarTextoPlaceholder(ref txt_Peso, "Peso em gramas", false);
            Utilidade.modificarTextoPlaceholder(ref txt_Velocidade, "Velocidade em m/s", false);
            Utilidade.modificarTextoPlaceholder(ref txt_Energia, "(Cálculo automático)", false);
            
            btn_Cadastrar.Visible = true;
            btn_Cancelar.Visible = false;
            btn_Deletar.Visible = false;
            btn_Editar.Visible = false;

        }

        private void Btn_Pesquisar_Click(object sender, EventArgs e)
        {
            query = String.IsNullOrEmpty(txt_Pesquisa.Text) ? "" : $"SELECT * FROM tbl_projetil WHERE lower(nome) LIKE lower('%{txt_Pesquisa.Text}%')";
            Utilidade.fillDataGrid(query, Utilidade.ConectarComDB(), dgv_Munições, "tbl_projetil", ref tslbl_TextoFooter);
        }

        private void tsmi_Ajuda_Click(object sender, EventArgs e)
        {
            Frm_Ajuda form = new Frm_Ajuda();
            form.ShowDialog();
        }
    }
}
