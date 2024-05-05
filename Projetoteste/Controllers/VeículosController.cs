using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Framework;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using Projetoteste.Models;

namespace Projetoteste.Controllers
{
    public class VeículosController : Controller
    {
        private readonly AppDBContext _context;
        public VeículosController(AppDBContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var dados = await _context.Veículos.ToListAsync();
            return View(dados);

        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Veículo veículo)
        {
            if (ModelState.IsValid)
            {
                _context.Veículos.Add(veículo);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(veículo);
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();
            var dados = await _context.Veículos.FindAsync(id);
            if (dados == null)
                return NotFound();
            return View(dados);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, Veículo veículo)
        {
            if (id != veículo.Id)
                return NotFound();
            if (ModelState.IsValid)
            {
                _context.Veículos.Update(veículo);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View();
        }
    }

}
