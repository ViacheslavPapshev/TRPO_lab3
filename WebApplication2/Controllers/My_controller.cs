using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class My_controller : Controller
    {

        
        public ActionResult My_view(int id)
        {
            var vm = new Presentation_Model();
            return View(vm);
        }

 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult My_view(int id, IFormCollection collection)
        {
            //try
            //{
            //    return RedirectToAction(nameof(Index));
            //}
            //catch
            //{
            //    return View();
            //}
            var vm = new Presentation_Model();
            return View(vm);
        }


        
    }
}
