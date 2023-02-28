using App1.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    // // Mapping Using Configration Class
    public class DepartementConfigration : IEntityTypeConfiguration<Departement>
    {
        public void Configure(EntityTypeBuilder<Departement> builder)
        {

            builder.HasKey(D => D.DeptId);
            builder.ToTable("Departements");
            builder
                .Property(D => D.DeptName)
                .IsRequired(true)
                .IsUnicode(true);

            builder
                .Property(D => D.YearOfCreation)
                .HasDefaultValue(DateTime.Now);
        }
    }
}
