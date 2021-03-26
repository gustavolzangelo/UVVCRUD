using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UVVCRUD.Data;
using UVVCRUD.Models;

namespace UVVCRUD.Controllers
{
    public class ClientController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ClientController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Client> objList = _db.Clients;
            return View(objList);
        }
        public IActionResult Create()
        {
            return View();
        }        

        [HttpPost]
        public IActionResult Create(Client obj)
        {
            if (ModelState.IsValid)
            {
                _db.Clients.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }        
        public IActionResult Delete(int? id)
        {            
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Clients.Find(id);
            if(obj == null)
            {
                return NotFound();
            }
            return View(obj);
            
        }

        [HttpPost]
        public IActionResult DeletePost(int? id)
        {
            var obj = _db.Clients.Find(id);
            if(obj == null)
            {
                return NotFound();
            }
            else
            {
                _db.Clients.Remove(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }            
        }
        public IActionResult Update(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Clients.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);

        }

        [HttpPost]
        public IActionResult Update(Client obj)
        {
            if (ModelState.IsValid)
            {
                _db.Clients.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
    }
}
