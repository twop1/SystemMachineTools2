namespace Brigadires
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Machine
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Machine()
        {
            Zakazs = new HashSet<Zakaz>();
        }

        [Key]
        public int Id_machine { get; set; }

        public int Id_сlient { get; set; }

        public int Id_vid_machine { get; set; }

        [Required]
        [StringLength(50)]
        public string Mark { get; set; }

        public int Id_made { get; set; }

        public int Year_machine { get; set; }

        public virtual Client Client { get; set; }

        public virtual Made Made { get; set; }

        public virtual Vid_Machine Vid_Machine { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zakaz> Zakazs { get; set; }
    }
}
