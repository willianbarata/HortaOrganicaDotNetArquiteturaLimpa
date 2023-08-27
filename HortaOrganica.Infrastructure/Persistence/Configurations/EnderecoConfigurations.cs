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
    public class EnderecoConfigurations : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
               .HasOne(x => x.Cliente)
               .WithMany(x => x.ListaEndereco)
               .HasForeignKey(x => x.IdCliente)
               .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
