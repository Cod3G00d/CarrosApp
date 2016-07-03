using AutoMapper;
using CarsCollectors.Data.Context;
using CarsCollectors.Data.Repository;
using CarsCollectors.Domain.Entities;
using CarsCollectors.Domain.Interfaces;
using CarsCollectors.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarsCollectors.WebApi.Controllers.Mvc
{
    public class FabricantesController : Controller
    {
        private CarsCollectorsContext db;
        private IFabricanteRepository repo;

        public FabricantesController()
        {
            db = new CarsCollectorsContext();
            repo = new FabricanteRepository(db);

        }

        [Route("Fabricantes")]
        // GET: Fabricantes
        public ActionResult Index()
        {
            var fabricantes = Mapper.Map<IEnumerable<Fabricante>, IEnumerable<FabricanteVM>>(repo.GetAll().OrderBy(f => f.Nome).ToList());
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
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
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
