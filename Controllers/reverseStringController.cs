using Microsoft.AspNetCore.Mvc;
using MiniChallenegeFivetoSeven.Services.reverseStringService;

namespace MiniChallenegeFivetoSeven.Controllers;

    [ApiController]
   [Route("[controller]")]

    public class reverseStringController : ControllerBase
    {
          public string reverseWord = "";

    private readonly IreverseStringService _reverseStringService;

    public reverseStringController(IreverseStringService reverseStringService)
    {
        _reverseStringService = reverseStringService;
    }

    [HttpGet]
        [Route("reverseString/{userInput}")]

        public string ReverseString(string userInput){

        return _reverseStringService.ReverseString(userInput);
        }
    }