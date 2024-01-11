using Microsoft.AspNetCore.Mvc;
using MiniChallenegeFivetoSeven.Services.MadLibService;

namespace MiniChallenegeFivetoSeven.Controllers;

    [ApiController]
    [Route("[controller]")]
    public class MadLibController : ControllerBase
    {
  
        private readonly ImadLibService _MadLibService;
    public MadLibController(ImadLibService MadLibService)
    {
        _MadLibService = MadLibService;
    }

    [HttpGet]
    [Route("MadLib/{Name1}/{Noun1}/{Adjective1}/{Activity}/{Verb1}/{Name2}/{Noun2}/{Name3}/{Noun3}/{ptVerb}/{SongName}/{Adjective2}/{Name4}/{Adjective3}")]

        public string MadLib(string Name1, string Noun1, string Adjective1, string Activity, string Verb1, string Name2, string Noun2, string Name3, string Noun3, string ptVerb, string SongName, string Adjective2, string Name4, string Adjective3){
            return _MadLibService.MadLib(Name1, Noun1, Adjective1, Activity, Verb1, Name2, Noun2, Name3, Noun3, ptVerb, SongName,  Adjective2, Name4, Adjective3);
        }
    }
