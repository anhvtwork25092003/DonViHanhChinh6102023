using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonViHanhChinh6102023.Domain.request
{
    public class DistrictForCreate
    {
        public String Name { get; set; }
        public int ProvinceId { get; set; }
    }
    public class DistrictForUpdate
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int ProvinceId { get; set; }

    }
    public class DistrictForDelete
    {
        public int Id { get; set; }
    }
}
