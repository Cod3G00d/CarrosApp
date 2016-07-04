using AutoMapper;
using CarsCollectors.Application.Interfaces;
using CarsCollectors.Domain.Entities;
using CarsCollectors.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace CarsCollectors.WebApi.Controllers.WebApi
{
    //[RoutePrefix("api")]
    public class FabricantesController : ApiController
    {
        private readonly IAppFabricanteService _fabService;

        public FabricantesController(IAppFabricanteService fabService)
        {
            _fabService = fabService;

        }

        [HttpGet]
        //[Route("api/Fabricantes")]
        // GET api/<controller>
        public IHttpActionResult Get()
        {
            var fabricantes = Mapper.Map<IEnumerable<Fabricante>, IEnumerable<FabricanteVM>>(_fabService.GetAll());
            return Ok(fabricantes);
        }

        // GET api/<controller>/5
        public IHttpActionResult Get(Guid id)
        {
            var fabricante = Mapper.Map<Fabricante, FabricanteVM>(_fabService.FindBy(f => f.FabricanteId == id).FirstOrDefault());
            return Ok(fabricante);
        }

        // POST api/<controller>
        public IHttpActionResult Post([FromBody]FabricanteVM vm)
        {
            if (ModelState.IsValid)
            {
                var fabricante = Mapper.Map<FabricanteVM, Fabricante>(vm);
                _fabService.Add(fabricante);
                _fabService.Save();
                return Created("", vm);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        // PUT api/<controller>/5
        public IHttpActionResult Put(Guid id, [FromBody]FabricanteVM vm)
        {
            if (ModelState.IsValid)
            {
                var fabricanteDomain = Mapper.Map<FabricanteVM, Fabricante>(vm);
                _fabService.Update(fabricanteDomain);
                _fabService.Save();
                return Ok(vm);
            }
            else
            {
                return BadRequest();
            }
        }

        // DELETE api/<controller>/5
        public IHttpActionResult Delete(Guid id)
        {
            var fabricante = _fabService.FindBy(f => f.FabricanteId == id).FirstOrDefault();
            _fabService.Remove(fabricante);
            _fabService.Save();
            return Ok();
        }
    }
}