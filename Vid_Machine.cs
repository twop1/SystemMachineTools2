namespace Brigadires
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Vid_Machine
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vid_Machine()
        {
            Machines = new HashSet<Machine>();
        }

        [Key]
        public int Id_vid_machine { get; set; }

        [Required]
        [StringLength(50)]
        public string Machine_name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Machine> Machines { get; set; }
    }
}
