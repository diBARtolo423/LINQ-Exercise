namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var games = new List<string>() { "MLB The Show", "Madden", "Fallout 4", "Red Dead Redemption", "The Last of Us", "Mario Kart" };

            var length = games.OrderBy(str => str.Length);


            foreach (var name in length)
            {
                Console.WriteLine(name);
            }

        }
    }
}
