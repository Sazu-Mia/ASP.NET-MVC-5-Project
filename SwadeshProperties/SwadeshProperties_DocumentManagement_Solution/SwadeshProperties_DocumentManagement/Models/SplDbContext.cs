using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace SwadeshProperties_DocumentManagement.Models
{
    public partial class SplDbContext : DbContext
    {
        public SplDbContext()
            : base("name=SPLDbContext")
        {
        }

        public virtual DbSet<DocumentCategoryInfo> DocumentCategoryInfoes { get; set; }
        public virtual DbSet<DocumentInformation> DocumentInformations { get; set; }
        public virtual DbSet<FileInformation> FileInformations { get; set; }
        public virtual DbSet<MetaDataInformation> MetaDataInformations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DocumentCategoryInfo>()
                .HasMany(e => e.DocumentInformations)
                .WithRequired(e => e.DocumentCategoryInfo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DocumentInformation>()
                .HasMany(e => e.FileInformations)
                .WithRequired(e => e.DocumentInformation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DocumentInformation>()
                .HasMany(e => e.MetaDataInformations)
                .WithRequired(e => e.DocumentInformation)
                .WillCascadeOnDelete(false);
        }
    }
}
