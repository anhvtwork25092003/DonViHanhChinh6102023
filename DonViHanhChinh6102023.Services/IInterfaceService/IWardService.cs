using DonViHanhChinh6102023.Domain.request;
using DonViHanhChinh6102023.Domain.response;
using DonViHanhChinh6102023.Entities.Entities;
using DonViHanhChinh6102023.Repositories.IInterfacee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonViHanhChinh6102023.Services.IInterfaceService
{
    public interface IWardService : ICommonService<Ward, WardforCreate, WardforUpdate, WardforDelete, WardResponse>
    {

    }
}
