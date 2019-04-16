using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Assignment4Games.Models;
using Microsoft.AspNetCore.Authorization;


namespace Assignment4Games.Controllers
{
    public class GamesController : Controller
    {
        private readonly Assignment4GamesContext _context;

        public GamesController(Assignment4GamesContext context)
        {
            _context = context;
        }

        // GET: Games
        public async Task<IActionResult> Index()
        {
            var arr = _context.Games.OrderByDescending(jx => jx.Rating);
            var x = from item in arr orderby item select item;
            return View(arr);
        }

        // GET: Games/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var games = await _context.Games
                .FirstOrDefaultAsync(m => m.GameId == id);
            if (games == null)
            {
                return NotFound();
            }

            return View(games);
        }

        [Authorize(Roles = "Admin")]

        // GET: Games/Create
        public IActionResult Create()
        {
            return View();
        }

        //public IActionResult Funds()
        //{
        //    return View();
        //}

        [HttpGet]
        public ViewResult Funds()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Funds(Payment funds)
        {
            //Repository.AddResponse(guestResponse);
            // TODO: store response from guest
            return View("Load", funds);
        }

        [HttpGet]
        public ViewResult PayForm()
        {
            return View();
        }
        
        public ViewResult AddPayment(Payment PayForm)
        {
            //Repository.AddResponse(guestResponse);
            // TODO: store response from guest
            return View("Thanks", PayForm);

        }

        [HttpGet]
        public ViewResult RegInsure()
        {
            return View();
        }
        [HttpPost]
        public ViewResult RegInsure(Payment RegInsure)
        {
            //Repository.AddResponse(guestResponse);
            // TODO: store response from guest
            return View("ThanksReg", RegInsure);

        }

        [HttpGet]
        public ViewResult Claim()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Claim(Payment Claim)
        {
            //Repository.AddResponse(guestResponse);
            // TODO: store response from guest
            return View("ThanksClaim", Claim);

        }

        public ViewResult ExtraCredits()
        {
            return View();
        }

        public ViewResult ThanksCr()
        {
            return View();
        }

        public ViewResult Insurance()
        {
            return View();
        }

        public ViewResult QR()
        {
            return View();
        }
        // POST: Games/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("GameId,GameName,Genre,Developer,Platform,Languages,Rating,Description")] Game games)
        {
            if (ModelState.IsValid)
            {
                _context.Add(games);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(games);
        }

        [Authorize(Roles = "Admin")]
        // GET: Games/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var games = await _context.Games.FindAsync(id);
            if (games == null)
            {
                return NotFound();
            }
            return View(games);
        }

        [Authorize(Roles = "Admin")]
        // POST: Games/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("GameId,GameName,Genre,Developer,Platform,Languages,Rating,Description")] Game games)
        {
            if (id != games.GameId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(games);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GamesExists(games.GameId))
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
            return View(games);
        }

        [Authorize(Roles = "Admin")]
        // GET: Games/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var games = await _context.Games
                .FirstOrDefaultAsync(m => m.GameId == id);
            if (games == null)
            {
                return NotFound();
            }

            return View(games);
        }

        // POST: Games/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var games = await _context.Games.FindAsync(id);
            _context.Games.Remove(games);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GamesExists(string id)
        {
            return _context.Games.Any(e => e.GameId == id);
        }

        //[Authorize(Roles = "Admin,User")]


        public async Task<IActionResult> Data()
        {
            /// for grouping platforms

            var popularGames = _context.Games.OrderBy(tGame => tGame.Rating).GroupBy(tGame => tGame.Platform);

            List<GroupedGame> groupedGames = new List<GroupedGame>();

            foreach (var item in popularGames)
            {

                System.Diagnostics.Debug.WriteLine("Platform");
                System.Diagnostics.Debug.WriteLine(item.Key);
                System.Diagnostics.Debug.WriteLine("");

                List<Game> games = new List<Game>();

                foreach (var i in item)
                {
                    System.Diagnostics.Debug.WriteLine(i.GameName);
                    games.Add(i);
                }


                GroupedGame groupedGame = new GroupedGame
                {
                    GroupName = item.Key,
                    Games = games
                };

                groupedGames.Add(groupedGame);

                System.Diagnostics.Debug.WriteLine("");
            }
            //var arr = _context.Games.OrderByDescending(jx => jx.Rating);
            //var x = from item in arr orderby item select item;
            return View(groupedGames);
        }
    }
}
