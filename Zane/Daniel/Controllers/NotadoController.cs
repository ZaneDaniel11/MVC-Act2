using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Daniel.Controllers
{
  
    public class NotadoController : Controller
    {
        private readonly ILogger<NotadoController> _logger;

        public NotadoController(ILogger<NotadoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Action1(bool isLoggedIn)
        {
            if(isLoggedIn)
                return View("Index");
             else
                 return View("Action1");
        }
    }
}