using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AnnexioSPA.Models;
using System.Net;
using Newtonsoft.Json;

namespace AnnexioSPA.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var webClient = new WebClient();
            var json = webClient.DownloadString(@"https://restcountries.eu/rest/v2/all");
            var _countries = JsonConvert.DeserializeObject<List<CountryData>>(json);
            var result = new Countries { countries = _countries };
            return View(result);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
