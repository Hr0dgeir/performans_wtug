using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoreApp.Models;
using Entities.Models;
using Repositoreis;
using Repositories.Contracts

namespace Name.Controllers
{
    public class ProductController : Controller
    {
        private readonly IRepositoryManager _manager

        public ProductController(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public IActionResult Index(){
            var model = _manager.Product.GetAllProducts(false).ToList();
            return View(model);
        }

        public IActionResult Get(int id){
            //Product prd = _context.Products.First(p => p.ProductId.Equals(id));
            throw new NotImplementedExpection();
        }
    }
}