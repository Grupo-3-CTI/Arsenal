using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arsenal_Nacional_de_Armas_e_Logística
{
    internal interface IMenu
    {
        void Cadastrar();
        void Editar();
        void Deletar();
        void Limpar();
    }
}
