using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using SteamClone.Application.Users.DTOs;
using SteamClone.Application.Users.Services;
using SteamClone.Responses;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace SteamClone.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OAuthController : ControllerBase
    {
        private readonly IUserService _userService;

        public OAuthController(IUserService userService)
        {
            _userService = userService;
        }

        // POST api/OAuth
        [HttpPost]
        public ActionResult Post(CredentialsDto credentials)
        {
            try
            {
                UserDto user = _userService.GetByCredentials(credentials);
                string token = CreateTokenFor(user);

                return Ok(new AuthenticationResponse(token, user));
            }
            catch (Exception e)
            {
                return Unauthorized(new ErrorResponse(e));
            }
        }

        private string CreateTokenFor(UserDto user)
        {
            //Claim[] claims = new[]
            //{
            //    new Claim(ClaimTypes.Name, user.UsuarioDirectorio),
            //    new Claim(ClaimTypes.Role, user.Perfil.Descripcion)
            //};

            byte[] secretBytes = Encoding.UTF8.GetBytes(GlobalConstants.Secret);
            SymmetricSecurityKey key = new SymmetricSecurityKey(secretBytes);
            string algorithm = SecurityAlgorithms.HmacSha256;

            SigningCredentials signingCredentials = new SigningCredentials(key, algorithm);

            JwtSecurityToken token = new JwtSecurityToken(
                issuer: GlobalConstants.Issuer,
                audience: GlobalConstants.Audiance,
                //claims: claims,
                notBefore: DateTime.Now,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: signingCredentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}