using ChuckNorrisJokes.API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ChuckNorrisJokes.API.Controllers
{
    [AllowAnonymous]
    [Route("[controller]")]
    [ApiController]
    public class JokesController : ControllerBase
    {
        // GET Random Joke
        [HttpGet("Random")]
        public async Task<Joke> Get()
        {
            try
            {
            var joke = await REST.RestAPI.GetAsync<Joke>(REST.RestAPI.BaseURL + "random");
            return joke;

            }
            catch (System.Exception)
            {

                throw;
            }
        }

        // GET Search Joke
        [HttpGet("Search")]
        public async Task<JokeList> SearchJoke([FromQuery]string query)
        {
            try
            {
            JokeList joke = await REST.RestAPI.GetAsync<JokeList>(REST.RestAPI.BaseURL + $"search?query={query}");
            return joke;
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        // GET random joke from category
        [HttpGet("Category")]
        public async Task<Joke> RandomJoke([FromQuery] string category)
        {
            try
            {
            var joke = await REST.RestAPI.GetAsync<Joke>(REST.RestAPI.BaseURL + $"random?category={category}");
            return joke;
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }

        // GET List of Categories
        [HttpGet("Categories")]
        public async Task<List<string>> Categories()
        {
            try
            {
            var categories = await REST.RestAPI.GetAsync<List<string>>(REST.RestAPI.BaseURL + "categories");
            return categories;
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}
