using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HortaOrganica.Core.Entities
{
    public class Contato : BaseEntity
    {
        public string Numero { get; private set; }
        public Cliente Cliente { get; private set; }
        public int IdCliente { get; private set; }
    }
}
