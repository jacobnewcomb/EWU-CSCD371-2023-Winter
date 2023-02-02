using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CanHazFunny
{
    public class Jester
    {
        public IService JokeService { 
            get => _JokeService; 
            set => _JokeService = value ?? throw new ArgumentNullException(value.ToString());
        }
        private IService? _JokeService;
        public IServiceWriter JokeServiceWriter {
            get => _JokeServiceWriter; 
            set => _JokeServiceWriter = value ?? throw new ArgumentNullException(value.ToString());
        }
        private IServiceWriter? _JokeServiceWriter;

        public Jester(JokeService jokeService, JokeServiceWriter jokeServiceWriter) 
        {
            JokeService = jokeService;
            JokeServiceWriter = jokeServiceWriter;
        }

        public string TellJoke()
        {
            string joke = JokeService.GetJoke();
            while (joke.Contains("Chuck Norris", StringComparison.CurrentCulture))
            {
                joke = JokeService.GetJoke();
            }
            JokeServiceWriter.TellJoke(joke);
            return joke;
        }
    }
}
