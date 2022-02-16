using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ZoVendas.Models;

namespace ZoVendas.Controllers
{
    public class ItensPedidoModelsController : Controller
    {
        private readonly ZoVendasContext _context;

        public ItensPedidoModelsController(ZoVendasContext context)
        {
            _context = context;
        }

        // GET: ItensPedidoModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.Carrinho.ToListAsync());
        }

        // GET: ItensPedidoModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itensPedidoModel = await _context.Carrinho
                .FirstOrDefaultAsync(m => m.ID == id);
            if (itensPedidoModel == null)
            {
                return NotFound();
            }

            return View(itensPedidoModel);
        }

        // GET: ItensPedidoModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ItensPedidoModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,IdProduto,QtdProduto")] ItensPedidoModel itensPedidoModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(itensPedidoModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(itensPedidoModel);
        }

        // GET: ItensPedidoModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itensPedidoModel = await _context.Carrinho.FindAsync(id);
            if (itensPedidoModel == null)
            {
                return NotFound();
            }
            return View(itensPedidoModel);
        }

        // POST: ItensPedidoModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,IdProduto,QtdProduto")] ItensPedidoModel itensPedidoModel)
        {
            if (id != itensPedidoModel.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(itensPedidoModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ItensPedidoModelExists(itensPedidoModel.ID))
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
            return View(itensPedidoModel);
        }

        // GET: ItensPedidoModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itensPedidoModel = await _context.Carrinho
                .FirstOrDefaultAsync(m => m.ID == id);
            if (itensPedidoModel == null)
            {
                return NotFound();
            }

            return View(itensPedidoModel);
        }

        // POST: ItensPedidoModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var itensPedidoModel = await _context.Carrinho.FindAsync(id);
            _context.Carrinho.Remove(itensPedidoModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ItensPedidoModelExists(int id)
        {
            return _context.Carrinho.Any(e => e.ID == id);
        }
    }
}
