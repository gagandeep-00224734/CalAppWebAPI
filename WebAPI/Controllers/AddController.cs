﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CalcLibrary;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AddController : ControllerBase
    {
        SimpleCalc simplecalc = new SimpleCalc();
        [HttpGet]
        public decimal Get([FromQuery] decimal value1, [FromQuery] decimal value2)
        {
            return simplecalc.add(2.10M, 3.65M);
        }

        [HttpPost]
        public decimal Post([FromForm] decimal value1, [FromForm] decimal value2)
        {
            return simplecalc.add(2.0M, 3.0M);
        }

        [HttpOptions]
        public string Options()
        {
            var text = "Get: Method return the addition of left variable and right variable value using FromQuery\n" +
                "Post: Method return the addition of left variable and right variable value using FromForm\n" +
                "Example: Get: 2.10M + 3.65M will return 5.75 after add, Post: 2.0M + 3.0M will return 6.00 after add\n" +
                "Varible Names: value1, value2";
            return text;
        }
    }
}