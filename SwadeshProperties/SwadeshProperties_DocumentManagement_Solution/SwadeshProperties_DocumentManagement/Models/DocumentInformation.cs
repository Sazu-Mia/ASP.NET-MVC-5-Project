namespace SwadeshProperties_DocumentManagement.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DocumentInformation")]
    public partial class DocumentInformation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DocumentInformation()
        {
            FileInformations = new HashSet<FileInformation>();
            MetaDataInformations = new HashSet<MetaDataInformation>();
        }

        [Key]
        public long DocumentyIdentity { get; set; }

        public int CategoryId { get; set; }

        [Required]
        [StringLength(150)]
        public string DocumentReferenceName { get; set; }

        [Column(TypeName = "date")]
        public DateTime DocumentDate { get; set; }

        [Required]
        [StringLength(250)]
        public string DocumentName { get; set; }

        [StringLength(500)]
        public string DocumentNameBangla { get; set; }

        [StringLength(1500)]
        public string Description { get; set; }

        public bool Status { get; set; }

        public virtual DocumentCategoryInfo DocumentCategoryInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FileInformation> FileInformations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MetaDataInformation> MetaDataInformations { get; set; }
    }
}
