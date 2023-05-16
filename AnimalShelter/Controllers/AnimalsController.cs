using Microsoft.AspNetCore.Mvc;
using AnimalShelter.Models;
using System.Collections.Generic;
using System.Linq;

namespace AnimalShelter.Controllers
{
    public class AnimalsController : Controller
    {
        private readonly AnimalShelterContext _db;

        public AnimalsController(AnimalShelterContext db)
        { 
            _db = db;
        }

        public ActionResult Index()
        {
            List<Animal> model = _db.Animals.ToList();
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Animal animal)
        {
            _db.Animals.Add(animal);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            Animal selectedAnimal = _db.Animals.FirstOrDefault(animal => animal.AnimalId == id);
            return View(selectedAnimal);
        }

        public ActionResult Search()
        {
            return View();
        }

        public ActionResult Results(List<Animal> searchList)
        {
            return View(searchList);
        }

        [HttpPost] 
        public ActionResult Search(int type)
        {   
            List<Animal> searchList = _db.Animals.Where(animal => (int) animal.Type == type).ToList();
            return View("Results", searchList); 
        }
    }
}