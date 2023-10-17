using AutoMapper;
using DonViHanhChinh6102023.Domain.request;
using DonViHanhChinh6102023.Domain.response;
using DonViHanhChinh6102023.Entities.Entities;
using DonViHanhChinh6102023.Repositories.IInterfacee;
using DonViHanhChinh6102023.Repositories.impl;
using DonViHanhChinh6102023.Services.IInterfaceService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonViHanhChinh6102023.Services.impl
{
    public class DistrictServiceimpl : IDistrictService
    {
        private IDistrictRepository _districtRepository;
        private IMapper _mapper;

        public DistrictServiceimpl(IDistrictRepository districtRepository, IMapper mapper)
        {
            _districtRepository = districtRepository;
            _mapper = mapper;
        }
        public DistrictResponse Add(DistrictForCreate entityForCreate)
        {           
            // chuyyen provinceForCreate thanh province
            District district = _mapper.Map<District>(entityForCreate);

            // goi puong thuc them tu repo -> tra ve province
            District district1 = _districtRepository.AddObjects(district);

            // chuyen doi provice thanh provinceresoinse

            DistrictResponse districtResponse = _mapper.Map<DistrictResponse>(district1);


            return districtResponse;
        }

        public bool Delete(DistrictForDelete entityForDelete)
        {
            // chuyen dto thganh entities
            District district = _mapper.Map<District>(entityForDelete);

            return _districtRepository.DeleteObjects(district);
        }

        public List<DistrictResponse> GetAllSync()
        {
            // Lấy danh sách các tỉnh từ _provinceRepository
            List<District> districts = _districtRepository.GetAllObjects();
           // chuyen tu entities qua dto
            List<DistrictResponse> districtResponses = _mapper.Map<List<DistrictResponse>>(districts);
            // Tính chỉ số bắt đầu (startIndex) và lấy bản ghi cho trang hiện tại
            return districtResponses;
        }

        public DistrictResponse GetOne(int id)
        {
                District district = _districtRepository.GetByIdAsync(id);

                DistrictResponse districtResponse = _mapper.Map<DistrictResponse>(district);
                return districtResponse;
        }

        public DistrictResponse Update(DistrictForUpdate entityForUpdate)
        {
            // anh xa provineforupdate thanh province

            District district = _mapper.Map<District>(entityForUpdate);

            // update province
            District district1 = _districtRepository.UpdateObject(district);

            // anh xa nguoc thanh response
            DistrictResponse districtResponse = _mapper.Map<DistrictResponse>(district);

            return districtResponse;


        }
    }
}
