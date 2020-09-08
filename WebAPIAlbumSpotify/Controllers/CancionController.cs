using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPIAlbumSpotify.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPIAlbumSpotify.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CancionController : ControllerBase
    {
        // GET: api/<CancionController>
        [HttpGet]
        public IEnumerable<Cancion> Get()
        {   
            // Creo la lista
            List<Cancion> canciones = new List<Cancion>();

            // Le agrego datos a los atributos de la cancion para ir armando la lista
            Cancion c = new Cancion();
            c.Nombre = "Eres tu";
            c.Genero = "Balada";
            c.calificacion = 5;
            c.Id = 1;

            // Agrego el registro de la cancion a la lista de canciones
            canciones.Add(c);

            // Le agrego datos a los atributos de la cancion para ir armando la lista
            c = new Cancion();
            c.Nombre = "El úlimo ska";
            c.Genero = "Ska";
            c.calificacion = 5;
            c.Id = 2;

            // Agrego el registro de la cancion a la lista de canciones
            canciones.Add(c);

            // Devuelvo el resultado final de como quedo mi lista
            return canciones;
        }

        // GET api/<CancionController>/5
        [HttpGet("{id}")]
        public Cancion Get(int id)
        {
            // Creo la lista
            List<Cancion> canciones = new List<Cancion>();

            // Le agrego datos a los atributos de la cancion para ir armando la lista
            Cancion c = new Cancion();
            c.Nombre = "Eres tu";
            c.Genero = "Balada";
            c.calificacion = 5;
            c.Id = 1;

            // Agrego el registro de la cancion a la lista de canciones
            canciones.Add(c);

            // Le agrego datos a los atributos de la cancion para ir armando la lista
            c = new Cancion();
            c.Nombre = "El úlimo ska";
            c.Genero = "Ska";
            c.calificacion = 5;
            c.Id = 2;

            // Agrego el registro de la cancion a la lista de canciones
            canciones.Add(c);

            // Encontrar el valor especifico a consultar
            Cancion resultado = canciones.Find(c => c.Id == id); // Expresion lambda

            // Devuelvo el resultado final de como quedo mi lista
            return resultado;
        }

        // POST api/<CancionController>
        [HttpPost]
        public string Post([FromBody] Cancion value)
        {
            // Creo la lista
            List<Cancion> canciones = new List<Cancion>();

            // Le agrego datos a los atributos de la cancion para ir armando la lista
            Cancion c = new Cancion();
            c.Nombre = "Eres tu";
            c.Genero = "Balada";
            c.calificacion = 5;
            c.Id = 1;

            // Agrego el registro de la cancion a la lista de canciones
            canciones.Add(c);

            // Le agrego datos a los atributos de la cancion para ir armando la lista
            c = new Cancion();
            c.Nombre = "El úlimo ska";
            c.Genero = "Ska";
            c.calificacion = 5;
            c.Id = 2;

            // Agrego el registro de la cancion a la lista de canciones
            canciones.Add(c);

            // Agregar cancion creada
            canciones.Add(value);

            // Devuelvo el resultado final de estado
            return "Se agrego con éxito! ;)";
        }

        // PUT api/<CancionController>/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody] Cancion value)
        {
            // Creo la lista
            List<Cancion> canciones = new List<Cancion>();

            // Le agrego datos a los atributos de la cancion para ir armando la lista
            Cancion c = new Cancion();
            c.Nombre = "Eres tu";
            c.Genero = "Balada";
            c.calificacion = 5;
            c.Id = 1;

            // Agrego el registro de la cancion a la lista de canciones
            canciones.Add(c);

            // Le agrego datos a los atributos de la cancion para ir armando la lista
            c = new Cancion();
            c.Nombre = "El úlimo ska";
            c.Genero = "Ska";
            c.calificacion = 5;
            c.Id = 2;

            // Agrego el registro de la cancion a la lista de canciones
            canciones.Add(c);

            // Encontrar el valor especifico a actualizar
            Cancion resultado = canciones.Find(c => c.Id == id); // Expresion lambda

            // Dato a actualizar
            resultado.calificacion = value.calificacion;

            // Devuelvo el resultado final de estado
            return "Se actualizo con éxito! ;)";
        }

        // DELETE api/<CancionController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            // Creo la lista
            List<Cancion> canciones = new List<Cancion>();

            // Le agrego datos a los atributos de la cancion para ir armando la lista
            Cancion c = new Cancion();
            c.Nombre = "Eres tu";
            c.Genero = "Balada";
            c.calificacion = 5;
            c.Id = 1;

            // Agrego el registro de la cancion a la lista de canciones
            canciones.Add(c);

            // Le agrego datos a los atributos de la cancion para ir armando la lista
            c = new Cancion();
            c.Nombre = "El úlimo ska";
            c.Genero = "Ska";
            c.calificacion = 5;
            c.Id = 2;

            // Agrego el registro de la cancion a la lista de canciones
            canciones.Add(c);

            // Encontrar el valor especifico a actualizar
            Cancion resultado = canciones.Find(c => c.Id == id); // Expresion lambda

            // Dato a Eliminar
            canciones.Remove(resultado);

            // Devuelvo el resultado final de estado
            return "Se elimino con éxito! ;)";
        }
    }
}
