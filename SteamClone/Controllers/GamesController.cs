using Microsoft.AspNetCore.Mvc;
using SteamClone.Application.Games.DTOs;
using SteamClone.Application.Games.Services;
using SteamClone.Requests;
using StreamClone.Domain.Model.Games;
using System;
using System.Threading.Tasks;

namespace SteamClone.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        private readonly IGameService _gameService;
        private readonly IReviewService _reviewService;

        public GamesController(IGameService gameService, IReviewService reviewService)
        {
            _gameService = gameService;
            _reviewService = reviewService;
        }

        // GET: api/Games
        [HttpGet]
        public ActionResult GetGames()
        {
            return Ok(_gameService.GetAll());
        }

        // GET: api/Games/5
        [HttpGet("{id}")]
        public ActionResult GetGame(string id)
        {
            GameDto game = _gameService.Get(new GameIdDto(id));

            if (game == null)
            {
                return NotFound();
            }

            return Ok(game);
        }

        // PUT: api/Games/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGame(string id, Game game)
        {
            throw new NotImplementedException();
        }

        // POST: api/Games
        [HttpPost]
        public ActionResult PostGame(NewGameDto newGame)
        {
            _gameService.Add(newGame);
            return Ok();
        }

        // DELETE: api/Games/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGame(string id)
        {
            throw new NotImplementedException();
        }

        [HttpPost("{id}/reviews")]
        public IActionResult AddReview(string id, ReviewRequest review)
        {
            NewReviewDto newReview = new NewReviewDto(id, review.Rate, review.Comment);
            _reviewService.AddReview(newReview);
            return Ok();
        }
    }
}