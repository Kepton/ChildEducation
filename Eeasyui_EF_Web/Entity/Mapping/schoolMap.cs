using System.ComponentModel.DataAnnotations.Schema;
using Entity;
using System.Data.Entity.ModelConfiguration;

namespace Entity
{
    public class schoolMap : EntityTypeConfiguration<school>
    {
        public schoolMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("school", "childeducation");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Area).HasColumnName("Area");
        }
    }
}
