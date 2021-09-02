using SteamClone.Application.Games.DTOs;
using StreamClone.Domain.Model.Games;
using StreamClone.Domain.Repositories.Games;

namespace SteamClone.Application.Games.Services
{
    public class ReviewService : IReviewService
    {
        private readonly IGameRepository _gameRepository;

        public ReviewService(IGameRepository gameRepository)
        {
            _gameRepository = gameRepository;
        }

        //TODO: Perzonalizar excepcion
        public void AddReview(NewReviewDto dto)
        {
            Game game = _gameRepository.Get(dto.GameId);
            Review review = new Review(dto.Rate, dto.Comment);

            if (review.IsInvalid) throw new System.Exception();

            game.Reviews.Add(review);
            _gameRepository.Update(game);
        }
    }
}