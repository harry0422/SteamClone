using SteamClone.Application.Games.DTOs;
using SteamClone.Application.Games.Mappers;
using StreamClone.Domain.Model.Games;
using StreamClone.Domain.Repositories.Games;
using System;
using System.Collections.Generic;

namespace SteamClone.Application.Games.Services
{
    public class GameService : IGameService
    {
        private readonly IGameRepository _gameRepository;

        public GameService(IGameRepository gameRepository)
        {
            _gameRepository = gameRepository;
        }

        public GameDto Get(GameIdDto dto)
        {
            return _gameRepository.Get(dto.Id).ToDto();
        }

        public IList<GameDto> GetAll()
        {
            return _gameRepository.GetAll().ToDto();
        }

        public void Add(NewGameDto dto)
        {
            Game game = new Game(dto.Name, dto.Category, dto.Developer, dto.Publisher, dto.PublicationDate, dto.Synopsis, dto.Classification);
            _gameRepository.Insert(game);

        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void Remove()
        {
            throw new NotImplementedException();
        }

        
    }
}