using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackRepo
{
    public class BlackJackRepo
    {
        public int PlayerDraw()
        {
            drawncard = deck.Dequeue();
            if (drawncard == 1 || drawncard == 14 || drawncard == 27 || drawncard == 40)
            {
                Console.WriteLine("You receive an Ace!");
                Console.WriteLine("Is the value of the Ace a 1 or 11?");
                int ace = Int32.Parse(Console.ReadLine());
                while (ace != 1 || ace != 11)
                {
                    Console.WriteLine("Please enter a 1 or 11");
                }
                player.HandValue = +ace;
                Console.WriteLine($"The value of your hand is now {player.HandValue}");
            }
            else if (drawncard == 2 || drawncard == 15 || drawncard == 28 || drawncard == 41)
            {
                drawncard = 2;
                player.HandValue = +drawncard;
                Console.WriteLine($"You have received a 2. The value of your hand is now {player.HandValue}");
            }
            else if (drawncard == 3 || drawncard == 16 || drawncard == 29 || drawncard == 42)
            {
                drawncard = 3;
                player.HandValue = +drawncard;
                Console.WriteLine($"You have received a 3. The value of your hand is now {player.HandValue}");
            }
            else if (drawncard == 4 || drawncard == 17 || drawncard == 30 || drawncard == 43)
            {
                drawncard = 4;
                player.HandValue = +drawncard;
                Console.WriteLine($"You have received a 4. The value of your hand is now {player.HandValue}");
            }
            else if (drawncard == 5 || drawncard == 18 || drawncard == 31 || drawncard == 44)
            {
                drawncard = 5;
                player.HandValue = +drawncard;
                Console.WriteLine($"You have received a 5. The value of your hand is now {player.HandValue}");
            }
            else if (drawncard == 6 || drawncard == 19 || drawncard == 32 || drawncard == 45)
            {
                drawncard = 6;
                player.HandValue = +drawncard;
                Console.WriteLine($"You have received a 6. The value of your hand is now {player.HandValue}");
            }
            else if (drawncard == 7 || drawncard == 20 || drawncard == 33 || drawncard == 46)
            {
                drawncard = 7;
                player.HandValue = +drawncard;
                Console.WriteLine($"You have received a 7. The value of your hand is now {player.HandValue}");
            }
            else if (drawncard == 8 || drawncard == 21 || drawncard == 34 || drawncard == 47)
            {
                drawncard = 8;
                player.HandValue = +drawncard;
                Console.WriteLine($"You have received a 8. The value of your hand is now {player.HandValue}");
            }
            else if (drawncard == 9 || drawncard == 22 || drawncard == 35 || drawncard == 48)
            {
                drawncard = 9;
                player.HandValue = +drawncard;
                Console.WriteLine($"You have received a 9. The value of your hand is now {player.HandValue}");
            }
            else if (drawncard == 10 || drawncard == 23 || drawncard == 36 || drawncard == 49)
            {
                drawncard = 10;
                player.HandValue = +drawncard;
                Console.WriteLine($"You have received a 10. The value of your hand is now {player.HandValue}");
            }
            else if (drawncard == 11 || drawncard == 24 || drawncard == 37 || drawncard == 50)
            {
                drawncard = 11;
                player.HandValue = +drawncard;
                Console.WriteLine($"You have received a Jack. The value of your hand is now {player.HandValue}");
            }
            else if (drawncard == 12 || drawncard == 25 || drawncard == 38 || drawncard == 51)
            {
                drawncard = 12;
                player.HandValue = +drawncard;
                Console.WriteLine($"You have received a Queen. The value of your hand is now {player.HandValue}");
            }
            else if (drawncard == 13 || drawncard == 26 || drawncard == 39 || drawncard == 52)
            {
                drawncard = 13;
                player.HandValue = +drawncard;
                Console.WriteLine($"You have received a King. The value of your hand is now {player.HandValue}");
            }
        }

    }
}
