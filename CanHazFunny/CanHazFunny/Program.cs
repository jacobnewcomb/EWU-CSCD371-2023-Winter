namespace CanHazFunny
{
    class Program
    {
        static void Main(string[] args)
        {
            Jester jester = new Jester() {jokeService = new JokeService(), jokeServiceWriter = new JokeServiceWriter()};
            for(int i = 0; i < 10; i++)
            {
                jester.TellJoke();
            }
        }
    }
}
