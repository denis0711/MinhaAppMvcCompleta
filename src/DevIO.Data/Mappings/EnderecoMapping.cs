using DevIO.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevIO.Data.Mappings
{
    public class EnderecoMapping : IEntityTypeConfiguration<Endereco>
        {
            public void Configure(EntityTypeBuilder<Endereco> builder)
            {
                builder.HasKey(p => p.Id);

                builder.Property(c => c.Logradouro)
                .IsRequired()
                .HasColumnType("Varchar(200)");

                builder.Property(c => c.Numero)
                .IsRequired()
                .HasColumnType("Varchar(50)");

                builder.Property(c => c.Cep)
                .IsRequired()
                .HasColumnType("Varchar(8)");


                builder.Property(c => c.Complemento)              
                    .HasColumnType("Varchar(250)");

                builder.Property(c => c.Bairro)
                    .IsRequired()
                    .HasColumnType("Varchar(100)");


                builder.Property(c => c.Cidade)
                    .IsRequired()
                    .HasColumnType("Varchar(100)");

                builder.Property(c => c.Estado)
                    .IsRequired()
                    .HasColumnType("Varchar(50)");


            builder.ToTable("Enderecos");




        }
        }
}
