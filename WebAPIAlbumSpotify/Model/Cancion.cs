using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIAlbumSpotify.Model
{
    public class Cancion
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Genero { get; set; }
        public int calificacion { get; set; }
    }
}
