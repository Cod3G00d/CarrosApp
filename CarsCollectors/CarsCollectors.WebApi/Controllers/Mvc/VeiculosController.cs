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
    public class VeiculosController : Controller
    {
        private readonly IAppVeiculoService _appService;

        public VeiculosController(IAppVeiculoService appService)
        {
            _appService = appService;
        }
        // GET: Veiculos
        public ActionResult Index()
        {
            var model = Mapper.Map<IEnumerable<Veiculo>, IEnumerable<VeiculoVM>>(_appService.GetAll());
            return View(model);
        }

        // GET: Veiculos/Details/5
        public ActionResult Details(Guid id)
        {
            var tv = Mapper.Map<Veiculo, VeiculoVM>(_appService.FindBy(f => f.VeiculoId == id).FirstOrDefault());
            return View(tv);
        }

        // GET: Veiculos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Veiculos/Create
        [HttpPost]
        public ActionResult Create(VeiculoVM vm)
        {
            if (ModelState.IsValid)
            {
                var tv = Mapper.Map<VeiculoVM, Veiculo>(vm);
                _appService.Add(tv);
                _appService.Save();
                return RedirectToAction("Index");
            }
            // TODO: Add insert logic here
            return View(vm);
        }

        // GET: Veiculos/Edit/5
        public ActionResult Edit(Guid id)
        {
            return View();
        }

        // POST: Veiculos/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Guid id, VeiculoVM vm)
        {
            if (ModelState.IsValid)
            {
                var tv = Mapper.Map<VeiculoVM, Veiculo>(vm);
                _appService.Update(tv);
                _appService.Save();

                return RedirectToAction("Index");
            }

            return View(vm);
        }

        // GET: Veiculos/Delete/5
        public ActionResult Delete(Guid id)
        {
            var tv = Mapper.Map<Veiculo, VeiculoVM>(_appService.FindBy(f => f.VeiculoId == id).FirstOrDefault());
            return View(tv);
        }

        // POST: Veiculos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Guid id, VeiculoVM vm)
        {
            var fabricante = _appService.FindBy(f => f.VeiculoId == id).FirstOrDefault();
            _appService.Remove(fabricante);
            _appService.Save();

            return RedirectToAction("Index");
        }
    }
}
