namespace practice.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("store")]
    public partial class store
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int book_id { get; set; }

        [Required]
        [StringLength(30)]
        public string book_name { get; set; }

        public int book_price { get; set; }

        [Required]
        [StringLength(30)]
        public string author_name { get; set; }

        public int year_published { get; set; }
    }
}
