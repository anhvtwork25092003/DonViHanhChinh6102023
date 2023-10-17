using DonViHanhChinh6102023.Domain.request;
using DonViHanhChinh6102023.Entities.Entities;
using DonViHanhChinh6102023.Services.IInterfaceService;
using Microsoft.AspNetCore.Mvc;
using PagedList;

namespace DonViHanhChinh6102023.Apis.Controllers
{

    [Route("api/ward")]
    [ApiController]
    public class WardController : Controller
    {
        private readonly IWardService _wardService;

        public WardController(IWardService wardService)
        {
            _wardService = wardService;
        }

        [HttpGet("get-list-ward")]
        public IActionResult GetAll(int page = 1, int pageSize = 10)
        {
            try
            {
                // Gọi phương thức getAllsync từ IProvinceService để lấy danh sách ProvinceResponse với phân trang
                var wards = _wardService.GetAllSync();
                var districtresponse = wards.ToPagedList((int)page, (int)pageSize);
                if (districtresponse == null)
                {
                    return StatusCode(500, "Internal server error");

                }
                int totalPages = districtresponse.PageCount;

                var result = new
                {
                    Data = districtresponse,
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

        [HttpGet("get-one-ward")]

        public IActionResult getOne(int Id)
        {
            try
            {
                var districts = _wardService.GetOne(Id);

                if (districts == null)
                {
                    return NotFound(); // Trả về 404 Not Found nếu không tìm thấy tỉnh với ID cung cấp.
                }
                // Trả về thông tin tỉnh dưới dạng phản hồi HTTP 200 OK
                return Ok(districts);
            }
            catch
            {
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpPost("add-ward")]

        public IActionResult add([FromBody] WardforCreate districtForCreate)
        {
            try
            {
                var districtresponse = _wardService.Add(districtForCreate);

                if (districtresponse == null)
                {
                    return NotFound(); // Trả về 404 Not Found nếu không tìm thấy tỉnh với ID cung cấp.
                }
                // Trả về thông tin tỉnh dưới dạng phản hồi HTTP 200 OK
                return Ok(districtresponse);
            }
            catch
            {
                return StatusCode(500, "Internal server error");

            }
        }



        [HttpDelete("delete-ward")]

        public IActionResult delete([FromBody] WardforDelete districtForDelete)
        {
            try
            {
                var districtresponse = _wardService.Delete(districtForDelete);

                if (districtresponse == false)
                {
                    return NotFound(); // Trả về 404 Not Found nếu không tìm thấy tỉnh với ID cung cấp.
                }
                // Trả về thông tin tỉnh dưới dạng phản hồi HTTP 200 OK
                return Ok(districtresponse);
            }
            catch
            {
                return StatusCode(500, "Internal server error");

            }
        }



        [HttpPost("update-district")]

        public IActionResult update([FromBody] WardforUpdate districtForUpdate)
        {
            try
            {
                var districtresponse = _wardService.Update(districtForUpdate);

                if (districtresponse == null)
                {
                    return NotFound(); // Trả về 404 Not Found nếu không tìm thấy tỉnh với ID cung cấp.
                }
                // Trả về thông tin tỉnh dưới dạng phản hồi HTTP 200 OK
                return Ok(districtresponse);
            }
            catch
            {
                return StatusCode(500, "Internal server error");

            }
        }
    }
}
