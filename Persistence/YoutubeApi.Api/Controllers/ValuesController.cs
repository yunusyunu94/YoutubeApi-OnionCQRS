using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YoutubeApi.Application.İnterfaces.UnitOfWork;
using YoutubeApi.Domein.Entities;

namespace YoutubeApi.Api.Controllers
{
    // Test Amacli Yapildi



    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public ValuesController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> Get() 
        {
           return Ok(await unitOfWork.GetReadRepository<Product>().GetAllAsync());
        }

    }
}
