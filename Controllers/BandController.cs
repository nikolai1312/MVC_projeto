using Microsoft.AspNetCore.Mvc;
using MVC_projeto.Interfaces;
using MVC_projeto.Models;

namespace MVC_projeto.Controllers
{
    public class BandController : Controller
    {
        private readonly IBandRepository _bandRepository;
        public BandController(IBandRepository bandRepository) {
            _bandRepository = bandRepository;
        }
        public IActionResult Index()
        {
            var bands = _bandRepository.GetAll();
            return View(bands);
        }

        public IActionResult CreateBand()
        {
            return View();
        }

        public IActionResult EditBand(int id)
        {
            BandModel model = _bandRepository.GetById(id);
            return View(model);
        }

        [HttpDelete]

        public IActionResult DeleteBand(int id) {
            BandModel name = _bandRepository.GetById(id);
            return View(name);
        }

        [HttpPost]
        public IActionResult CreateBand(BandModel model)
        {
            if (ModelState.IsValid)
            {
                _bandRepository.Add(model);
                return RedirectToAction("Index");
            }

            return View(model);
        }
        
        [HttpPost]
        public IActionResult EditBand(BandModel model)
        {
            if (ModelState.IsValid)
            {
                _bandRepository.Update(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _bandRepository.Delete(id);
            return RedirectToAction("Index");
        }


    }
}
