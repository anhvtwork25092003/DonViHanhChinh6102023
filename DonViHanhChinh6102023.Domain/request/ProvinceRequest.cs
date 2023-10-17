using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonViHanhChinh6102023.Domain.request
{
    public class ProvinceForCreate
    {
        public string Name { get; set; }
    }

    public class ProvinceForUpdate
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class ProvinceForDelete
    {
        public int Id { get; set; }
    }
}
