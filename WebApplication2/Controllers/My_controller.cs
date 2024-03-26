using ClassLibrary_lab_3;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class My_controller : Controller
    {

        
        public ActionResult My_view(double height, double square_1, double square_2)
        {
            var result = Class1.VolumeCon(height, square_1, square_2);
            var vm = new Presentation_Model(height, square_1, square_2, result);
            return View(vm);
        }

 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult My_view(IFormCollection collection, double height, double square_1, double square_2)
        {
            var result = Class1.VolumeCon(height, square_1, square_2);
            var vm = new Presentation_Model(height, square_1, square_2, result);
            return View(vm);
        }


        
    }
}
