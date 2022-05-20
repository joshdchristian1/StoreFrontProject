using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StoreFront.DATA.EF.Models;

namespace StoreFront.UI.MVC.Controllers
{
    public class OrdersController : Controller
    {
        private readonly StoreFrontContext _context;

        public OrdersController(StoreFrontContext context)
        {
            _context = context;
        }

        // GET: Orders
        public async Task<IActionResult> Index()
        {
            var storeFrontContext = _context.Orders.Include(o => o.Customer).Include(o => o.Employee).Include(o => o.Product).Include(o => o.Supplier).Include(o => o.User);
            return View(await storeFrontContext.ToListAsync());
        }

        // GET: Orders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Orders == null)
            {
                return NotFound();
            }

            var order = await _context.Orders
                .Include(o => o.Customer)
                .Include(o => o.Employee)
                .Include(o => o.Product)
                .Include(o => o.Supplier)
                .Include(o => o.User)
                .FirstOrDefaultAsync(m => m.OrderId == id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // GET: Orders/Create
        public IActionResult Create()
        {
            ViewData["CustomerId"] = new SelectList(_context.Customers, "CustomerId", "CustomerAddress");
            ViewData["EmployeeId"] = new SelectList(_context.Employees, "EmployeeId", "FirstName");
            ViewData["ProductId"] = new SelectList(_context.Products, "ProductId", "ProductDescription");
            ViewData["SupplierId"] = new SelectList(_context.Suppliers, "SupplierId", "Address");
            ViewData["UserId"] = new SelectList(_context.UserDetails, "UserId", "FirstName");
            return View();
        }

        // POST: Orders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrderId,CustomerId,ShipAddress,ShipCity,ShipState,ShipZip,ShipCountry,Freight,EmployeeId,ProductId,SupplierId,UserId")] Order order)
        {
            if (ModelState.IsValid)
            {
                _context.Add(order);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CustomerId"] = new SelectList(_context.Customers, "CustomerId", "CustomerAddress", order.CustomerId);
            ViewData["EmployeeId"] = new SelectList(_context.Employees, "EmployeeId", "FirstName", order.EmployeeId);
            ViewData["ProductId"] = new SelectList(_context.Products, "ProductId", "ProductDescription", order.ProductId);
            ViewData["SupplierId"] = new SelectList(_context.Suppliers, "SupplierId", "Address", order.SupplierId);
            ViewData["UserId"] = new SelectList(_context.UserDetails, "UserId", "FirstName", order.UserId);
            return View(order);
        }

        // GET: Orders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Orders == null)
            {
                return NotFound();
            }

            var order = await _context.Orders.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }
            ViewData["CustomerId"] = new SelectList(_context.Customers, "CustomerId", "CustomerAddress", order.CustomerId);
            ViewData["EmployeeId"] = new SelectList(_context.Employees, "EmployeeId", "FirstName", order.EmployeeId);
            ViewData["ProductId"] = new SelectList(_context.Products, "ProductId", "ProductDescription", order.ProductId);
            ViewData["SupplierId"] = new SelectList(_context.Suppliers, "SupplierId", "Address", order.SupplierId);
            ViewData["UserId"] = new SelectList(_context.UserDetails, "UserId", "FirstName", order.UserId);
            return View(order);
        }

        // POST: Orders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrderId,CustomerId,ShipAddress,ShipCity,ShipState,ShipZip,ShipCountry,Freight,EmployeeId,ProductId,SupplierId,UserId")] Order order)
        {
            if (id != order.OrderId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(order);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderExists(order.OrderId))
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
            ViewData["CustomerId"] = new SelectList(_context.Customers, "CustomerId", "CustomerAddress", order.CustomerId);
            ViewData["EmployeeId"] = new SelectList(_context.Employees, "EmployeeId", "FirstName", order.EmployeeId);
            ViewData["ProductId"] = new SelectList(_context.Products, "ProductId", "ProductDescription", order.ProductId);
            ViewData["SupplierId"] = new SelectList(_context.Suppliers, "SupplierId", "Address", order.SupplierId);
            ViewData["UserId"] = new SelectList(_context.UserDetails, "UserId", "FirstName", order.UserId);
            return View(order);
        }

        // GET: Orders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Orders == null)
            {
                return NotFound();
            }

            var order = await _context.Orders
                .Include(o => o.Customer)
                .Include(o => o.Employee)
                .Include(o => o.Product)
                .Include(o => o.Supplier)
                .Include(o => o.User)
                .FirstOrDefaultAsync(m => m.OrderId == id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // POST: Orders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Orders == null)
            {
                return Problem("Entity set 'StoreFrontContext.Orders'  is null.");
            }
            var order = await _context.Orders.FindAsync(id);
            if (order != null)
            {
                _context.Orders.Remove(order);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrderExists(int id)
        {
          return (_context.Orders?.Any(e => e.OrderId == id)).GetValueOrDefault();
        }
    }
}
