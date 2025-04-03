using HakkımdaProjesi.Models;
using Microsoft.AspNetCore.Mvc;

namespace HakkımdaProjesi.Controllers
{
    public class HomeController : Controller
    {
        static AboutModel about = new AboutModel()
        {
            Name = "Irmak Coşar",
            Bio = "İstanbul üniversitesi Bilgisayar programcılığılı 1. sınıf öğrencisiyim.",
            Hobbies = new string[] { "Müzik Dinlemek", "Uyumak", "Yeni Şeyler Öğrenmek" }
        };
        public IActionResult Index()
        {
            /*
             homecontroler içinde tanımladığımızı tetiklemezsek çalışmıyor?
             */
            return View(about);
        }
       
   }
}
