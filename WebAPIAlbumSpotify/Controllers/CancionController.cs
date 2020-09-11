using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPIAlbumSpotify.Model;
using WebAPIAlbumSpotify.ModelDB;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPIAlbumSpotify.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CancionController : ControllerBase
    {
        // GET: api/<CancionController>
        [HttpGet]
        public IEnumerable<CancionDTO> Get()
        {   
            // Creo la lista
            List<CancionDTO> canciones = new List<CancionDTO>();

            // Instancio la conexion a la BD
            using(AlbumPistasSpotifyContext context = new AlbumPistasSpotifyContext())
            {
                var entidades = context.Cancion;
                foreach (var item in entidades)
                {
                    CancionDTO c = new CancionDTO();
                    c.Nombre = item.Nombre;
                    c.Genero = item.Genero;
                    c.Calificacion = item.Calificacion;
                    c.Id = item.Id;

                    canciones.Add(c);
                }
            }

            // Devuelvo el resultado final de como quedo mi lista
            return canciones;
        }

        // GET api/<CancionController>/5
        [HttpGet("{id}")]
        public CancionDTO Get(int id)
        {
            // Instancion el DTOdeCanciones
            CancionDTO c = new CancionDTO();

            // Instancio la conexion a la BD
            using (AlbumPistasSpotifyContext context = new AlbumPistasSpotifyContext())
            {
                var item = context.Cancion.FirstOrDefault(c => c.Id == id); // Busco la cancion con el id que mando capturado
                c.Nombre = item.Nombre;
                c.Genero = item.Genero;
                c.Calificacion = item.Calificacion;
                c.Id = item.Id;
            }

            // Devuelvo el resultado final de como quedo la busqueda
            return c;
        }

        // POST api/<CancionController>
        [HttpPost]
        public string Post([FromBody] CancionDTO value)
        {
            // Instancio la conexion a la BD
            using (AlbumPistasSpotifyContext context = new AlbumPistasSpotifyContext())
            {
                // Tabla de mi bd
                Cancion cancionTDB = new Cancion();

                // Asignando los datos que se capturan para insertar en la tabla Cancion de la BD
                cancionTDB.Nombre = value.Nombre;
                cancionTDB.Genero = value.Genero;
                cancionTDB.Calificacion = value.Calificacion;
                context.Add(cancionTDB);

                // Guarda la información a la tabla
                context.SaveChanges();

            }

            // Devuelvo el resultado final de estado
            return "Se agrego con éxito! ;)";
        }

        // PUT api/<CancionController>/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody] CancionDTO value)
        {
 
            // Instancio la conexion a la BD
            using (AlbumPistasSpotifyContext context = new AlbumPistasSpotifyContext())
            {

                // Encontrar el valor especifico a actualizar
                var resultado = context.Cancion.FirstOrDefault(c => c.Id == id);

                // Asignando los datos que se capturan para modificar en la tabla Cancion de la BD
                resultado.Nombre = value.Nombre;
                resultado.Genero = value.Genero;
                resultado.Calificacion = value.Calificacion;

                // Guarda la modificacion de datos a la tabla
                context.SaveChanges();

            }

            // Devuelvo el resultado final de estado
            return "Se actualizo con éxito! ;)";
        }

        // DELETE api/<CancionController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            /// Instancio la conexion a la BD
            using (AlbumPistasSpotifyContext context = new AlbumPistasSpotifyContext())
            {

                // Encontrar el valor especifico a actualizar
                var resultado = context.Cancion.FirstOrDefault(c => c.Id == id);
                context.Cancion.Remove(resultado); // Eliminar el registro de la tabla
                context.SaveChanges(); // Guarda la modificacion de datos a la tabla

            }

            // Devuelvo el resultado final de estado
            return "Se elimino con éxito! ;)";
        }
    }
}
