using System;
using System.Collections.Generic;
using System.Linq;
using teamSegurosApi.Data;
using teamSegurosApi.Models;

namespace teamSegurosApi.Services
{
    public class CiudadService
    {
        private readonly SgContext _context;
        public CiudadService(SgContext context)
        {
            _context = context;
        }

        public IEnumerable<Ciudad> GetCiudades()
        {
            return _context.Ciudades.ToList();
        }

        public bool SaveCiudad(Ciudad ciudad)
        {
            _context.Ciudades.Add(ciudad);
            _context.SaveChanges();
            return true;
        }

        public bool UpdateCity(Ciudad ciudad)
        {
            var city = _context.Ciudades.FirstOrDefault(x => x.Id == ciudad.Id);
            city.Nombre = ciudad.Nombre;
            _context.SaveChanges();
            return true;
        }

        public bool DeleteCity(Guid id)
        {
            var city = _context.Ciudades.FirstOrDefault(x => x.Id == id);
            _context.Ciudades.Remove(city);
            _context.SaveChanges();
            return true;
        }




    }
}
