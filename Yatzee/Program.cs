namespace Yatzee
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How many players do there play?");
           int playercount = Convert.ToInt32(Console.ReadLine());
            World.PlayerCount(playercount);

            bool CardWithNull = true;
            while (CardWithNull)
            {
                foreach (Player p in World.players)
                {
                    if (true == p.PlayerCard.ContainsValue(null))
                    {
                        CardWithNull = true;
                        break;
                    }
                    else
                    {
                        CardWithNull = false;
                    }
                }


            }
            
        }
    }
}