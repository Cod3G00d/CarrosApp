using AutoMapper;
using CarsCollectors.Data.Context;
using CarsCollectors.Data.Repository;
using CarsCollectors.Domain.Entities;
using CarsCollectors.Domain.Interfaces.Repositories;
using CarsCollectors.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CarsCollectors.WebApi.Controllers.WebApi
{
    //[RoutePrefix("api")]
    public class FabricantesController : ApiController
    {
        private CarsCollectorsContext db;
        private IFabricanteRepository repo;

        public FabricantesController()
        {
            db = new CarsCollectorsContext();
            repo = new FabricanteRepository(db);

        }
        [HttpGet]
        //[Route("api/Fabricantes")]
        // GET api/<controller>
        public IEnumerable<FabricanteVM> Get()
        {
            return Mapper.Map<IEnumerable<Fabricante>, IEnumerable<FabricanteVM>>(repo.GetAll().OrderBy(f => f.Nome).ToList());
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}