using AutoMapper;
using CarsCollectors.Application.Interfaces;
using CarsCollectors.Domain.Entities;
using CarsCollectors.WebApi.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace CarsCollectors.WebApi.Controllers.Mvc
{
    public class FabricantesController : Controller
    {
        private readonly IAppFabricanteService _fabService;

        public FabricantesController(IAppFabricanteService fabService)
        {
            _fabService = fabService;

        }

        [Route("Fabricantes")]
        // GET: Fabricantes
        public ActionResult Index()
        {
            var fabricantes = Mapper.Map<IEnumerable<Fabricante>, IEnumerable<FabricanteVM>>(_fabService.GetAll());
            return View(fabricantes);
        }

        // GET: Fabricantes/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Fabricantes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Fabricantes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FabricanteVM vm)
        {
            if (ModelState.IsValid)
            {
                var fabricante = Mapper.Map<FabricanteVM, Fabricante>(vm);
                _fabService.Add(fabricante);
                _fabService.Save();
                return RedirectToAction("Index");
            }
            // TODO: Add insert logic here
            return View(vm);
        }

        // GET: Fabricantes/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Fabricantes/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Fabricantes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Fabricantes/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
