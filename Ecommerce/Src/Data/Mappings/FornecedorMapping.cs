using Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Mappings 
{
    class FornecedorMapping : IEntityTypeConfiguration<Fornecedor>
    
   {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder.HasKey(f => f.Id);

            builder.Property(f => f.Nome).IsRequired().HasColumnType("varchar(200)");
            builder.Property(f => f.Documento).IsRequired().HasColumnType("varchar(14)");

            builder.HasOne(f => f.Endereco).WithOne(f => f.Fornecedor);
            builder.HasMany(f => f.Produtos).WithOne(f => f.Fornecedor).HasForeignKey(f => f.FornecedorID);

            builder.ToTable("Fornecedores");
        }
   }
}
