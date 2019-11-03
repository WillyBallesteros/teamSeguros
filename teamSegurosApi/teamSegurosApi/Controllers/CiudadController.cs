using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using teamSegurosApi.Data;
using teamSegurosApi.Models;

namespace teamSegurosApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CiudadController : ControllerBase
    {
        private SgContext _context;
        public CiudadController(SgContext sgContext)
        {
            _context = sgContext;
        }

        [HttpGet]
        public IEnumerable<Ciudad> GetAll()
        {
            return _context.Ciudades.ToList();
        }

        [HttpPost]
        public void SaveCity(Ciudad ciudad)
        {

            _context.Ciudades.Add(ciudad);
            _context.SaveChanges();

        }

        [HttpPost]
        public void UpdateCity(Ciudad ciudad)
        {
            var city = _context.Ciudades.FirstOrDefault(x => x.Id == ciudad.Id);
            city.Nombre = ciudad.Nombre;
            _context.SaveChanges();

        }

        [HttpDelete]
        public void DeleteCity(Guid id)
        {
            var city = _context.Ciudades.FirstOrDefault(x => x.Id == id);
            _context.Ciudades.Remove(city);
            _context.SaveChanges();

        }


    }
}