using Microsoft.AspNetCore.Mvc;
using MiniChallenegeFivetoSeven.Services.OddOrEvenService;

namespace MiniChallenegeFivetoSeven.Controllers;

    [ApiController]
    [Route("[controller]")]

    public class OddOrEvenController : ControllerBase
    {
        private readonly IOddOrEvenService _OddOrEvenService;
    public OddOrEvenController(IOddOrEvenService OddOrEvenService)
    {
        _OddOrEvenService = OddOrEvenService;
    }

    [HttpGet]
    [Route("OddOrEven/{num}")]

    public string OddOrEven(string num){

        return _OddOrEvenService.OddOrEven(num);
    }       

    }
