using DonViHanhChinh6102023.Domain.request;
using DonViHanhChinh6102023.Domain.response;
using DonViHanhChinh6102023.Entities.Entities;
using DonViHanhChinh6102023.Services.IInterfaceService;
using Microsoft.AspNetCore.Mvc;
using PagedList;

namespace DonViHanhChinh6102023.Apis.Controllers
{
    [Route("api/provinces")]
    [ApiController]
    public class ProvinceController : ControllerBase
    {
        private readonly IProvinceService _provinceService;

        public ProvinceController(IProvinceService provinceService)
        {
            _provinceService = provinceService;
        }

        [HttpGet("get-list-province")]
        public IActionResult GetProvinces(int page = 1, int pageSize = 10)
        {
            try
            {
                // Gọi phương thức getAllsync từ IProvinceService để lấy danh sách ProvinceResponse với phân trang
                var provinces = _provinceService.GetAllSync();
                var provinceResponses = provinces.ToPagedList((int)page, (int)pageSize);

                int totalPages = provinceResponses.PageCount;

                var result = new
                {
                    Data = provinceResponses,
                    TotalPages = totalPages
                };
                // Trả về danh sách dưới dạng IPagedList<ProvinceResponse>
                return Ok(result);
            }
            catch (Exception ex)
            {
                // Ghi log lỗi ở đây.
                return StatusCode(500, "Internal server error"); // Trả về lỗi 500 Internal Server Error trong trường hợp ngoại lệ xảy ra.
            }
        }

        [HttpGet("get-one-province")]

        public IActionResult getOneProvince(int provinceId)
        {
            try
            {
                var province = _provinceService.GetOne(provinceId);

                if (province == null)
                {
                    return NotFound(); // Trả về 404 Not Found nếu không tìm thấy tỉnh với ID cung cấp.
                }
                // Trả về thông tin tỉnh dưới dạng phản hồi HTTP 200 OK
                return Ok(province);
            }
            catch
            {
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpPost("add-province")]

        public IActionResult addProvince([FromBody] ProvinceForCreate provinceForCreate)
        {
            try
            {
                var provinceresponse = _provinceService.Add(provinceForCreate);

                if (provinceresponse == null)
                {
                    return NotFound(); // Trả về 404 Not Found nếu không tìm thấy tỉnh với ID cung cấp.
                }
                // Trả về thông tin tỉnh dưới dạng phản hồi HTTP 200 OK
                return Ok(provinceresponse);
            }
            catch
            {
                return StatusCode(500, "Internal server error");

            }
        }
        [HttpPut("update-province")]

        public IActionResult update([FromBody] ProvinceForUpdate provinceForUpdate)
        {
            try
            {
                var provinceresponse = _provinceService.Update(provinceForUpdate);

                if (provinceresponse == null)
                {
                    return NotFound(); // Trả về 404 Not Found nếu không tìm thấy tỉnh với ID cung cấp.
                }
                // Trả về thông tin tỉnh dưới dạng phản hồi HTTP 200 OK
                return Ok(provinceresponse);
            }
            catch
            {
                return StatusCode(500, "Internal server error");

            }
        }



        [HttpDelete("delete-province")]

        public IActionResult deleteProvince([FromBody] ProvinceForDelete provinceForDelete)
        {
            try
            {
                var provinceresponse = _provinceService.Delete(provinceForDelete);

                if (provinceresponse == false)
                {
                    return NotFound(); // Trả về 404 Not Found nếu không tìm thấy tỉnh với ID cung cấp.
                }
                // Trả về thông tin tỉnh dưới dạng phản hồi HTTP 200 OK
                return Ok(provinceresponse);
            }
            catch
            {
                return StatusCode(500, "Internal server error");

            }
        }
    }


}





