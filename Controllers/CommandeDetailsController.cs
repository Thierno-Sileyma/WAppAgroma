using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WAppAgroma.Data;
using WAppAgroma.Models;

namespace WAppAgroma.Controllers
{
    public class CommandeDetailsController : Controller
    {
        private readonly AppDbContext _context;

        public CommandeDetailsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: CommandeDetails
        public async Task<IActionResult> Index()
        {
            return View(await _context.CommandeDetails.ToListAsync());
        }

        // GET: CommandeDetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var commandeDetail = await _context.CommandeDetails
                .FirstOrDefaultAsync(m => m.Id == id);
            if (commandeDetail == null)
            {
                return NotFound();
            }

            return View(commandeDetail);
        }

        // GET: CommandeDetails/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CommandeDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CommandeId,ProduitId,Quantite,PrixUnitaire")] CommandeDetail commandeDetail)
        {
            if (ModelState.IsValid)
            {
                _context.Add(commandeDetail);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(commandeDetail);
        }

        // GET: CommandeDetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var commandeDetail = await _context.CommandeDetails.FindAsync(id);
            if (commandeDetail == null)
            {
                return NotFound();
            }
            return View(commandeDetail);
        }

        // POST: CommandeDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CommandeId,ProduitId,Quantite,PrixUnitaire")] CommandeDetail commandeDetail)
        {
            if (id != commandeDetail.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(commandeDetail);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CommandeDetailExists(commandeDetail.Id))
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
            return View(commandeDetail);
        }

        // GET: CommandeDetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var commandeDetail = await _context.CommandeDetails
                .FirstOrDefaultAsync(m => m.Id == id);
            if (commandeDetail == null)
            {
                return NotFound();
            }

            return View(commandeDetail);
        }

        // POST: CommandeDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var commandeDetail = await _context.CommandeDetails.FindAsync(id);
            if (commandeDetail != null)
            {
                _context.CommandeDetails.Remove(commandeDetail);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CommandeDetailExists(int id)
        {
            return _context.CommandeDetails.Any(e => e.Id == id);
        }
    }
}
