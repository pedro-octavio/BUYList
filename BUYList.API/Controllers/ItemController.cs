using System;
using BUYList.Application.DTOs;
using BUYList.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BUYList.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ItemController :
    ControllerBase
    {
        private readonly IItemApplicationService _itemApplicationService;

        public ItemController
        (IItemApplicationService itemApplicationService) => _itemApplicationService = itemApplicationService;

        [HttpGet]
        public IActionResult Get
        ()
        {
            try
            {
                return Ok(_itemApplicationService.GetAll());
            }
            catch
            (Exception ex)
            {
                return BadRequest(error: ex.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get
        ([FromRoute] Guid id)
        {
            try
            {
                return Ok(_itemApplicationService.GetById(id));
            }
            catch
            (Exception ex)
            {
                return BadRequest(error: ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Post
        ([FromBody] ItemDTO itemDTO)
        {
            try
            {
                itemDTO.Id = Guid.NewGuid();

                itemDTO.CreateDate = DateTime.Now;

                _itemApplicationService.Add(itemDTO);

                return Ok(itemDTO);
            }
            catch
            (Exception ex)
            {
                return BadRequest(error: ex.Message);
            }
        }

        [HttpPut]
        public IActionResult Put
        ([FromBody] ItemDTO itemDTO)
        {
            try
            {
                _itemApplicationService.Update(itemDTO);

                return Ok(itemDTO);
            }
            catch
            (Exception ex)
            {
                return BadRequest(error: ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete
        ([FromRoute] Guid id)
        {
            try
            {
                _itemApplicationService.Remove(id);

                return Ok("Item successfully removed.");
            }
            catch
            (Exception ex)
            {
                return BadRequest(error: ex.Message);
            }
        }
    }
}
