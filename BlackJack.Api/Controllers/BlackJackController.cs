using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlackJack.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace BlackJack.Api.Controllers
{
    [Route("api/black-jack")]
    public class BlackJackController : Controller
    {
        private readonly IGameService _gameService;

        public BlackJackController(IGameService gameService)
        {
            _gameService = gameService;
        }

        // GET api/values
        [HttpGet("start/{playerName}")]
        public IActionResult Start(string playerName)
        {
            if (string.IsNullOrWhiteSpace(playerName))
            {
                BadRequest("playerName is null or empty");
            }

            var start = _gameService.Start(playerName);
            return Ok(start);
        }

        
    }
}
