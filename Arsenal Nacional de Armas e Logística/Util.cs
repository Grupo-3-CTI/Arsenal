using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Management.Instrumentation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arsenal_Nacional_de_Armas_e_Logística
{
    internal class Util : IFerramentas
    {
        public void MostrarErro(string erro, ref System.Windows.Forms.ToolStripStatusLabel Footer)
        {
            string mensagem = "Erro: "  + erro;
            MessageBox.Show(mensagem);
            Footer.Text = mensagem;
        }
        public NpgsqlConnection ConectarComDB()
        {
            return new NpgsqlConnection(connectionString: "Server=localhost; Port=5432; User ID=postgres; Password=postgres; Database=arsenal; Pooling=true;");
        }
        public void PreencherDataGrid(string query, NpgsqlConnection conexao, DataGridView Datagrid, string nomeTabela, ref System.Windows.Forms.ToolStripStatusLabel Footer)
        {
            if (String.IsNullOrEmpty(query))
            {
                query = $"SELECT * FROM {nomeTabela} ORDER BY id";
            }
            try
            {
                conexao.Open();
                using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conexao))
                {
                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        Datagrid.DataSource = dt;
                    }
                }
                conexao.Close();
            }
            catch (NpgsqlException ex)
            {
                MostrarErro(ex.Message, ref Footer);
                conexao.Close();
            }
        }

        public void PreencherComboBox(string query, NpgsqlConnection conexao, ref System.Windows.Forms.ComboBox campo,  string nomeTabela, string[] nomeColunas, ref System.Windows.Forms.ToolStripStatusLabel Footer)
        {
            if (String.IsNullOrEmpty(query))
            {
                query = $"SELECT * FROM {nomeTabela} ORDER BY id";
            }
            try
            {
                conexao.Open();
                using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conexao))
                {
                    using (DataTable dt = new DataTable())
                    {
                        string displayMember = "";
                        foreach (string nomeColuna in nomeColunas)
                        {
                            displayMember += nomeColuna + "  + ' ' + ";
                        }
                        displayMember = displayMember.Remove(displayMember.Length - 9, 9);
                        da.Fill(dt);
                        dt.Columns.Add("nomeCompleto", typeof(string), displayMember);
                        campo.DataSource = dt.DefaultView;
                        campo.DisplayMember = "nomeCompleto";
                        campo.ValueMember = "id";
                    }
                }
                conexao.Close();
            }
            catch (NpgsqlException ex)
            {
                MostrarErro(ex.Message, ref Footer);
                conexao.Close();
            }
        }
        //Para comandos que não retornam uma query. (INSERT, DELETE, UPDATE, etc)
        public void ExecutarComandoDB(string query, NpgsqlConnection conexao, ref System.Windows.Forms.ToolStripStatusLabel Footer)
        {
            try
            {
                conexao.Open();
                using (var comando = new NpgsqlCommand(query, conexao))
                {
                    comando.ExecuteNonQuery();
                }
                conexao.Close();
            }
            catch (NpgsqlException ex)
            {
                if (ex.Message.Contains("23503"))
                {
                    MostrarErro("Não é possível excluir esta munição pois ela está sendo utilizada em uma arma. Apague todas as armas que o utilizam antes.", ref Footer);
                }
                else
                {
                    MostrarErro(ex.Message, ref Footer);
                }
                conexao.Close();
            }
        }
        public bool NenhumCampoVazio(dynamic[] campos, ref System.Windows.Forms.Label[] labels)
        {
            int i = 0;
            foreach (dynamic campo in campos)
            {
                ++i;
                if (String.IsNullOrEmpty(campo.Text))
                {
                    labels[i].Font =  new Font(labels[i].Font,FontStyle.Bold);
                    return false;
                }
            }
            return true;
        }
        //Sobrecarga do método para listas
        public bool NenhumCampoVazio(List<dynamic> campos)
        {
            foreach (dynamic campo in campos)
            {
                if (String.IsNullOrEmpty(campo.Text))
                {
                    return false;
                }
            }
            return true;
        }

        public bool RespondeuSimParaPopup(string titulo, string texto)
        {
            DialogResult dialogResult = MessageBox.Show(texto, titulo, MessageBoxButtons.YesNo);
            return dialogResult == DialogResult.Yes;
        }
        //Sobrecarga do método para listas
        public void MudarTextoParaNegrito(ref System.Windows.Forms.Label campo)
        {
            campo.Font = new Font(campo.Font, FontStyle.Bold);
        }


        public void MudarTextoParaNegrito(ref List<System.Windows.Forms.Label> campos)
        {
            foreach (System.Windows.Forms.Label campo in campos)
                campo.Font = new Font(campo.Font, FontStyle.Bold);
        }
        public void MudarFonteAoNormal(ref System.Windows.Forms.Label campo)
        {
            campo.Font = new Font(campo.Font, FontStyle.Regular);
        }
        //Sobrecarga do método para listas
        public void MudarFonteAoNormal(ref List<System.Windows.Forms.Label> campos)
        {
            foreach (System.Windows.Forms.Label campo in campos)
                campo.Font = new Font(campo.Font, FontStyle.Regular);
        }

        public void UsarFonteCustomizada(ref System.Windows.Forms.Label campo, dynamic pfc, int familia, int tamanho)
        {
                
            campo.Font = new Font(pfc.Families[familia], tamanho, FontStyle.Regular);
        }
        //Sobrecarga do método para listas
        public void UsarFonteCustomizada(ref List<System.Windows.Forms.Label> campos, dynamic pfc, int familia, int tamanho)
        {
            foreach (var campo in campos)
            {
                campo.Font = new Font(pfc.Families[familia], tamanho, FontStyle.Regular);
           
            }
        }
        public void UsarFonteCustomizada(ref System.Windows.Forms.Label campo, dynamic fonte) { 
            campo.Font = fonte;
        }
        public void UsarFonteCustomizada(ref List<System.Windows.Forms.Label> campos, dynamic fonte)
        {
            foreach (var campo in campos)
            {
                campo.Font = fonte;
            }
        }
        public void ModificarTextoPlaceholder(ref System.Windows.Forms.TextBox campo, string placeholderText, bool ganhouFoco)
        {
            if (ganhouFoco && campo.Text == placeholderText)
            {
                campo.Text = "";
                campo.ForeColor = Color.Black;
            }
            else if (String.IsNullOrEmpty(campo.Text))
            {
                campo.Text = placeholderText;
                campo.ForeColor = Color.DimGray;
            }
        }
        public string ModificarUnidadeDeMedida (ref System.Windows.Forms.TextBox campo, string placeholderText, string unidadeDeMedida, bool  ganhouFoco)
        {
            string valor;
            if (ganhouFoco && !String.IsNullOrEmpty(campo.Text))
            {
                campo.Text = campo.Text.Remove(campo.Text.Length - unidadeDeMedida.Length-1, unidadeDeMedida.Length+1);
                valor = campo.Text;
                return valor;
            }
            else if(!String.IsNullOrEmpty(campo.Text) && campo.Text != placeholderText)
            {
                valor = campo.Text;
                campo.Text += " " + unidadeDeMedida;
                return valor;
            }
            return "0";
        }
        public void AceitarSomenteNumeros(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar) || e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }
    }
}
