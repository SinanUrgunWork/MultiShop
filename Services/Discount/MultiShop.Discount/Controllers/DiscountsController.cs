using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Discount.Dtos;
using MultiShop.Discount.Services;

namespace MultiShop.Discount.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountsController : ControllerBase
    {
        private readonly IDiscountService _discountsServices;

        public DiscountsController(IDiscountService discountsServices)
        {
            _discountsServices = discountsServices;
        }
        [HttpGet]
        public async Task<IActionResult> CouponList()
        {
            var values =await _discountsServices.GetAllCouponAsync();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public  async   Task<IActionResult> GetCouponById(int id)
        {
            var values = await _discountsServices.GetByIdCoupondtoAsync(id);
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateCoupon(CreateCouponDto createCouponDto)
        {
            await _discountsServices.CreateCouponAsync(createCouponDto);
            return Ok("Coupon Created ");
        }
        [HttpDelete]
        public async Task<IActionResult>DeleteCoupon(int id)
        {
            await _discountsServices.DeleteCouponAsync(id);
            return Ok("Coupon Deleted");
        }
        [HttpPut]
        public  async Task<IActionResult> UpdateCoupon(UpdateCouponDto updateCouponDto)
        {
            await _discountsServices.UpdateCouponAsync(updateCouponDto);
            return Ok("coupon Updated");
        }

    }
}
