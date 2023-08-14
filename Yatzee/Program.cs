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

                foreach(Player p in World.players)
                {
                    List<int> RolldDices = new List<int>();
                    Console.WriteLine($"It is Player {p.Id} turn.");
                    Console.ReadLine();
                    for(int i = 0; i< 3; i++)
                    {
                        foreach (Dice d in p.PlayerDices)
                        {
                            RolldDices.Add(d.Roll());
                        }
                        Console.WriteLine($"Player {p.Id} did roll:");

                        if (RolldDices.Contains(1))
                        {
                            Console.Write($"{RolldDices.Where(RolldDices => RolldDices.Equals(1))} one's");
                        }
                        if(RolldDices.Contains(2))
                        {
                            Console.Write($",  {RolldDices.Where(RolldDices => RolldDices.Equals(2))} one's");
                        }
                        if (RolldDices.Contains(3))
                        {
                            Console.Write($",  {RolldDices.Where(RolldDices => RolldDices.Equals(3))} one's");
                        }
                        if (RolldDices.Contains(4))
                        {
                            Console.Write($", {RolldDices.Where(RolldDices => RolldDices.Equals(4))} one's");
                        }
                        if (RolldDices.Contains(5))
                        {
                            Console.Write($", {RolldDices.Where(RolldDices => RolldDices.Equals(5))} one's");
                        }
                        if (RolldDices.Contains(6))
                        {
                            Console.Write($", {RolldDices.Where(RolldDices => RolldDices.Equals(6))} one's.");
                        }
                    }
                    
                }

            }
            
        }
    }
}