using SteamClone.Application.Games.DTOs;
using System.Collections.Generic;

namespace SteamClone.Application.Games.Services
{
    public interface IGameService
    {
        public IList<GameDto> GetAll();
        public GameDto Get(GameIdDto dto);
        public void Add(NewGameDto dto);
        public void Update();
        public void Remove();

    }
}