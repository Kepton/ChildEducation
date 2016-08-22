using System.ComponentModel.DataAnnotations.Schema;
using Entity;
using System.Data.Entity.ModelConfiguration;

namespace Entity
{
    public class teacherMap : EntityTypeConfiguration<teacher>
    {
        public teacherMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.SchoolId)
                .HasMaxLength(50);

            this.Property(t => t.EducationExp)
                .HasMaxLength(1000);

            this.Property(t => t.speciality)
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("teacher", "childeducation");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.SchoolId).HasColumnName("SchoolId");
            this.Property(t => t.Sex).HasColumnName("Sex");
            this.Property(t => t.EducationExp).HasColumnName("EducationExp");
            this.Property(t => t.speciality).HasColumnName("speciality");
        }
    }
}
