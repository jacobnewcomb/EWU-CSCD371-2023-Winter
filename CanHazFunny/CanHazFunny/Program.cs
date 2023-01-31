namespace CanHazFunny
{
    class Program
    {
        static void Main(string[] args)
        {
            Jester jester = new Jester(new JokeService(), new JokeServiceWriter());
            for(int i = 0; i < 10; i++)
            {
                jester.TellJoke();
            }
        }
    }
}
