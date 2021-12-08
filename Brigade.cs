namespace Brigadires
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Brigade
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Brigade()
        {
            Zakazs = new HashSet<Zakaz>();
        }

        [Key]
        public int Id_brigada { get; set; }

        [Required]
        [StringLength(50)]
        public string FIO_boss { get; set; }

        [StringLength(50)]
        public string Foto_boss { get; set; }

        [StringLength(150)]
        public string Comment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zakaz> Zakazs { get; set; }
    }
}
