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

        //[HttpGet("{id}")]
        public IActionResult Edit(int id)
        {
            Item existingItem = new Item();

            if (_context.Items.Where(m => m.Id == id).Any())
            {
                existingItem = _context.Items.Where(m => m.Id == id).FirstOrDefault();
            }

            return View(existingItem);
        }

        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Item item)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(item).State = EntityState.Modified;
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(item);
        }


        [HttpGet]
        public IActionResult Details(int id)
        {
            Item existingItem = new Item();

            if (_context.Items.Where(m => m.Id == id).Any())
            {
                existingItem = _context.Items.Where(m => m.Id == id).FirstOrDefault();
            }

            return View(existingItem);
        }
    }
}