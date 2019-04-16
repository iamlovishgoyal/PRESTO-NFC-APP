using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Assignment4Games.Models;
using Assignment4Games.Models.ViewModels;

namespace Assignment4Games.Controllers
{

    public class CartController : Controller
    {
        private IGamesRepository repository;

        private Cart cart;

        //public CartController(IGamesRepository repo, Cart cartService)
        //{
        //    repository = repo;
        //    cart = cartService;
        //}

        public ViewResult Index(string returnUrl)
        {
            return View(new CartIndexViewModel
            {
                Cart = cart,
                ReturnUrl = returnUrl
            });
        }

        public RedirectToActionResult AddToCart(string GameId, string returnUrl)
        {
            Game product = repository.Games
                .FirstOrDefault(p => p.GameId == GameId);
            if (product != null)
            {
                cart.AddItem(product, 1);
            }
            return RedirectToAction("Index", new { returnUrl });
        }

        public RedirectToActionResult RemoveFromCart(string GameId,
                string returnUrl)
        {
            Game product = repository.Games
                .FirstOrDefault(p => p.GameId == GameId);

            if (product != null)
            {
                cart.RemoveLine(product);
            }
            return RedirectToAction("Index", new { returnUrl });
        }
    }
}