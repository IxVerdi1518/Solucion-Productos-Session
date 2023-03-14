using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyProductosEF.Models;
using ProyProductosEF.Session;

namespace ProyProductosEF.Controllers
{
    public class ProductController : Controller
    {
        // GET: ProductController
        public IActionResult Index()
        {
           return View(listaProductos());
        }
        public List<ProductEF> listaProductos()
        {
            List<ProductEF> list = SessionHelper.GetObjectFromJson<List<ProductEF>>(HttpContext.Session, "productos");
            if (list == null)
            {
                list = new List<ProductEF>();
            }
            return list;
        }
        // GET: ProductController/Create
        [HttpPost]
        public IActionResult Guardar(ProductEF productef)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    List<ProductEF> list = SessionHelper.GetObjectFromJson<List<ProductEF>>(HttpContext.Session, "productos");
                    if (list == null)
                        list = new List<ProductEF>();
                    list.Add(productef);
                    SessionHelper.SetObjectAsJson(HttpContext.Session, "productos", list);
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    TempData["errorCedula"] = ex.Message;
                    return View("Create", productef);
                }
                

            }
            else
            {
                
                return View("Create", productef);
            }
            
        }

        // POST: ProductController/Create
        [HttpGet]
        public ActionResult Create()
        {
                return View();
            
        }

    }
}
