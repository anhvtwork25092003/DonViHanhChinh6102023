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
    [Table("Provinces")]
    public class Province : IEntitiesWithName
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public int Id { get; set; }

        [Required]
        [Column("Name")] // Đặt tên cột là "ProvinceName"
        [MaxLength(255)] // Giới hạn độ dài tối đa của dữ liệu là 255 ký tự
        [Description("This column stores the province name.")]
        public string Name { get; set; }
        public  virtual List<District> districts { get ; set ; }

    }
}
