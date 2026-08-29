using Microsoft.AspNetCore.Mvc;
using MVC_Bartender_Application.Data;
using MVC_Bartender_Application.Models;

using Microsoft.EntityFrameworkCore;

namespace MVC_Bartender_Application.Controllers;

public class OrderController : Controller
{
    private readonly ApplicationDbContext _context;

    public OrderController(ApplicationDbContext context)
    {
        _context = context;
    }

    // Display menu
    [HttpGet]
    public IActionResult Menu()
    {
        var menu = _context.Cocktails.ToList();
        return View(menu);
    }

    // Receive order
    [HttpPost]
    public IActionResult PlaceOrder(int CocktailId)
    {
        var cocktail = _context.Cocktails.Find(CocktailId);

        if (cocktail == null)
        {
            return NotFound();
        }

        var order = new Order
        {
            CocktailId = cocktail.Id,
            CocktailName = cocktail.Name,
            OrderDate = DateTime.Now
        };

        _context.Orders.Add(order);
        _context.SaveChanges();

        return RedirectToAction("Queue");
    }

    // Display order queue
    [HttpGet]
    public IActionResult Queue()
    {
        var orders = _context.Orders.ToList();
        return View(orders);
    }
}