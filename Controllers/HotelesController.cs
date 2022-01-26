using Microsoft.AspNetCore.Mvc;
using Docs.Models.Data;
using System.Linq;

namespace Docs.Controllers
{
    public class HotelesController : Controller
    {
        private readonly DataContext _context;
        public HotelesController(DataContext context){
            _context = context;
        }
        public IActionResult index(){
            var hotel = _context.hoteles.ToList();
            return View();
        }
    }
}