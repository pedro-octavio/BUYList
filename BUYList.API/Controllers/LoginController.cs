using System;
using BUYList.Application.DTOs;
using BUYList.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BUYList.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class LoginController :
    ControllerBase
    {
        private readonly ITokenApplicationService _tokenApplicationService;

        public LoginController
        (ITokenApplicationService tokenApplicationService) => _tokenApplicationService = tokenApplicationService;

        [HttpPost]
        public IActionResult Post
        ([FromBody] UserDTO userDTO)
        {
            try
            {
                return Ok(_tokenApplicationService.GenerateToken(userDTO));
            }
            catch
            (Exception ex)
            {
                return BadRequest(error: ex.Message);
            }
        }

    }
}
