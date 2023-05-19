using EP.CursoMVC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP.CursoMVC.Infra.Data.EntityConfig
{
    class EnderecoConfig : EntityTypeConfiguration<Endereco>
    {
        public EnderecoConfig()
        {
            HasKey(e => e.EnderecoId);

            Property(e => e.CEP)
               .IsRequired()
               .HasMaxLength(8)
               .IsFixedLength();

            Property(e => e.Estado)
                .IsRequired()
                .HasMaxLength(2);

            Property(e => e.Cidade)
                .IsRequired()
                .HasMaxLength(100);

            Property(e => e.Bairro)
               .IsRequired()
               .HasMaxLength(100);

            Property(e => e.Numero)
               .IsRequired()
               .HasMaxLength(100);

            Property(e => e.Logradouro)
                .IsRequired()
                .HasMaxLength(100);



            ToTable("Endereco");

        }
    }
}