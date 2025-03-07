using Microsoft.AspNetCore.Mvc;

namespace SzamnegyesApi;

public class FourNumberController : Controller
{
   
    [ApiController]
    [Route("fours")]
    public class FourNumbersController : ControllerBase
    {
        private readonly FourNumberService _service;

        public FourNumbersController(FourNumberService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<FourNumber.FourNumbers>> GetAll() => _service.GetAll();

        [HttpGet("{id}")]
        public ActionResult<FourNumber.FourNumbers> GetById(int id)
        {
            var four = _service.GetById(id);
            return four != null ? Ok(four) : NotFound("Not found");
        }

        [HttpPost]
        public ActionResult<string> Add([FromBody] FourNumber.FourNumbers four)
        {
            var result = _service.Add(four);
            return result == "Success" ? Ok(result) : BadRequest(result);
        }
    }
}