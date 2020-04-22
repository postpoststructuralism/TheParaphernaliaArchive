using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParaphernaliaArchive.Models;

namespace ParaphernaliaArchive.Controllers
{
    public class ItemController : Controller
    {
        private ParaphernaliaContext _context;

        public ItemController(ParaphernaliaContext context)
        {
            _context = context;
        }
        
        public IActionResult Index()
        {
            var items = _context.Items.ToList();
            return View(items);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Item item)
        {
            _context.Items.Add(item);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}