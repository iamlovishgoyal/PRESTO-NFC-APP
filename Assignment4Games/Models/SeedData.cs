using Assignment4Games.Models;
using System;
using Microsoft.AspNetCore.Builder;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;




namespace Assignment4Games.Models
{
    public class SeedData
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            Assignment4GamesContext context = applicationBuilder.ApplicationServices
                 .GetRequiredService<Assignment4GamesContext>();
            context.Database.Migrate();
            if (!context.Games.Any())
            {
                context.Games.AddRange(
                    new Game
                    {
                        GameName = "GTA 5",
                        Genre = "Action",
                        Developer = "Rockstar",
                        Platform = "PC ANROID PS4 Xbox iOs",
                        Languages = "ENGLISH CHINEASE GERMAN",
                        Rating = 5,
                        Description = "Grand Theft Auto V for PC features a range of major visual and technical upgrades to make Los Santos and Blaine County more immersive than ever. In addition to vastly increased draw distances, Grand Theft Auto V for PC runs at 60FPS in 1080p, with the ability to display visuals in 4K resolution."
                    },
                    new Game
                    {
                        GameName = "FIFA 19",
                        Genre = "Sports",
                        Developer = "EA",
                        Platform = "PC ANROID PS4",
                        Languages = "ENGLISH CHINEASE GERMAN",
                        Rating = 4,
                        Description = "From tactical approach to every technical touch, Control The Pitch in every moment with new gameplay features in EA SPORTS FIFA 19. The brand-new Active Touch System allows for closer control, Dynamic Tactics enables deeper and more accessible squad setups, 50/50 Battles enables greater physicality and more user skill when challenging for loose balls, and Timed Finishing elevates user control in striking."
                    },
                    new Game
                    {
                        GameName = "NHL 19",
                        Genre = "Sports",
                        Developer = "EA",
                        Platform = "PC ANROID PS4",
                        Languages = "ENGLISH CHINEASE GERMAN",
                        Rating = 5,
                        Description = "Play on outdoor rinks and journey from the ponds to the pros in new game modes. Compete with and against 200 of the greatest hockey legends to ever hit the ice, highlighted by Wayne Gretzky. Powered by cutting-edge new gameplay technology, experience explosive-edge skating that delivers more acceleration, speed and responsiveness."

                    },
                    new Game
                    {
                        GameName = "GTA Vicecity",
                        Genre = "ACTION",
                        Developer = "Rockstar",
                        Platform = "PC ANROID PS4",
                        Languages = "ENGLISH CHINEASE GERMAN",
                        Rating = 5,
                        Description = "A boat for one person"
                    },
                    new Game
                    {
                        GameName = "Battlefield 5",
                        Genre = "Shooting",
                        Developer = "EA",
                        Platform = "PC ANROID PS4",
                        Languages = "ENGLISH CHINEASE GERMAN",
                        Rating = 3,
                        Description = "Eight massive multiplayer modes. Battle royale. Your squad is more important than ever."
                    },
                    new Game
                    {
                        GameName = "HOCKEY",
                        Genre = "Sports",
                        Developer = "EA",
                        Platform = "PC ANROID PS4",
                        Languages = "ENGLISH CHINEASE GERMAN",
                        Rating = 2,
                        Description = "A boat for one person"
                    },
                    new Game
                    {
                        GameName = "Battlefront 2",
                        Genre = "Adventure",
                        Developer = "EA",
                        Platform = "Xbox PS4",
                        Languages = "ENGLISH CHINEASE GERMAN",
                        Rating = 3,
                        Description = "Rich single-player stories, deep multiplayer combat, and multi-stage space battles are all waiting for you in Star Wars Battlefront II."
                    },
                    new Game
                    {
                        GameName = "World of Tanks",
                        Genre = "Adventure",
                        Developer = "War Games",
                        Platform = "PC",
                        Languages = "ENGLISH CHINEASE GERMAN",
                        Rating = 5,
                        Description = "World of Tanks is a team-based online shooter in which you take control of historic tanks."
                    },
                    new Game
                    {
                        GameName = "Two Dots",
                        Genre = "Puzzle",
                        Developer = "Play Dots",
                        Platform = "Android iOS",
                        Languages = "ENGLISH CHINEASE GERMAN",
                        Rating = 4,
                        Description = "A boat for one person"
                    },
                    new Game
                    {
                        GameName = "Mini Metro",
                        Genre = "Puzzle",
                        Developer = "Polo Club",
                        Platform = "PC ANDROID",
                        Languages = "ENGLISH CHINEASE GERMAN",
                        Rating = 1,
                        Description = "Mini Metro is a puzzle strategy video game developed by indie development team Dinosaur Polo Club."
                    }
                );
                context.SaveChanges();
            }
        }

    }
}