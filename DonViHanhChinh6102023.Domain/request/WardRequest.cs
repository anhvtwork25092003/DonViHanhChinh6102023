using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonViHanhChinh6102023.Domain.request
{
    public class WardforCreate
    {
        public string Name { get; set; }
        public int DistrictID { get; set; }

    }   
    public class WardforUpdate
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public int DistrictID { get; set; }
    }   
    public class WardforDelete
    {
        public int Id { get; set; }

    }
}
