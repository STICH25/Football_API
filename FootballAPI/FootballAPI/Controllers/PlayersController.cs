using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FootballAPI.Properties.Models;

namespace FootballAPI.Controllers
{
    [Route("api/[controller]")]
    public class PlayersController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<Players> Get()
        {
            var players = new List<Players>
            {
                new player
                {
                    Id = 01,
                    Name = "Messi",
                    Number = 10,
                    Position = "Striker",
                },

                 new player
                {
                    Id = 02,
                    Name = "Suarez",
                    Number = 09,
                    Position = "Striker",
                }
             };
            return players;
            
        }
            
     

        // GET api/values/5
        [HttpGet("{id}")]
        public Players Get(int id)
        {
            return new Players();
        }
     }

    internal class player : Players
    {
        public new int Id { get; set; }
        public new string Name { get; set; }
        public new int Number { get; set; }
        public new string Position { get; set; }
    }
}

