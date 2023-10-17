using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace DonViHanhChinh6102023.Entities.Entities
{
    [Table("Ward")]
    public class Ward : IEntitiesWithName
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public int Id { get; set; }

        [Required]
        [Column("Name")] // Đặt tên cột là "ProvinceName"
        [MaxLength(255)] // Giới hạn độ dài tối đa của dữ liệu là 255 ký tự
        [Description("This column stores the WardName.")]
        public string Name { get; set; }

        [ForeignKey("DistrictID")]
        public int DistrictID { get; set; }

        public virtual District District { get; set; }
    }
}
