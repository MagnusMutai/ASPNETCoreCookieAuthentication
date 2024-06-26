﻿using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace ASPNETCoreCookieAuthentication.Controllers
{
    public class HomeController : Controller
    {
        [HttpPost("/mvc/login")]
        public async Task<IActionResult> Login()
        {
            await HttpContext.SignInAsync("default", new ClaimsPrincipal(
                new ClaimsIdentity(
                    new Claim[]
                    {
                        new Claim(ClaimTypes.NameIdentifier, Guid.NewGuid().ToString()),
                        new Claim(Guid.NewGuid().ToString(), Guid.NewGuid().ToString()),

new Claim(Guid.NewGuid().ToString(), Guid.NewGuid().ToString()),

new Claim(Guid.NewGuid().ToString(), Guid.NewGuid().ToString()),

new Claim(Guid.NewGuid().ToString(), Guid.NewGuid().ToString()),

new Claim(Guid.NewGuid().ToString(), Guid.NewGuid().ToString()),

new Claim(Guid.NewGuid().ToString(), Guid.NewGuid().ToString()),

new Claim(Guid.NewGuid().ToString(), Guid.NewGuid().ToString()),

new Claim(Guid.NewGuid().ToString(), Guid.NewGuid().ToString()),

new Claim(Guid.NewGuid().ToString(), Guid.NewGuid().ToString()),

new Claim(Guid.NewGuid().ToString(), Guid.NewGuid().ToString()),

new Claim(Guid.NewGuid().ToString(), Guid.NewGuid().ToString()),

new Claim(Guid.NewGuid().ToString(), Guid.NewGuid().ToString()),

new Claim(Guid.NewGuid().ToString(), Guid.NewGuid().ToString()),

new Claim(Guid.NewGuid().ToString(), Guid.NewGuid().ToString()),

new Claim(Guid.NewGuid().ToString(), Guid.NewGuid().ToString()),

new Claim(Guid.NewGuid().ToString(), Guid.NewGuid().ToString()),

new Claim(Guid.NewGuid().ToString(), Guid.NewGuid().ToString()),

new Claim(Guid.NewGuid().ToString(), Guid.NewGuid().ToString()),

new Claim(Guid.NewGuid().ToString(), Guid.NewGuid().ToString()),

new Claim(Guid.NewGuid().ToString(), Guid.NewGuid().ToString()),

new Claim(Guid.NewGuid().ToString(), Guid.NewGuid().ToString()),

new Claim(Guid.NewGuid().ToString(), Guid.NewGuid().ToString()),

new Claim(Guid.NewGuid().ToString(), Guid.NewGuid().ToString()),

new Claim(Guid.NewGuid().ToString(), Guid.NewGuid().ToString()),

new Claim(Guid.NewGuid().ToString(), Guid.NewGuid().ToString()),

new Claim(Guid.NewGuid().ToString(), Guid.NewGuid().ToString()),

new Claim(Guid.NewGuid().ToString(), Guid.NewGuid().ToString()),

new Claim(Guid.NewGuid().ToString(), Guid.NewGuid().ToString()),

new Claim(Guid.NewGuid().ToString(), Guid.NewGuid().ToString()),

                    },
                    "default"
                    )
                ));
            return Ok();
        }
    }
}
