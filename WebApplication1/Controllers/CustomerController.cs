using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Dto;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IMapper _mapper;

        public CustomerController(IMapper mapper)
        {
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult Get()
        {

            var entity = new Customer()
            {
                Name = "Mostafa",
                Age = 23,
                Phone = "01093511748",
                Address = new Address()
                {
                    Country = "Egypt",
                    State = "Kafr sheikh"
                }
            };
            var model = _mapper.Map<CustomerModel>(entity);
            return Ok(model);
        }


        [HttpPost]

        public IActionResult Create( CustomerModel model )
        {
            
             _mapper.Map<Customer>(model);

            //save in database
            return Ok();
        }
    }
}
