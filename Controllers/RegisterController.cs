using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MySocialNetwork.Models;

namespace MySocialNetwork.Controllers
{
    public class RegisterController: Controller
    {
        private IMapper _mapper
        [Route("Register")]
        [HttpGet]
        public IActionResult Register()
        {
            return View("Home/Register");
        }

        [Route("RegisterPart2")]
        [HttpGet]
        public IActionResult RegisterPart2(RegisterViewModel model)
        {
            return View("RegisterPart2", model);
        }
    }
}
