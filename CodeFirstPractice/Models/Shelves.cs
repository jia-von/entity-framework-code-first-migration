using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CodeFirstPractice.Models
{
    [Table("Shelves")] //A table called “Shelves” with:
    public partial class Shelves
    {
        //An int primary key called ID.
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id", TypeName = "int(10)")]
        public int ID { get; set; }

        //A varchar of length 50 called Name.
        [Column("name", TypeName = "varchar(50)")]
        [Required]
        public string Name { get; set; }

    }
}
