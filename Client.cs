namespace Brigadires
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Client()
        {
            Machines = new HashSet<Machine>();
        }

        [Key]
        public int Id_client { get; set; }

        [Required]
        [StringLength(50)]
        public string Name_cirm { get; set; }

        [Required]
        [StringLength(80)]
        public string Adress_firm { get; set; }

        [Required]
        [StringLength(50)]
        public string FIO_contact { get; set; }

        [Required]
        [StringLength(11)]
        public string Telefon { get; set; }

        [Required]
        [StringLength(30)]
        public string Email { get; set; }

        [StringLength(30)]
        public string File_foto_client { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Machine> Machines { get; set; }
    }
}
