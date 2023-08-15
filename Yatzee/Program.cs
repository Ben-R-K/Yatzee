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
            //Player turns
            while (CardWithNull)
            {
                //Check if all playercards are fild
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

                if(CardWithNull)
                {
                    foreach (Player p in World.players)
                    {
                        List<int> RolldDices = new List<int>();
                        List<int> RolldDicesCopy = new List<int>();
                        List<int> SavedRolls = new List<int>();
                        List<int> PreeSavedRolls = new List<int>();
                        Console.WriteLine($"It is Player {p.Id} turn.");
                        Console.ReadLine();
                        for (int i = 0; i < 3; i++)
                        {
                            foreach (Dice d in p.PlayerDices)
                            {
                                RolldDices.Add(d.Roll());
                            }
                            //Writes to the console what the player rolld
                            Console.WriteLine($"Player {p.Id} did roll:");

                            if (RolldDices.Contains(1))
                            {
                                Console.Write($"{RolldDices.Where(RolldDices => RolldDices.Equals(1))} ones");
                            }
                            if (RolldDices.Contains(2))
                            {
                                Console.Write($",  {RolldDices.Where(RolldDices => RolldDices.Equals(2))} twos");
                            }
                            if (RolldDices.Contains(3))
                            {
                                Console.Write($",  {RolldDices.Where(RolldDices => RolldDices.Equals(3))} threes");
                            }
                            if (RolldDices.Contains(4))
                            {
                                Console.Write($", {RolldDices.Where(RolldDices => RolldDices.Equals(4))} fours");
                            }
                            if (RolldDices.Contains(5))
                            {
                                Console.Write($", {RolldDices.Where(RolldDices => RolldDices.Equals(5))} fives");
                            }
                            if (RolldDices.Contains(6))
                            {
                                Console.Write($", {RolldDices.Where(RolldDices => RolldDices.Equals(6))} Sixes.");
                            }


                            if (i < 2 && SavedRolls.Count< 4)
                            {   DiceFreezeMethod:
                                RolldDicesCopy = RolldDices;
                                Console.WriteLine("Wich rolls do you want to freeze?");
                                Console.WriteLine("To skip, just press enter.");
                               string SaveWish = Convert.ToString(Console.ReadLine());

                                //Skip statement
                                if(SaveWish.Length <= 0)
                                {
                                    break;
                                }
                                //Checks if the SaveWish numbers are valit
                                for(int ii = 0; ii<SaveWish.Length; ii++)
                                {
                                   int ToBeSavdeRoll = Convert.ToInt32(SaveWish.Substring(ii, 1));
                                    if (RolldDicesCopy.Contains(ToBeSavdeRoll))
                                    {
                                        PreeSavedRolls.Add(ToBeSavdeRoll);
                                        RolldDicesCopy.Remove(ToBeSavdeRoll);
                                    }
                                    else
                                    {
                                        PreeSavedRolls.Clear();
                                        RolldDicesCopy.Clear();
                                        Console.WriteLine("One of the entert numbers was nor fount. Plis Reenter your choise.");
                                        goto DiceFreezeMethod;
                                    }
                                }

                                //Removes amount of Frozen Dices from players dice list
                                for(int j= 0;j<PreeSavedRolls.Count;j++)
                                {
                                    p.PlayerDices.RemoveAt(j);
                                }
                                SavedRolls.AddRange(PreeSavedRolls);
                            }
                        }
                    }
                }
                

            }
            
        }
    }
}