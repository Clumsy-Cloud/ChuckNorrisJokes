using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChuckNorrisJokes.API.Models
{
    public class JokeList
    {
        public int Total { get; set; }
        public Joke[] Result { get; set; }
    }
}
