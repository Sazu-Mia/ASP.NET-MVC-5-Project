namespace SwadeshProperties_DocumentManagement.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FileInformation")]
    public partial class FileInformation
    {
        [Key]
        public long FileIdentity { get; set; }

        public long DocumentyIdentity { get; set; }

        [StringLength(50)]
        public string FileNo { get; set; }

        [Required]
        [StringLength(250)]
        public string FileName { get; set; }

        [StringLength(450)]
        public string FileNameBangla { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [StringLength(500)]
        public string FilePath { get; set; }

        [StringLength(500)]
        public string FileStatus { get; set; }

        public virtual DocumentInformation DocumentInformation { get; set; }
    }
}
