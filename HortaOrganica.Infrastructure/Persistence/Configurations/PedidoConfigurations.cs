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
    public class PedidoConfigurations : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .HasOne(x => x.Cliente)
                .WithMany(x => x.ListaPedidos)
                .HasForeignKey(x => x.IdCliente)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Property(x => x.ValorTotal)
                .HasPrecision(14, 2);


        }
    }
}
