namespace SwadeshProperties_DocumentManagement.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DocumentCategoryInfo")]
    public partial class DocumentCategoryInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DocumentCategoryInfo()
        {
            DocumentInformations = new HashSet<DocumentInformation>();
        }

        [Key]
        public int CategoryId { get; set; }

        [Required]
        [StringLength(150, MinimumLength =3)]
        public string CategoryName { get; set; }

        [StringLength(250, MinimumLength =3)]
        public string CategoryNameBangla { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public bool Status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentInformation> DocumentInformations { get; set; }
    }
}
