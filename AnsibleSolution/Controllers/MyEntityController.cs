using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnsibleSolution.Abstractions;
using AnsibleSolution.Models;
using Microsoft.AspNetCore.Mvc;

namespace AnsibleSolution.Controllers
{
    public class MyEntityController : Controller
    {
        private IMyEntityService _myEntityService;

        public MyEntityController(IMyEntityService myEntityService)
        {
            _myEntityService = myEntityService;
        }

        public IActionResult All()
        {
            return View();
        }

        public IActionResult Id(int id)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public void Add(MyEntity entity)
        {

        }
    }
}