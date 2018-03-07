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
            var entities = _myEntityService.GetAllEntities();

            return View(entities);
        }

        public IActionResult Id(int id)
        {
            var entity = _myEntityService.GetEntityById(id);

            return View(entity);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(MyEntity entity)
        {
            _myEntityService.AddEntity(entity);

            return RedirectToAction(@"../Home/Index");
        }
    }
}