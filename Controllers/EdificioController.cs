using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TrabajoEnEquipo.Models;

namespace TrabajoEnEquipo.Controllers
{
    public class EdificioController : Controller
    {
        private readonly BDContext _context;

        public EdificioController(BDContext context)
        {
            _context = context;
        }

        // GET: Edificio
        public async Task<IActionResult> Index()
        {
            return View(await _context.Edificio.ToListAsync());
        }

        // GET: Edificio/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var edificio = await _context.Edificio
                .FirstOrDefaultAsync(m => m.idedificio == id);
            if (edificio == null)
            {
                return NotFound();
            }

            return View(edificio);
        }

        // GET: Edificio/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Edificio/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idedificio,nombre_edificio,direccion_edificio,cantidad_oficinas")] Edificio edificio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(edificio);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(edificio);
        }

        // GET: Edificio/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var edificio = await _context.Edificio.FindAsync(id);
            if (edificio == null)
            {
                return NotFound();
            }
            return View(edificio);
        }

        // POST: Edificio/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idedificio,nombre_edificio,direccion_edificio,cantidad_oficinas")] Edificio edificio)
        {
            if (id != edificio.idedificio)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(edificio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EdificioExists(edificio.idedificio))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(edificio);
        }

        // GET: Edificio/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var edificio = await _context.Edificio
                .FirstOrDefaultAsync(m => m.idedificio == id);
            if (edificio == null)
            {
                return NotFound();
            }

            return View(edificio);
        }

        // POST: Edificio/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var edificio = await _context.Edificio.FindAsync(id);
            _context.Edificio.Remove(edificio);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EdificioExists(int id)
        {
            return _context.Edificio.Any(e => e.idedificio == id);
        }
    }
}
