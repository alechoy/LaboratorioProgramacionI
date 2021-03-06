using Microsoft.AspNetCore.Mvc;
using demomvc.Models;
using demomvc.Data;

namespace demomvc.Controllers
{
    public class MatriculaController:Controller
    {
        private readonly ApplicationDbContext _context;

        public MatriculaController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create(Matricula objMatricula)
        {
            _context.Add(objMatricula);
            _context.SaveChanges();
            ViewData["Message"] = "El alumno ya está registrado";
            return View("Index");
        }

    }
}