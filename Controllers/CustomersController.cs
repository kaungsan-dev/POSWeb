using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using POSWeb.Data;
using POSWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POSWeb.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CustomersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Get Method Customer Index
        public async Task<IActionResult> Index()
        {
            var CustomerList = await _context.Customers.ToListAsync();
            return View(CustomerList);
        }

        // Get Method Customer Create
        public IActionResult Create()
        {
            return View();
        }

        // Post Method Customer Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CustomerID, CustomerName, PhNo, Email")] Customer customer )
        {
            if (ModelState.IsValid)
            {
                _context.Add(customer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        // Get Method Customer Edit
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) {
                return NotFound();
            }
            var customer = await _context.Customers.FindAsync(id);
            return View(customer);
        }

        // Post Method Customer Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,[Bind("CustomerID, CustomerName, PhNo, Email")] Customer customer)
        {
            if (id != customer.CustomerID)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customer);
                    await _context.SaveChangesAsync();
                }
                catch (Exception)
                {
                    throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        // Get Method Customer Delete
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var customer = await _context.Customers.FirstOrDefaultAsync(x => x.CustomerID == id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }

        // Post Method Customer Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var customer = await _context.Customers.FindAsync(id);
            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
