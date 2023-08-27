using HortaOrganica.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HortaOrganica.Infrastructure.Persistence.Configurations
{
    public class ItemPedidoConfigurations : IEntityTypeConfiguration<ItemPedido>
    {
        public void Configure(EntityTypeBuilder<ItemPedido> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
               .Property(x => x.ValorUnit)
               .HasPrecision(14, 2);

            builder
               .Property(x => x.ValorTotalItem)
               .HasPrecision(14, 2);

        }
    }
}
