using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnsibleSolution.Abstractions;
using AnsibleSolution.Models;
using Microsoft.AspNetCore.Mvc;

namespace AnsibleSolution.Controllers
{
    /// <summary>
    /// MyEntity Controller
    /// Contains all API endpoints to process for getting and setting MyEntity objects.
    /// </summary>
    public class MyEntityController : Controller
    {
        private IMyEntityService _myEntityService;

        public MyEntityController(IMyEntityService myEntityService)
        {
            _myEntityService = myEntityService;
        }

        /// <summary>
        ///     Gets all MyEntities from repository
        /// </summary>
        /// <returns>List<MyEntity></returns>
        public IActionResult All()
        {
            var entities = _myEntityService.GetAllEntities();

            return View(entities);
        }

        /// <summary>
        ///     Gets a MyEntity by Id
        /// </summary>
        /// <param name="id">Id of MyEntity object</param>
        /// <returns>MyEntity</returns>
        public IActionResult Id(int id)
        {
            var entity = _myEntityService.GetEntityById(id);

            return View(entity);
        }

        /// <summary>
        ///     Gets Add View with form to create a new MyEntity
        /// </summary>
        /// <returns>View</returns>
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        /// <summary>
        ///     Adds a new MyEntity to repository
        /// </summary>
        /// <param name="entity">MyEntity to be added</param>
        /// <returns>View</returns>
        [HttpPost]
        public IActionResult Add(MyEntity entity)
        {
            _myEntityService.AddEntity(entity);

            return RedirectToAction(@"../Home/Index");
        }
    }
}