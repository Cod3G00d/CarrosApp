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
    public class TiposVeiculoController : Controller
    {
        private readonly IAppTipoVeiculoService _appService;

        public TiposVeiculoController(IAppTipoVeiculoService appService)
        {
            _appService = appService;
        }
        // GET: TiposVeiculo
        public ActionResult Index()
        {
            var model = Mapper.Map<IEnumerable<TipoVeiculo>, IEnumerable<TipoVeiculoVM>>(_appService.GetAll());
            return View(model);
        }

        // GET: TiposVeiculo/Details/5
        public ActionResult Details(Guid id)
        {
            var tv = Mapper.Map<TipoVeiculo, TipoVeiculoVM>(_appService.FindBy(f => f.TipoVeiculoId == id).FirstOrDefault());
            return View(tv);
        }

        // GET: TiposVeiculo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TiposVeiculo/Create
        [HttpPost]
        public ActionResult Create(TipoVeiculoVM vm)
        {
            if (ModelState.IsValid)
            {
                var tv = Mapper.Map<TipoVeiculoVM, TipoVeiculo>(vm);
                _appService.Add(tv);
                _appService.Save();
                return RedirectToAction("Index");
            }
            // TODO: Add insert logic here
            return View(vm);
        }

        // GET: TiposVeiculo/Edit/5
        public ActionResult Edit(Guid id)
        {
            return View();
        }

        // POST: TiposVeiculo/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Guid id, TipoVeiculoVM vm)
        {
            if (ModelState.IsValid)
            {
                var tv = Mapper.Map<TipoVeiculoVM, TipoVeiculo>(vm);
                _appService.Update(tv);
                _appService.Save();

                return RedirectToAction("Index");
            }

            return View(vm);
        }

        // GET: TiposVeiculo/Delete/5
        public ActionResult Delete(Guid id)
        {
            var tv = Mapper.Map<TipoVeiculo, TipoVeiculoVM>(_appService.FindBy(f => f.TipoVeiculoId == id).FirstOrDefault());
            return View(tv);
        }

        // POST: TiposVeiculo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Guid id, TipoVeiculoVM vm)
        {
            var fabricante = _appService.FindBy(f => f.TipoVeiculoId == id).FirstOrDefault();
            _appService.Remove(fabricante);
            _appService.Save();

            return RedirectToAction("Index");
        }
    }
}
