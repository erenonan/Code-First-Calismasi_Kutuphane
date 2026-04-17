using Microsoft.AspNetCore.Mvc;
using Code_First_Calismasi.Models;

namespace Code_First_Calismasi.Controllers
{
    public class KitapController : Controller
    {
        private readonly KitapContext _context;

        public KitapController(KitapContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var kitaplar = _context.Kitaplar.ToList();
            return View(kitaplar);
        }

        [HttpGet]
        public IActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Ekle(Kitap kitap)
        {
            if (ModelState.IsValid)
            {

                _context.Kitaplar.Add(kitap);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(kitap);
        }
    }
}
