using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using teamSegurosApi.Models;
using teamSegurosApi.Services;

namespace teamSegurosApi.Controllers
{
    [Route("api/v2/[controller]")]
    [ApiController]
    public class CiudadController : ControllerBase
    {
        private readonly CiudadService _ciudadService;
        public CiudadController(CiudadService ciudadService)
        {
            _ciudadService = ciudadService;
        }

        [HttpGet]
        public IEnumerable<Ciudad> GetAll()
        {
            return _ciudadService.GetCiudades();
        }

        [HttpPost]
        public void SaveCity(Ciudad ciudad)
        {

            _ciudadService.SaveCiudad(ciudad);

        }

        [HttpPut]
        public void UpdateCity(Ciudad ciudad)
        {
            _ciudadService.UpdateCity(ciudad);
        }

        [HttpDelete]
        public void DeleteCity(Guid id)
        {
            _ciudadService.DeleteCity(id);

        }


    }
}