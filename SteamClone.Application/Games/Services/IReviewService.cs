using SteamClone.Application.Games.DTOs;

namespace SteamClone.Application.Games.Services
{
    public interface IReviewService
    {
        public void AddReview(NewReviewDto dto);
    }
}