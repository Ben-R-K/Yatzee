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

                if (CardWithNull)
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

                            int WriteRoll = 0;
                            if (RolldDices.Contains(1))
                            {
                                WriteRoll = Convert.ToInt32(RolldDices.Count(RolldDices => RolldDices.Equals(1)));
                                Console.Write($"{WriteRoll} ones");
                            }
                            if (RolldDices.Contains(2))
                            {
                                WriteRoll = Convert.ToInt32(RolldDices.Count(RolldDices => RolldDices.Equals(2)));
                                Console.Write($", {WriteRoll} twos");
                            }
                            if (RolldDices.Contains(3))
                            {
                                WriteRoll = Convert.ToInt32(RolldDices.Count(RolldDices => RolldDices.Equals(3)));
                                Console.Write($", {WriteRoll} threes");
                            }
                            if (RolldDices.Contains(4))
                            {
                                WriteRoll = Convert.ToInt32(RolldDices.Count(RolldDices => RolldDices.Equals(4)));
                                Console.Write($", {WriteRoll} fours");
                            }
                            if (RolldDices.Contains(5))
                            {
                                WriteRoll = Convert.ToInt32(RolldDices.Count(RolldDices => RolldDices.Equals(5)));
                                Console.Write($", {WriteRoll} fives");
                            }
                            if (RolldDices.Contains(6))
                            {
                                WriteRoll = Convert.ToInt32(RolldDices.Count(RolldDices => RolldDices.Equals(6)));
                                Console.Write($", {WriteRoll} Sixes.");
                            }
                            Console.WriteLine();

                            if (i < 2 && SavedRolls.Count < 4)
                            {
                            DiceFreezeMethod:
                                RolldDicesCopy = RolldDices;
                                Console.WriteLine("Wich rolls do you want to freeze?");
                                Console.WriteLine("To skip, just press enter.");
                                string SaveWish = Convert.ToString(Console.ReadLine());

                                //Skip statement
                                if (SaveWish.Length <= 0)
                                {
                                    
                                }
                                else
                                {
                                    //Checks if the SaveWish numbers are valit and Freezes them
                                    for (int ii = 0; ii < SaveWish.Length; ii++)
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
                                    for (int j = 0; j < PreeSavedRolls.Count; j++)
                                    {
                                        p.PlayerDices.RemoveAt(0);
                                    }
                                    //Saves rolls
                                    SavedRolls.AddRange(PreeSavedRolls);
                                    PreeSavedRolls.Clear();
                                }
                            }
                                

                            bool Combo = false;
                            if (i < 2)
                            {
                                Console.WriteLine("Do you want to chose a combo?");
                                string AnserToCombo = Convert.ToString(Console.ReadLine());

                                if (AnserToCombo.Contains("yes") || AnserToCombo.Contains("Yes"))
                                {
                                    Combo = true;
                                }
                            }
                            //Chose a combo and end turn
                            if (i == 2 || Combo == true)
                            {
                                SavedRolls.AddRange(RolldDices);
                                Console.WriteLine("Write wich combo you want to use.");
                                Console.WriteLine("Write 'discard' to your anser if your want to discard it.");
                                foreach (KeyValuePair<string, int?> entry in p.PlayerCard)
                                {
                                    Console.WriteLine($"{entry.Key}");
                                }
                            }
                            else
                            {
                                RolldDices.Clear();
                            }
                        }
                    }
                }


            }


        }
            
    }
}