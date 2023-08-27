using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HortaOrganica.Core.Entities
{
    public class ItemPedido : BaseEntity
    {
        public int SequenciaItem { get; private set; }
        public Pedido Pedido { get; private set;}
        public int? PedidoId { get; private set; }
        public Produto Produto { get; private set; }
        public int? ProdutoId { get; private set; }
        public int Quantidade { get; private set; }
        public decimal ValorUnit { get; private set; }
        public decimal ValorTotalItem { get; private set; }
    }
}
