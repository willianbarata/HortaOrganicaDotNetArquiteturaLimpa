using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HortaOrganica.Core.Entities
{
    public class Cliente : BaseEntity
    {
        public string Cpf { get; private set; } 
        public List<Endereco> ListaEndereco { get; private set; }
        public string NomeCliente { get; private set; }
        public List<Contato> Contato { get; private set; }
        public List<Pedido> ListaPedidos { get; private set; }

    }
}
