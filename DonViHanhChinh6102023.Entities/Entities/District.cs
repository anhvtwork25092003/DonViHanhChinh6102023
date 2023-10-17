using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonViHanhChinh6102023.Entities.Entities
{
    [Table("District")]
    public class District : IEntitiesWithName
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public int Id { get; set; }

        [Required]
        [Column("Name")]
        [MaxLength(255)]
        [Description("This column stores the district name.")]
        public string Name { get; set; }

        [ForeignKey("ProvinceId")]
        public int ProvinceId { get; set; } // Khóa ngoại tới Province


        public virtual Province Province { get; set; }

        public virtual List<Ward> Wards { get; set; }

    }

}
