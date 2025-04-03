using Microsoft.AspNetCore.Mvc;

namespace HakkımdaProjesi.Models
{
    public class AboutModel : Controller
    {

        public string Name {  get; set; }
        public string Bio { get; set; }
        public string[] Hobbies { get; set; }  


        public IActionResult Index()
        {
            return View();
        }
    }
}
