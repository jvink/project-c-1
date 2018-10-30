﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using projectC.model;

namespace projectC.Controllers
{
    [Route("api/[controller]")]
    public class RolesController : Controller
    {

        ProjectContext _context;

        public RolesController(ProjectContext context)
        {
            this._context = context;
        }
        // GET api/values
        [HttpGet]
        public IQueryable<Role> Get()
        {
            var result = from m in this._context.Roles select m;

            return result;
        }
    }
}