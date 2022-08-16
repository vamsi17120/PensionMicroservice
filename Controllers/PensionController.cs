using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PensionMicroService.Models;
using PensionMicroService.Reposittory;

namespace PensionMicroService.Controllers
{
   
    [ApiController]
    [Route("[controller]")]
    
    public class PensionController : ControllerBase
    {

        private readonly IPensionRepository pensionRepository;
        public PensionController(IPensionRepository pensionRepository)
        {
            this.pensionRepository = pensionRepository;
        }

        [HttpGet("aadhar")]
       

        public async Task<IActionResult> GetPensionDetails(double aadhar )
        {
            
                var Pensionerobj=await pensionRepository.GetPensioner(aadhar);
            
            

           
            return Ok(Pensionerobj);
        }
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetAllPensioners()
        {
            var Pensionerobj=await pensionRepository.GetAllPensioners();
            return Ok(Pensionerobj.ToList());
        }

        [HttpGet("Name")]
     
        public async Task<IActionResult> GetAllDetails( string Name)
        {
            var obj = await pensionRepository.GetAllDetails(Name);
            return Ok(obj);
        }
    }
}
