using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using CarsCollectors.Mvc.Models;
using CarsCollectors.Data.Context;
using CarsCollectors.Domain.Interfaces;
using CarsCollectors.Data.Repository;
using AutoMapper;
using CarsCollectors.Mvc.AutoMapper;
using System.Web.Mvc;

namespace CarsCollectors.Mvc.Controllers
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

        //Fabricantes/Get
        public ActionResult Get()
        {
            var mapper = Mapper.Map<IEnumerable<FabricanteVM>>(db.Fabricantes.OrderBy(f => f.Nome).ToList());
            return View( mapper);
        }

        //// GET: api/Fabricantes/5
        //[ResponseType(typeof(FabricanteVM))]
        //public IHttpActionResult GetFabricanteVM(Guid id)
        //{
        //    FabricanteVM fabricanteVM = db.Fabricantes.Find(id);
        //    if (fabricanteVM == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(fabricanteVM);
        //}

        //// PUT: api/Fabricantes/5
        //[ResponseType(typeof(void))]
        //public IHttpActionResult PutFabricanteVM(Guid id, FabricanteVM fabricanteVM)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != fabricanteVM.FabricanteId)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(fabricanteVM).State = EntityState.Modified;

        //    try
        //    {
        //        db.SaveChanges();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!FabricanteVMExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return StatusCode(HttpStatusCode.NoContent);
        //}

        //// POST: api/Fabricantes
        //[ResponseType(typeof(FabricanteVM))]
        //public IHttpActionResult PostFabricanteVM(FabricanteVM fabricanteVM)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    db.FabricanteVMs.Add(fabricanteVM);

        //    try
        //    {
        //        db.SaveChanges();
        //    }
        //    catch (DbUpdateException)
        //    {
        //        if (FabricanteVMExists(fabricanteVM.FabricanteId))
        //        {
        //            return Conflict();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return CreatedAtRoute("DefaultApi", new { id = fabricanteVM.FabricanteId }, fabricanteVM);
        //}

        //// DELETE: api/Fabricantes/5
        //[ResponseType(typeof(FabricanteVM))]
        //public IHttpActionResult DeleteFabricanteVM(Guid id)
        //{
        //    FabricanteVM fabricanteVM = db.FabricanteVMs.Find(id);
        //    if (fabricanteVM == null)
        //    {
        //        return NotFound();
        //    }

        //    db.FabricanteVMs.Remove(fabricanteVM);
        //    db.SaveChanges();

        //    return Ok(fabricanteVM);
        //}

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        //private bool FabricanteVMExists(Guid id)
        //{
        //    return db.FabricanteVMs.Count(e => e.FabricanteId == id) > 0;
        //}
    }
}