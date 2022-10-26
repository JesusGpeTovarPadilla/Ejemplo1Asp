using Ejemplo1Asp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejemplo1Asp.Services
{
    public class PeliculasServices
    {
        public List<Peliculas> ObtenerPelicula()
        {
            var pelicula1 = new Peliculas()
            {
                Titulo = "Super man",
                Duración = 120,
                Pais = "USA",
                Publicacion = new DateTime(2013, 12, 5)
            };
            var pelicula2 = new Peliculas()
            {
                Titulo = "Spider Man",
                Duración = 150,
                Pais = "USA",
                Publicacion = new DateTime(2015, 02, 5)
            };
            return new List<Peliculas> { pelicula1,pelicula2};
        }
    }
}