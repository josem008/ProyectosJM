using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplicationMVC3.Models;

namespace WebApplicationMVC3.Services
{
    public class PeliculaService
    {
        public Pelicula ObtenerPelicula()
        {

            return new Pelicula()
            {

                Titulo = "Avangers EndGame",
                Duracion = 150,
                Publicacion = "2019/02/05"

            };

        }

        public List<Pelicula> ObtenerPeliculas()
        {

            var pelicula1 = new Pelicula()
            {
                Titulo = "Avangers EndGame",
                Duracion = 150,
                Publicacion = "2019/02/05"

            };

            var pelicula2 = new Pelicula()
            {
                Titulo = "Toy Story 1",
                Duracion = 120,
                Publicacion = "2019/02/05"

            };
            var pelicula3 = new Pelicula()
            {
                Titulo = "Harry Potter El Prisionero de Askaban",
                Duracion = 260,
                Publicacion = "2019/02/05"

            };

            return new List<Pelicula> { pelicula1, pelicula2, pelicula3 };

        }

    }
}