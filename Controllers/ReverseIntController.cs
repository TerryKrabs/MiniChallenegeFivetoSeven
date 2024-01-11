using Microsoft.AspNetCore.Mvc;
using MiniChallenegeFivetoSeven.Services.reverseIntService;

namespace MiniChallenegeFivetoSeven.Controllers;

   [ApiController]
   [Route("[controller]")]


    public class ReverseIntController : ControllerBase
    {



        public string reverse = "";
    private readonly IreverseIntService _reverseIntService;
    public ReverseIntController(IreverseIntService reverseIntService)
    {
        _reverseIntService = reverseIntService;
    }

    [HttpGet]
        [Route("ReverseInt/{userInput}")]

        public string ReverseInt(string userInput){

            return _reverseIntService.ReverseInt(userInput);


    }
    }



