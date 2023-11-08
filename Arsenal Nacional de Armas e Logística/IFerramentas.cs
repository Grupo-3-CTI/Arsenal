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
        void fillDataGrid(string query, NpgsqlConnection conexao, DataGridView Datagrid, string nomeTabela, ref System.Windows.Forms.ToolStripStatusLabel Footer);
        void executarComandoDB(string query, NpgsqlConnection conexao, ref System.Windows.Forms.ToolStripStatusLabel Footer);


        /* Verificação de input de usuário */
        bool nenhumCampoVazio(params dynamic[] campos);
        bool nenhumCampoVazio(List<dynamic> campos);
        bool respondeuSimParaPopup(string titulo, string texto);



        /* Manipulação de fonte */
        void mudarTextoParaNegrito(ref System.Windows.Forms.Label campo);
        void mudarTextoParaNegrito(ref List<System.Windows.Forms.Label> campos);
        void mudarFonteAoNormal(ref System.Windows.Forms.Label campo);
        void mudarFonteAoNormal(ref List<System.Windows.Forms.Label> campos);
        void usarFonteCustomizada(ref System.Windows.Forms.Label campo, dynamic pfc, int familia, int tamanho);
        void usarFonteCustomizada(ref List<System.Windows.Forms.Label> campos, dynamic pfc, int familia, int tamanho);
        void usarFonteCustomizada(ref System.Windows.Forms.Label campo, dynamic fonte);
        void usarFonteCustomizada(ref List<System.Windows.Forms.Label> campos, dynamic fonte);

        /* Manipulação de textbox */

        void modificarTextoPlaceholder(ref System.Windows.Forms.TextBox campo, string placeholderText, bool ganhouFoco);
        string modificarUnidadeDeMedida(ref System.Windows.Forms.TextBox campo, string placeholderText, string unidadeDeMedida, bool ganhouFoco);
        void aceitarSomenteNumeros(object sender, KeyPressEventArgs e);


        /* Exibição de erros */
        void mostrarErro(string erro, ref System.Windows.Forms.ToolStripStatusLabel Footer);

    }
}
