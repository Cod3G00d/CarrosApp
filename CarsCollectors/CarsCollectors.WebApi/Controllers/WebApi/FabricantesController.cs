using AutoMapper;
using CarsCollectors.Application.Interfaces;
using CarsCollectors.Domain.Entities;
using CarsCollectors.WebApi.Models;
using System.Collections.Generic;
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
        public IEnumerable<FabricanteVM> Get()
        {
            return Mapper.Map<IEnumerable<Fabricante>, IEnumerable<FabricanteVM>>(_fabService.GetAll());
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