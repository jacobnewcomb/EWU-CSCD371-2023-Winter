using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CanHazFunny
{
    internal class Jester
    {
        public JokeService jokeService { get => _jokeService; set => _jokeService = value ?? throw new ArgumentNullException(value.ToString()); }
        private JokeService _jokeService;
        public JokeServiceWriter jokeServiceWriter { get => _jokeServiceWriter; set => _jokeServiceWriter = value ?? throw new ArgumentNullException(value.ToString()); }
        private JokeServiceWriter _jokeServiceWriter;
        public Jester() {}
        public void TellJoke()
        {
            string joke = jokeService.GetJoke();
            while (joke.Contains("Chuck Norris"))
            {
                joke = jokeService.GetJoke();
            }
            jokeServiceWriter.TellJoke(joke);
        }
    }
}
