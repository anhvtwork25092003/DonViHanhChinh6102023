using AutoMapper;
using DonViHanhChinh6102023.Domain.request;
using DonViHanhChinh6102023.Domain.response;
using DonViHanhChinh6102023.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonViHanhChinh6102023.Services.hepler
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper()
        {
            // province
            CreateMap<Province, ProvinceResponse>();
            CreateMap<ProvinceForCreate, Province>();
            CreateMap<ProvinceForDelete, Province>();
            CreateMap<ProvinceForUpdate, Province>();     
            // district
            CreateMap<District, DistrictResponse>().ReverseMap();
            CreateMap<DistrictForCreate, District>();
            CreateMap<DistrictForDelete, District>();
            CreateMap<DistrictForUpdate, District>();        
            // ward
            CreateMap<Ward, WardResponse>().ReverseMap();
            CreateMap<WardforCreate, Ward>();
            CreateMap<WardforUpdate, District>();
            CreateMap<WardforDelete, District>();
        }
    }
}
