using AutoMapper;
using DonViHanhChinh6102023.Domain.request;
using DonViHanhChinh6102023.Domain.response;
using DonViHanhChinh6102023.Entities.Entities;
using DonViHanhChinh6102023.Repositories.IInterfacee;
using DonViHanhChinh6102023.Services.IInterfaceService;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DonViHanhChinh6102023.Services.impl
{
    public class ProvinceServiceImpl : IProvinceService
    {
        private IProvinceRepository _provinceRepository;
        private IMapper _mapper;

        public ProvinceServiceImpl(IProvinceRepository provinceRepository, IMapper mapper)
        {
            _provinceRepository = provinceRepository;
            _mapper = mapper;
        }

        public ProvinceResponse Add(ProvinceForCreate provinceForCreate)
        {

            // chuyyen provinceForCreate thanh province
            Province province = _mapper.Map<Province>(provinceForCreate);

            // goi puong thuc them tu repo -> tra ve province
            Province province1 = _provinceRepository.AddObjects(province);

            // chuyen doi provice thanh provinceresoinse

            ProvinceResponse provinceResponse = _mapper.Map<ProvinceResponse>(province1);


            return provinceResponse;
        }

        public bool Delete(ProvinceForDelete provinceForDelete)
        {
            // chuyen dto thganh province
            Province province = _mapper.Map<Province>(provinceForDelete);

            return _provinceRepository.DeleteObjects(province);


        }

        public List<ProvinceResponse> GetAllSync()
        {
            // Lấy danh sách các tỉnh từ _provinceRepository
            List<Province> provinces = _provinceRepository.GetAllObjects();
            List<ProvinceResponse> provinceResponses = _mapper.Map<List<ProvinceResponse>>(provinces);
            // Tính chỉ số bắt đầu (startIndex) và lấy bản ghi cho trang hiện tại
            return provinceResponses;
        }

        public ProvinceResponse GetOne(int id)
        {
            Province province = _provinceRepository.GetByIdAsync(id);

            ProvinceResponse provinceResponse = _mapper.Map<ProvinceResponse>(province);
            return provinceResponse; 
        }

        public ProvinceResponse Update(ProvinceForUpdate provinceForUpdate)
        {

            // anh xa provineforupdate thanh province

            Province province = _mapper.Map<Province>(provinceForUpdate);

            // update province
            Province province1 = _provinceRepository.UpdateObject(province);

            // anh xa nguoc thanh response
            ProvinceResponse provinceResponse = _mapper.Map<ProvinceResponse>(province1);

            return provinceResponse;



        }
    }
}
