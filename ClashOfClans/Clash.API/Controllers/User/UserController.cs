using Clash.Interfaces.Services;
using Clash.ValueObjectEntity.EntityManipulation;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;

namespace Clash.API.Controllers.User
{
    [Route("api/[controller]"), ApiController]
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult GetAllUsers()
        {
            try
            {
                return Ok(JsonConvert.SerializeObject(_userService.GetAllUser()));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult SaveUser([FromBody]VOUser user)
        {
            try
            {
                _userService.InsertUser(user);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        public IActionResult DeleteUser([FromBody]int id)
        {
            try
            {
                _userService.DeleteUser(id);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}