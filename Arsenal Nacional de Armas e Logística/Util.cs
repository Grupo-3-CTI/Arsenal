using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arsenal_Nacional_de_Armas_e_Logística
{
    internal class Util : IFerramentas
    {
        public void mostrarErro(string erro, ref System.Windows.Forms.ToolStripStatusLabel Footer)
        {
            string mensagem = "Erro: "  + erro;
            MessageBox.Show(mensagem);
            Footer.Text = mensagem;
        }
        public NpgsqlConnection ConectarComDB()
        {
            return new NpgsqlConnection(connectionString: "Server=localhost; Port=5432; User ID=postgres; Password=postgres; Database=arsenal; Pooling=true;");
        }
        public void fillDataGrid(string query, NpgsqlConnection conexao, DataGridView Datagrid, string nomeTabela, ref System.Windows.Forms.ToolStripStatusLabel Footer)
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
                mostrarErro(ex.Message, ref Footer);
                conexao.Close();
            }
        }
        //Para comandos que não retornam uma query. (INSERT, DELETE, UPDATE, etc)
        public void executarComandoDB(string query, NpgsqlConnection conexao, ref System.Windows.Forms.ToolStripStatusLabel Footer)
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
                mostrarErro(ex.Message, ref Footer);
                conexao.Close();
            }
        }
        public bool nenhumCampoVazio(params dynamic[] campos)
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
        //Sobrecarga do método para listas
        public bool nenhumCampoVazio(List<dynamic> campos)
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

        public bool respondeuSimParaPopup(string titulo, string texto)
        {
            DialogResult dialogResult = MessageBox.Show(texto, titulo, MessageBoxButtons.YesNo);
            return dialogResult == DialogResult.Yes;
        }
        //Sobrecarga do método para listas
        public void mudarTextoParaNegrito(ref System.Windows.Forms.Label campo)
        {
            campo.Font = new Font(campo.Font, FontStyle.Bold);
        }


        public void mudarTextoParaNegrito(ref List<System.Windows.Forms.Label> campos)
        {
            foreach (System.Windows.Forms.Label campo in campos)
                campo.Font = new Font(campo.Font, FontStyle.Bold);
        }
        public void mudarFonteAoNormal(ref System.Windows.Forms.Label campo)
        {
            campo.Font = new Font(campo.Font, FontStyle.Regular);
        }
        //Sobrecarga do método para listas
        public void mudarFonteAoNormal(ref List<System.Windows.Forms.Label> campos)
        {
            foreach (System.Windows.Forms.Label campo in campos)
                campo.Font = new Font(campo.Font, FontStyle.Regular);
        }

        public void usarFonteCustomizada(ref System.Windows.Forms.Label campo, dynamic pfc, int familia, int tamanho)
        {
                
            campo.Font = new Font(pfc.Families[familia], tamanho, FontStyle.Regular);
        }
        //Sobrecarga do método para listas
        public void usarFonteCustomizada(ref List<System.Windows.Forms.Label> campos, dynamic pfc, int familia, int tamanho)
        {
            foreach (var campo in campos)
            {
                campo.Font = new Font(pfc.Families[familia], tamanho, FontStyle.Regular);
           
            }
        }
        public void usarFonteCustomizada(ref System.Windows.Forms.Label campo, dynamic fonte) { 
            campo.Font = fonte;
        }
        public void usarFonteCustomizada(ref List<System.Windows.Forms.Label> campos, dynamic fonte)
        {
            foreach (var campo in campos)
            {
                campo.Font = fonte;
            }
        }
        public void modificarTextoPlaceholder(ref System.Windows.Forms.TextBox campo, string placeholderText, bool ganhouFoco)
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
        public string modificarUnidadeDeMedida (ref System.Windows.Forms.TextBox campo, string placeholderText, string unidadeDeMedida, bool  ganhouFoco)
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
        public void aceitarSomenteNumeros(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar) || e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }
    }
}
