using DonViHanhChinh6102023.Domain.request;
using DonViHanhChinh6102023.Domain.response;
using DonViHanhChinh6102023.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonViHanhChinh6102023.Services.IInterfaceService
{
    public interface IDistrictService : ICommonService<District, DistrictForCreate, DistrictForUpdate, DistrictForDelete, DistrictResponse>
    {
    }
}
