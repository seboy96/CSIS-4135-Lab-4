using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using WaffleGenerator;

namespace WebApplication3.Controllers
{
    public class Lab4Controller : Controller
    {
        private List<HtmlString> waffles = new List<HtmlString>();
        public IActionResult Index()
        {
            DateTime date = DateTime.Now;
            return View(date);
        }

        public IActionResult Waffler(int id)
        {
            for(int i = 0; i < id; i++)
            {
                var waffle = WaffleEngine.Html(2, true, false);
                waffles.Add(new HtmlString(waffle));
            }
            return View(waffles);
        }
    }
}