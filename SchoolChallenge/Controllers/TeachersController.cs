using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SchoolChallenge.Controllers
{
    [Route("[controller]/[action]")]
    public class TeachersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}