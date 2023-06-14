namespace SwadeshProperties_DocumentManagement.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MetaDataInformation")]
    public partial class MetaDataInformation
    {
        [Key]
        public long MetaIdentity { get; set; }

        public long DocumentyIdentity { get; set; }

        [Required]
        [StringLength(150)]
        public string MetaName { get; set; }

        [StringLength(250)]
        public string MetaNameBangla { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public virtual DocumentInformation DocumentInformation { get; set; }
    }
}
