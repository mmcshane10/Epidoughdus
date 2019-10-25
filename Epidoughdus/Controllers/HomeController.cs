using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Epidoughdus.Models;

namespace Epidoughdus.Controllers
{
    public class HomeController : Controller
    {

        private readonly EpidoughdusContext _db;

        public HomeController(EpidoughdusContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Search(string query)
        {
            query = query.ToLower();
            System.Console.WriteLine(query);
            List<Treat> model = _db.Treats.Include(treat => treat.Flavors).ToList();
            List<Treat> newModel = new List<Treat> { };
            for (int i = 0; i < model.Count; i++)
            {
                model[i].Name = model[i].Name.ToLower();
                newModel.Add(model[i]);
            }
            return View("Search", newModel.Where(r => r.Name.Contains(query)).ToList());
        }
    }
}
