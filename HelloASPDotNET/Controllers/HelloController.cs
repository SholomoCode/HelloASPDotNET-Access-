﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloASPDotNET.Controllers
{
    [Route("/helloworld")]
    public class HelloController : Controller
    {
        // GET: /helloworld/
        [HttpGet]
        public IActionResult Index()
        {
            string html = "<form method='post'>" +
                "<input type='text' name='name' />" +
                "<select name='language'>"+
                "<option value='english' selected>English</option>" +
                "<option value='spanish'>Spanish</spanish>" +
                "<option value='bosnian'>Bosnian</option>" +
                "<option value='vietnamese'>Vietnamese</option>" +
                "<option value='french'>French</option></select>" +
                "<input type='submit' value='Greet Me!'/>" +
                "</form>";

            return Content(html, "text/html");
        }

        // GET: /helloworld/welcome
        // POST: /helloworld/welcome
        [HttpPost("welcome")]
        [HttpGet("welcome/{name?}")]
        public IActionResult Welcome(string name = "World")
        {
            return Content("<h1>Welcome to my app, " + name + "!</h1>", "text/html");
        }
    }
}

