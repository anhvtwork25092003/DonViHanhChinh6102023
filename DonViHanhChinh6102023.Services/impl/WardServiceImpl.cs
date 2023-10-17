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
    public class WardServiceImpl : IWardService
    {
        private IWardRepository _wardRepository;
        private IMapper _mapper;

        public WardServiceImpl(IWardRepository districtRepository, IMapper mapper)
        {
            _wardRepository = districtRepository;
            _mapper = mapper;
        }

        public WardResponse Add(WardforCreate entityForCreate)
        {
            Ward ward = _mapper.Map<Ward>(entityForCreate);

            // goi puong thuc them tu repo -> tra ve province
            Ward district1 = _wardRepository.AddObjects(ward);

            // chuyen doi provice thanh provinceresoinse

            WardResponse districtResponse = _mapper.Map<WardResponse>(district1);


            return districtResponse;
        }

        public bool Delete(WardforDelete entityForDelete)
        {
            Ward district = _mapper.Map<Ward>(entityForDelete);

            return _wardRepository.DeleteObjects(district);
        }

        public List<WardResponse> GetAllSync()
        {
            List<Ward> districts = _wardRepository.GetAllObjects();
            // chuyen tu entities qua dto
            List<WardResponse> districtResponses = _mapper.Map<List<WardResponse>>(districts);
            // Tính chỉ số bắt đầu (startIndex) và lấy bản ghi cho trang hiện tại
            return districtResponses;
        }

        public WardResponse GetOne(int id)
        {
            Ward district = _wardRepository.GetByIdAsync(id);

            WardResponse districtResponse = _mapper.Map<WardResponse>(district);
            return districtResponse;
        }

        public WardResponse Update(WardforUpdate entityForUpdate)
        {

            Ward district = _mapper.Map<Ward>(entityForUpdate);

            // update province
            Ward district1 = _wardRepository.UpdateObject(district);

            // anh xa nguoc thanh response
            WardResponse districtResponse = _mapper.Map<WardResponse>(district);

            return districtResponse;
        }
    }
}
