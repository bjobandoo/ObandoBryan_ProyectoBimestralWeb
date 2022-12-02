using Microsoft.AspNetCore.Mvc;
using WebApp_ObandoBryanPrueba.Code;
using WebApp_ObandoBryanPrueba.Models;

namespace WebApp_ObandoBryanPrueba.Controllers
{
    public class PruebaController : Controller
    {
        string apiUrl = "https://localhost:7289/api";
        // GET: Prueba
        public ActionResult Image()
        {
            return View();
        }

        // POST: Prueba
        [HttpPost]
        public ActionResult Image(Image image, string imgRoute)
        {
            var resp = ApiConsumer.PostImage(apiUrl, imgRoute);
            image.route = imgRoute;

            ViewBag.text = resp;
            ViewBag.imgRoute = imgRoute;
            return View();
        }
    }
}
