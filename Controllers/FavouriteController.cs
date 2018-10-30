using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using projectC.model;

namespace projectC.Controllers
{
    [Route("api/[controller]")]
    public class FavouritesController : Controller
    {

        ProjectContext _context;

        public FavouritesController(ProjectContext context)
        {
            this._context = context;
        }
        // GET api/values
        [HttpGet]
        public IQueryable<Favourite> Get()
        {
            var result = from m in this._context.Favourites select m;

            return result;
        }
    }
}