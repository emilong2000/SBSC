using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SBSCBank.IService;
using SBSCBank.Service;

namespace SBSCBank.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISBSCService _service;
        public HomeController(SBSCService service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            var result = _service.GetUsers();
            return View(result);
        }
    }
}
