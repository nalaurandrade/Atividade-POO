using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade3po
{
    internal class Cadastro
    {
        List<clientes> listacliente = new List<clientes>();

        public void GerarMenu()
        {
            CadastrarCliente();
        }

        public void CadastrarCliente()
        {            
            clientes cli = new clientes();
            cli.nome = "Jose Pereira";
            listacliente.Add(cli);
        }

    }
}
