using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChuckNorrisJokes.API.Models
{
    public class Joke
    {
        public string[] Categories { get; set; }
        public DateTime Created_at { get; set; }
        public string Icon_url { get; set; }
        public string Id { get; set; }
        public DateTime UpdateTimed_at { get; set; }
        public string Url { get; set; }
        public string Value { get; set; }
    }
}
