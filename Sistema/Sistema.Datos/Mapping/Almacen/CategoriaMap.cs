using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sistema.Entidades.Almacen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Datos.Mapping.Almacen
{
    public class CategoriaMap : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("categoria") // Se indca el nombre de la tabla
                .HasKey(c => c.idcategoria); // se indica la llave primaria
            builder.Property(c => c.nombre)
                    .HasMaxLength(50);
            builder.Property(c => c.descripcion)
                    .HasMaxLength(256);
        }
    }
}
