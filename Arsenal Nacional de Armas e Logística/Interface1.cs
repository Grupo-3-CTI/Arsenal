using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arsenal_Nacional_de_Armas_e_Logística
{
    internal interface Ferramentas
    {

        /* Conexão e utilização de banco de dados */
        NpgsqlConnection ConectarComDB();
        void fillDataGrid(string query, NpgsqlConnection conexao, DataGrid Datagrid, string nomeTabela);
        void executarComandoDB(string query, NpgsqlConnection conexao);


        /* Verificação de input de usuário */
        bool nenhumCampoVazio(params dynamic[] campos);
        bool nenhumCampoVazio(List<dynamic> campos);
        bool respondeuSimParaPopup(string titulo, string texto);



        /* Manipulação de fonte */
        void mudarTextoParaNegrito(ref System.Windows.Forms.Label campo);
        void mudarTextoParaNegrito(ref List<System.Windows.Forms.Label> campos);
        void mudarFonteAoNormal(ref System.Windows.Forms.Label campo);
        void mudarFonteAoNormal(ref List<System.Windows.Forms.Label> campos);
        void usarFonteCustomizada(ref System.Windows.Forms.Label campo, dynamic pfc, int tamanho);
        void usarFonteCustomizada(ref List<System.Windows.Forms.Label> campos, dynamic pfc, int tamanho);



        /* Exibição de erros */
        void mostrarErro(string erro);

    }
}
