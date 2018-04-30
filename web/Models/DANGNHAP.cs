namespace web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DANGNHAP")]
    public partial class DANGNHAP
    {
        [Key]
        [Column("DANGNHAP")]
        [StringLength(20)]
        public string DANGNHAP1 { get; set; }

        [Required]
        [StringLength(20)]
        public string MATKHAU { get; set; }
    }
}
