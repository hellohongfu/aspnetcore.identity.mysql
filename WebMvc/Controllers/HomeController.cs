using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebMvc.Models;
using Microsoft.Extensions.Configuration;

using WebMvc.Data;
using WebMvc.Models.BusinessModel;

namespace WebMvc.Controllers
{
    public class HomeController : Controller
    {

        #region Test Code
        public class ArrayExample
        {
            public string[] Entries { get; set; }
        }

        public class JsonArrayExample
        {
            public string Key { get; set; }
            public string[] Subsection { get; set; }
        }


        public class JsonTest
        {
            public string key { get; set; }
            public string[] subsection { get; set; }
        }

        public class Starship
        {
            public string Name { get; set; }
            public string Registry { get; set; }
            public string Class { get; set; }
            public decimal Length { get; set; }
            public bool Commissioned { get; set; }
        }
        private IConfiguration _config;
        #endregion


        ApplicationBusinessContext _context;
        public HomeController(IConfiguration config, ApplicationBusinessContext context)
        {
            _config = config;
            _context = context;
        }


        public async   Task<IActionResult> Index()
        {
            var arrayExample = new ArrayExample();
            _config.GetSection("array").Bind(arrayExample);

            ArrayExample ArrayExample = _config.GetSection("array").Get<ArrayExample>();
            var entries = _config.GetValue<Array>("entries");


            var configSection = _config.GetSection("section1");


            var jsonTest = _config.GetSection("json_array").Get<JsonTest>();






            WebMvc.Models.BusinessModel.Task model = new Models.BusinessModel.Task();
            model.Subject = "abcke";
            model.Description = "第一个ovrn";

            _context.tasks.Add(model);

            await _context.SaveChangesAsync();


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
