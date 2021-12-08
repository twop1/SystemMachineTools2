namespace Brigadires
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Autorizetion")]
    public partial class Autorizetion
    {
        [Key]
        public int Id_auto { get; set; }

        [Required]
        [StringLength(50)]
        public string EMail { get; set; }

        [Required]
        [StringLength(50)]
        public string Password_user { get; set; }

        [Required]
        [StringLength(1)]
        public string Status_auto { get; set; }
    }
}
