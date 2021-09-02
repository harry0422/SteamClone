using Microsoft.AspNetCore.Mvc;
using SteamClone.Application.Users.DTOs;
using SteamClone.Application.Users.Services;
using SteamClone.Requests;

namespace SteamClone.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        
        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UsersController>
        [HttpPost]
        public IActionResult Post(NewUserDto newUser)
        {
            _userService.Add(newUser);
            return Ok();
        }

        [HttpPost("{id}/wishes")]
        public IActionResult AddWishList(string id, WishListRequest review)
        {
            NewWishListDto newWishList = new NewWishListDto(id, review.GameId);
            _userService.AddToWishList(newWishList);

            return Ok();
        }

        [HttpPost("{id}/libraries")]
        public IActionResult AddLibrary(string id, LibraryRequest library)
        {
            NewLibraryDto newLibrary = new NewLibraryDto(id, library.GameId);
            _userService.AddToLibrary(newLibrary);

            return Ok();
        }
    }
}