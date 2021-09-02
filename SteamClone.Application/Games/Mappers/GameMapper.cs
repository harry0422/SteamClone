using SteamClone.Application.Games.DTOs;
using StreamClone.Domain.Model.Games;
using System.Collections.Generic;

namespace SteamClone.Application.Games.Mappers
{
    public static class GameMapper
    {
        public static GameDto ToDto(this Game game)
        {
            if (game == null) return null;
            
            GameDto dto = new GameDto();
            dto.Id = game.Id;
            dto.Name = game.Name;
            dto.Category = game.Category;
            dto.Developer = game.Developer;
            dto.Publisher = game.Publisher;
            dto.PublicationDate = game.PublicationDate;
            dto.Synopsis = game.Synopsis;
            dto.Classification = game.Classification;

            return dto;
        }

        public static IList<GameDto> ToDto(this IList<Game> games)
        {
            if (games == null) return null;

            IList<GameDto> dto = new List<GameDto>();

            foreach (var game in games)
            {
                dto.Add(game.ToDto());
            }

            return dto;
        }
    }
}