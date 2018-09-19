using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace myApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet("{p1}/{p2}")]
        public double add(int p1,int p2)
        {
            var test = new calc();
            var result = test.add(p1,p2);
            return result;
        }

        [HttpGet("{p1}/{p2}")]
        public double minus(int p1, int p2)
        {
            var test = new calc();
            var result = test.minus(p1, p2);
            return result;
        }

        [HttpGet("{p1}/{p2}")]
        public double multiply(int p1, int p2)
        {
            var test = new calc();
            var result = test.multiply(p1, p2);
            return result;
        }

        [HttpGet("{p1}/{p2}")]
        public double divide(int p1, int p2)
        {
            var test = new calc();
            var result = test.divide(p1, p2);
            return result;
        }
    }

    public class calc
    {
        public double add(int p1,int p2)
        {
            var result = p1 + p2;
            return result;
        }

        public double minus(int p1, int p2)
        {
            var result = p1 - p2;
            return result;
        }

        public double multiply(int p1, int p2)
        {
            var result = p1 * p2;
            return result;
        }

        public double divide(int p1, int p2)
        {
            var result = 1.0 * p1 / p2;
            return result;
        }


    }



}
