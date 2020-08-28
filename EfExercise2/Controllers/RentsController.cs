using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EfExercise2.Models;
using Microsoft.AspNetCore.Mvc.DataAnnotations;

namespace EfExercise2.Controllers
{
    public class RentsController : Controller
    {
        private readonly Context _context;

        public RentsController(Context context)
        {
            _context = context;
        }

        // GET: Rents
        public async Task<IActionResult> Index()
        {
            var rent = await _context.Rent
                .Include(x => x.Cliente)
                .Include(x => x.Livro)
                .ToListAsync();

            return View(rent);
        }

        // GET: Rents/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rent = await _context.Rent
                .Include(x => x.Cliente).Include(x => x.Livro).FirstOrDefaultAsync(m => m.Id == id);

            if (rent == null)
            {
                return NotFound();
            }

            return View(rent);
        }     

        // GET: Rents/Create
        public IActionResult Create()
        {
            ViewBag.Livros = new SelectList(_context.Book.ToList(), "Id", "Nome");
            ViewBag.Clientes = new SelectList(_context.Customer.ToList(), "Id", "Nome");

            return View();
        }

        // POST: Rents/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Livro,Cliente,Emprestado,PrevisaoDevolucao,Devolucao")] Rent rent)
        {
            bool BookIsBusy = _context.Rent.Any(x => x.Livro.Id == rent.Livro.Id);

            if (BookIsBusy)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                if (ModelState.IsValid)
                {
                    rent.Livro = _context.Book.First(x => x.Id.Equals(rent.Livro.Id));
                    rent.Cliente = _context.Customer.First(x => x.Id.Equals(rent.Cliente.Id));
                    _context.Add(rent);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }

                return View(rent);
            }
        }

        // GET: Rents/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {

            ViewBag.Livros = new SelectList(_context.Book.ToList(), "Id", "Nome");
            ViewBag.Clientes = new SelectList(_context.Customer.ToList(), "Id", "Nome");

            if (id == null)
            {
                return NotFound();
            }

            var rent = await _context.Rent.FindAsync(id);
            if (rent == null)
            {
                return NotFound();
            }
            return View(rent);
        }

        // POST: Rents/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Livro, Cliente, Emprestado,PrevisaoDevolucao,Devolucao")] Rent rent)
        {
            if (id != rent.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    rent.Livro = _context.Book.First(x => x.Id.Equals(rent.Livro.Id));
                    rent.Cliente = _context.Customer.First(x => x.Id.Equals(rent.Cliente.Id));

                    _context.Update(rent);
                    await _context.SaveChangesAsync();
                    if (rent.Devolucao > rent.Emprestado)
                    {
                        rent.Livro = _context.Book.First(x => x.Id.Equals(rent.Livro.Id));
                        rent.Cliente = _context.Customer.First(x => x.Id.Equals(rent.Cliente.Id));
                        return RedirectToAction("RentEnded", rent);
                    }
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RentExists(rent.Id))
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
            return View(rent);
        }

        // GET: Rents/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rent = await _context.Rent
                .FirstOrDefaultAsync(m => m.Id == id);
            if (rent == null)
            {
                return NotFound();
            }

            return View(rent);
        }

        // POST: Rents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rent = await _context.Rent.FindAsync(id);
            _context.Rent.Remove(rent);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RentExists(int id)
        {
            return _context.Rent.Any(e => e.Id == id);
        }

        public async Task<IActionResult> RentEnded(Rent rent)
        {
            rent = _context.Rent
                .Include(x => x.Cliente).Include(x => x.Livro).FirstOrDefault(m => m.Id == rent.Id);

            return View(rent);
        }
    }
}
