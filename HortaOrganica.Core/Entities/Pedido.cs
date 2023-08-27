using HortaOrganica.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HortaOrganica.Core.Entities
{
    public class Pedido : BaseEntity
    {
        public Cliente Cliente { get; private set; }
        public int IdCliente { get; private set; }
        public string NomeCliente { get; private set; }
        public decimal ValorTotal { get; private set; }
        public List<Endereco> Items { get; private set; }
        public StatusPedidoEnum StatusPedido { get; private set; }

    }
}
