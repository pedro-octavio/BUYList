using System;
using BUYList.Application.DTOs;
using BUYList.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BUYList.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController :
    ControllerBase
    {
        private readonly IUserApplicationService _userApplicationService;

        public UserController
        (IUserApplicationService userApplicationService) => _userApplicationService = userApplicationService;

        [HttpGet("{email}")]
        public IActionResult Get
        ([FromRoute] string email)
        {
            try
            {
                return Ok(_userApplicationService.GetByEmail(email));
            }
            catch
            (Exception ex)
            {
                return BadRequest(error: ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Post
        ([FromBody] UserDTO userDTO)
        {
            try
            {
                userDTO.Id = Guid.NewGuid();

                _userApplicationService.Add(userDTO);

                return Ok(userDTO);
            }
            catch
            (Exception ex)
            {
                return BadRequest(error: ex.Message);
            }
        }

        [HttpPut]
        public IActionResult Put
        ([FromBody] UserDTO userDTO)
        {
            try
            {
                _userApplicationService.ValidateUser(userDTO.Id.ToString(), User.Identity.Name);

                _userApplicationService.Update(userDTO);

                return Ok(userDTO);
            }
            catch
            (Exception ex)
            {
                return BadRequest(error: ex.Message);
            }
        }

        [HttpDelete("{email}")]
        [Authorize]
        public IActionResult Delete
        ([FromRoute] string email)
        {
            try
            {
                _userApplicationService.ValidateUser(email, User.Identity.Name);

                _userApplicationService.Remove(email);

                return Ok("User successfully removed.");
            }
            catch
            (Exception ex)
            {
                return BadRequest(error: ex.Message);
            }
        }
    }
}
