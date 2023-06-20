using APIDemo2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIDemo2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {

        //[HttpGet(Name = "GetDemoModel")]
        [HttpGet("GetDemoModel")]
        public IEnumerable<DemoModel> Get()
        {
         
            List<DemoModel>  demos= new List<DemoModel>();
            demos.Add(new DemoModel { Id=1,Name="Test"});
            demos.Add(new DemoModel { Id = 2, Name = "Test2" });
            demos.Add(new DemoModel { Id = 3, Name = "Test3" });
            demos.Add(new DemoModel { Id = 4, Name = "Test3" });

            return demos;            
        }


    }
}