namespace Yatzee
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How many players do there play?");
           int playercount = Convert.ToInt32(Console.ReadLine());
            World.PlayerCount(playercount);
        }
    }
}