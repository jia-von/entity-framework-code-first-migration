using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CodeFirstPractice.Models
{
    // Create a “ShelfMaterials” model:

    [Table("ShelfMaterial")] // A table called ShelfMaterial with:
    public partial class ShelfMaterials
    {
        public ShelfMaterials ()
        {
            Shelves = new HashSet<Shelves>();
        }

        [Key] // An int primary key called “ID”.

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id", TypeName = "int(10)")]
        public int ID { get; set; }



        // A varchar of length 25 called “MaterialName”.
        [Column("material_name", TypeName = "varchar(25)")]
        [StringLength(30)]
        [Required]
        public string MaterialName { get; set; }

        [InverseProperty(nameof(Models.Shelves.ShelfMaterials))]

        // The requisite virtual properties for references.
        public virtual ICollection<Shelves> Shelves { get; set; }
    }
}
