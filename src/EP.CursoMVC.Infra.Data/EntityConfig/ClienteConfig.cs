using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using EP.CursoMVC.Domain.Entities;
using System.Data.Entity.Infrastructure.Annotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EP.CursoMVC.Infra.Data.EntityConfig
{
    class ClienteConfig : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfig()
        {
            HasKey(c => c.ClienteId);
            //HasKey(c => new {c.ClienteId, c.CPF}); -> Chave composta

            //NOME
            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnName("CLI_Nome")
                //.HasColumnType("varchar")
                ;

            //EMAIL
            Property(c => c.Email)
                .IsRequired()
                .HasMaxLength(100);

            //CPF
            Property(c => c.Email)
                .IsRequired()
                .HasMaxLength(11)
                .IsFixedLength()
                .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute() { IsUnique = true }));

            Property(c => c.DataNascimento)
                .IsRequired();

            Property(c => c.Ativo)
                .IsRequired();

            ToTable("Clientes");

            
        }

    }
}
