using DonViHanhChinh6102023.Entities;
using DonViHanhChinh6102023.Entities.Entities;
using DonViHanhChinh6102023.Repositories.IInterfacee;
using Microsoft.Extensions.Caching.Distributed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonViHanhChinh6102023.Repositories.impl
{
    public class DistrictRepository : CommonRepository<District>, IDistrictRepository
    {
        public DistrictRepository(DBHanhChinhContext context) : base(context)
        {
        }
    }
}
