using ASPCoreDI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPCoreDI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private ICreatorFcatory _factory { get; set; }
        public ValuesController(ICreatorFcatory fcatory)
        {
            _factory = fcatory;
        }
    
        [HttpGet]
        public ActionResult Get([FromServices] ICreatorFcatory creators)
        {
           var creator=  creators.GetCreator("one");
            return Ok(creator.Name);
        }

       
    }
}
