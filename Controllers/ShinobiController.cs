using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_seven.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_seven.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShinobiController : ControllerBase
    {
        private static readonly Shinobi shinobi  = new Shinobi();

        private static List<Shinobi> shinobiList = new List<Shinobi>{
            new Shinobi{Id = 1, Name="Naruto"},
            new Shinobi{Id = 2, Name="Hinata"}
        };

        [HttpGet]
        [Route("{id}")]
        public ActionResult<Shinobi> Get(int id) {
            return Ok(shinobiList.FirstOrDefault(s => s.Id == id));
        }

        [HttpGet]
        [Route("GetAllShinobies")]
        public ActionResult<List<Shinobi>> GetShinobies() {
            return Ok(shinobiList);
        }

        [HttpPost]
        public ActionResult<List<Shinobi>> AddShinobi(Shinobi shinobi) {
            shinobiList.Add(shinobi);
            return Ok(shinobiList);
        }

    }
}