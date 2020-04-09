using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CoreAppArchiteture.WebUI.Models;
using CoreAppArchiteture.Infrastructure;
using CoreAppArchiteture.Core.Interfaces;
using CoreAppArchiteture.Core.Entities;
using CoreAppArchiteture.WebUI.Test;

namespace CoreAppArchiteture.WebUI.Controllers
{
    public class HomeController : Controller
    {
        protected CoreAppContext _dbContext;
        //private readonly ILogger<HomeController> _logger;
        private readonly IRepository _repository;

        //public HomeController(ILogger<HomeController> logger, CoreAppContext dbContext )
        //{
        //    _logger = logger;
        //    _dbContext = dbContext;
        //}

        public HomeController(IRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            //var retorno = _dbContext.ShoppingLists.Where(x => x.Amount == 1).FirstOrDefault();
            var retorno = _repository.List<ShoppingList>().Select(ShoppingListDTO.FromShoppingList).ToList();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
