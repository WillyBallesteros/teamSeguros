using System;
using System.Collections.Generic;
using teamSegurosApi.Models;

namespace teamSegurosApi.Data
{
    public class SeedData
    {
        private Guid MazdaId = Guid.NewGuid();
        private Guid RenaultId = Guid.NewGuid();
        private Guid NissanId = Guid.NewGuid();
        public IEnumerable<Marca> GetMarcas()

        {
            var listaMarcas = new List<Marca>();
            listaMarcas.Add(new Marca
            {
                Id = MazdaId,
                Nombre = "Mazda"
            });
            listaMarcas.Add(new Marca
            {
                Id = RenaultId,
                Nombre = "Renault"
            });
            listaMarcas.Add(new Marca
            {
                Id = NissanId,
                Nombre = "Nissan"
            });

            return listaMarcas;

        }
        public IEnumerable<Ciudad> GetCiudades()
        {
            var listaCiudades = new List<Ciudad>();
            listaCiudades.Add(new Ciudad
            {
                Id = Guid.NewGuid(),
                Nombre = "Bogota"
            });
            listaCiudades.Add(new Ciudad
            {
                Id = Guid.NewGuid(),
                Nombre = "Medellin"
            });
            listaCiudades.Add(new Ciudad
            {
                Id = Guid.NewGuid(),
                Nombre = "Cali"
            });
            return listaCiudades;
        }
        public IEnumerable<Modelo> GetModelo()
        {
            var listaModelos = new List<Modelo>();
            listaModelos.Add(new Modelo
            {
                Id = Guid.NewGuid(),
                MarcaId = MazdaId,
                Nombre = "Mazda3"

            });
            listaModelos.Add(new Modelo
            {
                Id = Guid.NewGuid(),
                MarcaId = RenaultId,
                Nombre = "Symbol"

            });
            listaModelos.Add(new Modelo
            {
                Id = Guid.NewGuid(),
                MarcaId = NissanId,
                Nombre = "Versa"

            });
            return listaModelos;
        }
        public IEnumerable<TipoDocumento> GetTipoDocumento()
        {
            var tipoDocumento = new List<TipoDocumento>();
            tipoDocumento.Add(new TipoDocumento
            {
                Id = Guid.NewGuid(),
                Nombre = "Cedula de ciudadania"
            });
            tipoDocumento.Add(new TipoDocumento
            {
                Id = Guid.NewGuid(),
                Nombre = "Tarjeta de identidad"
            });
            return tipoDocumento;
        }
        public IEnumerable<Rol> GetRol()
        {
            var tipoRol = new List<Rol>();
            tipoRol.Add(new Rol
            {
                Id = Guid.NewGuid(),
                Nombre = "Administrador"

            });
            tipoRol.Add(new Rol
            {
                Id = Guid.NewGuid(),
                Nombre = "Usuario"

            });
            return tipoRol;

        }
    }
}
