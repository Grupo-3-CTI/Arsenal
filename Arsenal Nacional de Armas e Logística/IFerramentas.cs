using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arsenal_Nacional_de_Armas_e_Logística
{
    internal interface IFerramentas
    {

        /* Conexão e utilização de banco de dados */
        NpgsqlConnection ConectarComDB();
        void PreencherDataGrid(string query, NpgsqlConnection conexao, DataGridView Datagrid, string nomeTabela, ref System.Windows.Forms.ToolStripStatusLabel Footer);
        void ExecutarComandoDB(string query, NpgsqlConnection conexao, ref System.Windows.Forms.ToolStripStatusLabel Footer);
        void PreencherComboBox(string query, NpgsqlConnection conexao, ref System.Windows.Forms.ComboBox campo, string nomeTabela, string[] nomeColuna, ref System.Windows.Forms.ToolStripStatusLabel Footer);


        /* Verificação de input de usuário */
        bool NenhumCampoVazio(dynamic[] campos, ref System.Windows.Forms.Label[] labels, string[] textos);
        bool NenhumCampoVazio(List<dynamic> campos, ref List<System.Windows.Forms.Label> labels, List<string> textos);
        bool NenhumCampoNumericoMaiorQue(dynamic[] campos, ref System.Windows.Forms.Label[] labels, int valor, int[] valores);
        bool NenhumCampoNumericoMaiorQue(List<dynamic> campos, ref List<System.Windows.Forms.Label> labels, int valor, List<int> valores);
        bool NenhumCampoNumericoMenorQue(dynamic[] campos, ref System.Windows.Forms.Label[] labels, int valor, int[] valores);
        bool NenhumCampoNumericoMenorQue(List<dynamic> campos, ref List<System.Windows.Forms.Label> labels, int valor, List<int> valores);
        bool NenhumCampoNumericoIgualA(dynamic[] campos, ref System.Windows.Forms.Label[] labels, int valor, int[] valores);
        bool NenhumCampoNumericoIgualA(List<dynamic> campos, ref List<System.Windows.Forms.Label> labels, int valor, List<int> valores);
        bool RespondeuSimParaPopup(string titulo, string texto);



        /* Manipulação de fonte */
        void MudarTextoParaNegrito(ref System.Windows.Forms.Label campo);
        void MudarTextoParaNegrito(ref List<System.Windows.Forms.Label> campos);
        void MudarFonteAoNormal(ref System.Windows.Forms.Label campo);
        void MudarFonteAoNormal(ref List<System.Windows.Forms.Label> campos);
        void UsarFonteCustomizada(ref System.Windows.Forms.Label campo, dynamic pfc, int familia, int tamanho);
        void UsarFonteCustomizada(ref List<System.Windows.Forms.Label> campos, dynamic pfc, int familia, int tamanho);
        void UsarFonteCustomizada(ref System.Windows.Forms.Label campo, dynamic fonte);
        void UsarFonteCustomizada(ref List<System.Windows.Forms.Label> campos, dynamic fonte);

        /* Manipulação de textbox */

        void ModificarTextoPlaceholder(ref TextBox campo, string placeholderText, bool ganhouFoco);
        string ReceberTextoPlaceholderModificado(ref TextBox campo, string placeholderText, bool ganhouFoco);
        string ModificarUnidadeDeMedida(ref System.Windows.Forms.TextBox campo, string placeholderText, string unidadeDeMedida, bool ganhouFoco);
        void AceitarSomenteNumeros(object sender, KeyPressEventArgs e);

        


        /* Exibição de erros */
        void MostrarErro(string erro, ref System.Windows.Forms.ToolStripStatusLabel Footer);

    }
}
