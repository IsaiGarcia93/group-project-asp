using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GroupProject.Data.UserDBContex;
using GroupProject.Models;

namespace GroupProject.Controllers
{
    public class ItemsController : Controller
    {
        private readonly cs _context;

        public ItemsController(cs context)
        {
            _context = context;
        }

        // GET: ItemsModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.ItemsModel.ToListAsync());
        }

        // GET: ItemsModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itemsModel = await _context.ItemsModel
                .FirstOrDefaultAsync(m => m.ItemID == id);
            if (itemsModel == null)
            {
                return NotFound();
            }

            return View(itemsModel);
        }

        // GET: ItemsModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ItemsModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ItemID,ItemName,ItemDescription,ItemPrice,DateCreated,ImageName,ImagePath")] ItemsModel itemsModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(itemsModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(itemsModel);
        }

        // GET: ItemsModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itemsModel = await _context.ItemsModel.FindAsync(id);
            if (itemsModel == null)
            {
                return NotFound();
            }
            return View(itemsModel);
        }

        // POST: ItemsModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ItemID,ItemName,ItemDescription,ItemPrice,DateCreated,ImageName,ImagePath")] ItemsModel itemsModel)
        {
            if (id != itemsModel.ItemID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(itemsModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ItemsModelExists(itemsModel.ItemID))
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
            return View(itemsModel);
        }

        // GET: ItemsModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itemsModel = await _context.ItemsModel
                .FirstOrDefaultAsync(m => m.ItemID == id);
            if (itemsModel == null)
            {
                return NotFound();
            }

            return View(itemsModel);
        }

        // POST: ItemsModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var itemsModel = await _context.ItemsModel.FindAsync(id);
            _context.ItemsModel.Remove(itemsModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ItemsModelExists(int id)
        {
            return _context.ItemsModel.Any(e => e.ItemID == id);
        }
    }
}
