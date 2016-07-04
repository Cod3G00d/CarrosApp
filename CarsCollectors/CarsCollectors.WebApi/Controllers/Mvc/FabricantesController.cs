using AutoMapper;
using CarsCollectors.Application.Interfaces;
using CarsCollectors.Domain.Entities;
using CarsCollectors.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public ActionResult Details(Guid id)
        {
            var fabricante = Mapper.Map<Fabricante, FabricanteVM>(_fabService.FindBy(f => f.FabricanteId == id).FirstOrDefault());
            return View(fabricante);
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
        public ActionResult Edit(Guid id)
        {
            var fabricante = Mapper.Map<Fabricante, FabricanteVM>(_fabService.FindBy(f => f.FabricanteId == id).FirstOrDefault());
            return View(fabricante);
        }

        // POST: Fabricantes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Guid id, FabricanteVM vm)
        {
            if (ModelState.IsValid)
            {
                var fabricanteDomain = Mapper.Map<FabricanteVM, Fabricante>(vm);
                _fabService.Update(fabricanteDomain);
                _fabService.Save();

                return RedirectToAction("Index");
            }

            return View(vm);
        }

        // GET: Fabricantes/Delete/5
        public ActionResult Delete(Guid id)
        {
            var fabricante = Mapper.Map<Fabricante, FabricanteVM>(_fabService.FindBy(f => f.FabricanteId == id).FirstOrDefault());
            return View(fabricante);
        }

        // POST: Fabricantes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Guid id, FormCollection collection)
        {
            var fabricante = _fabService.FindBy(f => f.FabricanteId == id).FirstOrDefault();
            _fabService.Remove(fabricante);
            _fabService.Save();

            return RedirectToAction("Index");
        }
    }
}
