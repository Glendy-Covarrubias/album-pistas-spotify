using System;
using System.Collections.Generic;

namespace WebAPIAlbumSpotify.ModelDB
{
    public partial class Cancion
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Genero { get; set; }
        public int Calificacion { get; set; }
    }
}
