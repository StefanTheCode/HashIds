using HashIds.Models;
using HashIds.Services;
using HashidsNet;
using Microsoft.AspNetCore.Mvc;

namespace HashIds.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IHashids _hashids;
        private readonly IUserService _userService;

        public UserController(IHashids hashids, IUserService userService)
        {
            _hashids = hashids;
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Get(string id)
        {
            //Get the string version of the number 1
            //string encodedFirstUser = _hashids.Encode(1);

            int[] intId = _hashids.Decode(id);

            if (intId.Length == 0) return NotFound();

            ReturnUser user = _userService.GetUser(intId[0]);

            if (user is null) return NotFound();

            return Ok(user);
        }
    }
}
