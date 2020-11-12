using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationMVC3.Context;
using WebApplicationMVC3.Models;

namespace WebApplicationMVC3.Controllers
{
    public class PeliculasController : Controller
    {
        // GET: Peliculas

        TiendaPeliculasEntities2 dbobj = new TiendaPeliculasEntities2();


        public ActionResult Peliculas(pelicula obj)
        {
           
                return View(obj);

        }

        [HttpPost]
        public ActionResult AddPeliculas(Pelicula model)
        {
            pelicula obj = new pelicula();
            obj.idPelicula = model.Id;
            obj.titulo = model.Titulo;
            obj.duracion = model.Duracion;
            obj.publicacion = model.Publicacion;


            if(model.Id == 0)
            {
                dbobj.pelicula.Add(obj);
                dbobj.SaveChanges();

            }
            else
            {
                dbobj.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                dbobj.SaveChanges();

            }

            return Redirect("PeliculasList/");
            



           // return View("Peliculas");
        }

        public ActionResult PeliculasList()
        {
            var lista = dbobj.pelicula.ToList();


            return View(lista);
        }

        public ActionResult Delete(int id)
        {
            var res = dbobj.pelicula.Where(x=>x.idPelicula == id).First();
            dbobj.pelicula.Remove(res);
            dbobj.SaveChanges();

            var list = dbobj.pelicula.ToList();

            return Redirect("PeliculasList/");
           // return View("PeliculasList",list);
        }
    }
}