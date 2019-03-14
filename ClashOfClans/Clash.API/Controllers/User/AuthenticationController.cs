using Clash.Common.ValueObjects;
using Clash.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;

namespace Clash.API.Controllers.User
{
    [Route("api/[controller]"), ApiController]
    public class AuthenticationController : Controller
    {
        private readonly IAuthenticationService _authenticationService;

        public AuthenticationController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        [HttpPost]
        public IActionResult Login([FromBody]AuthUser authUser)
        {
            try
            {
                return Ok(_authenticationService.Login(authUser));
            }
            catch (UnauthorizedAccessException)
            {
                return Unauthorized();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("currentUser/{id}"), HttpGet, Authorize]
        public IActionResult GetCurrentUser(int id)
        {
            try
            {
                return Ok(JsonConvert.SerializeObject(_authenticationService.GetCurrentUser(id)));
            }
            catch (Exception)
            {
                return BadRequest("Usuário não autenticado!");
            }
        }

        [HttpGet, Authorize]
        public IActionResult CheckUser()
        {
            try
            {
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest("Usuário não autenticado!");
            }
        }
    }
}