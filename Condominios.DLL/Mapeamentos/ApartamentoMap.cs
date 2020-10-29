using Condominios.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Condominios.DAL.Mapeamentos
{
    public class ApartamentoMap : IEntityTypeConfiguration<Apartamento>
    {
        public void Configure(EntityTypeBuilder<Apartamento> builder)
        {
            builder.HasKey(ap => ap.ApartamentoId);
            builder.Property(ap => ap.Numero).IsRequired();
            builder.Property(ap => ap.Andar).IsRequired();
            builder.Property(ap => ap.Foto).IsRequired();
            builder.Property(ap => ap.ProprietarioId).IsRequired();
            builder.Property(ap => ap.MoradorId).IsRequired(false);

            builder.HasOne(ap => ap.Proprietario).WithMany(ap => ap.ProprietarioApartamentos).HasForeignKey(ap => ap.ProprietarioId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(ap => ap.Morador).WithMany(ap => ap.MoradoresApartamentos).HasForeignKey(ap => ap.MoradorId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
