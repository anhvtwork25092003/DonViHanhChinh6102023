using DonViHanhChinh6102023.Entities;
using DonViHanhChinh6102023.Entities.Entities;
using DonViHanhChinh6102023.Repositories.IInterfacee;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonViHanhChinh6102023.Repositories.impl
{
    public class ProvinceRepository : CommonRepository<Province>, IProvinceRepository
    {
        public ProvinceRepository(DBHanhChinhContext context) : base(context)   
        {
        }

        // Các phương thức đặc thù cho Province có thể được triển khai ở đây nếu cần
    }
}
