using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Vesperr.DAL;
using Vesperr.Models;

namespace Vesperr.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext context;

       
        public HomeController(AppDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {

            List<Card> cards = context.Cards.ToList();
            return View(cards);
        }

        public IActionResult Detail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Card card = context.Cards.FirstOrDefault(c => c.Id == id);
            return View(card);
        }

       


    }
       
    
}
