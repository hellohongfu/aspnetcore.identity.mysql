using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebMvc.Models;
using Microsoft.Extensions.Configuration;


namespace WebMvc.Controllers
{
    public class HomeController : Controller
    {
        public class ArrayExample
        {
            public string[] Entries { get; set; }
        }
        private IConfiguration _config;

        public HomeController(IConfiguration config)
        {
            _config = config;
        }


        public IActionResult Index()
        {
            var arrayExample = new ArrayExample();
            _config.GetSection("array").Bind(arrayExample);

            ArrayExample ArrayExample = _config.GetSection("array").Get<ArrayExample>();
            var entries = _config.GetValue<Array>("entries");



            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
