using DonViHanhChinh6102023.Domain.request;
using DonViHanhChinh6102023.Domain.response;
using DonViHanhChinh6102023.Entities.Entities;
using DonViHanhChinh6102023.Repositories.IInterfacee;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonViHanhChinh6102023.Services.IInterfaceService
{
    public interface IProvinceService:ICommonService<Province, ProvinceForCreate, ProvinceForUpdate, ProvinceForDelete, ProvinceResponse>
    {
        //List<ProvinceResponse> getAllsync();

        //ProvinceResponse getOne(int id);
        //ProvinceResponse addProvince(ProvinceForCreate provinceForCreate);
        //ProvinceResponse updateProvince(ProvinceForUpdate provinceForUpdate);

        //bool deleteProvince(ProvinceForDelete provinceForDelete);
    }
}
