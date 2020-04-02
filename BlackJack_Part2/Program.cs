using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_Part2
{

    //PLAYER CLASS
    public class Player
    {
        public int HandValue { get; set; }
        public bool Stand { get; set; }
        public int Turn { get; set; }

        public Player(int handvalue, bool stand)
        {
            HandValue = handvalue;
            Stand = stand;
            Turn = 0;
        }
    }

    //DEALER CLASS
    public class Dealer
    {
        public int OpenValue { get; set; }
        public int HidValue { get; set; }
        public bool Stand { get; set; }

        public Dealer(int openvalue, int hidvalue, bool stand)
        {
            OpenValue = openvalue;
            HidValue = hidvalue;
            Stand = stand;
        }
    }

    public class GameInfo
    {
        public bool Active { get; set; }

        public GameInfo(bool active)
        {
            Active = active;
        }
    }

    class Program
    {

        public int PlayerDraw()
        {
            int x = 1;
            return x;
        }

        public int DealerHidDraw()
        {
            int x = 1;
            return x;
        }

        public int DealerRegDraw()
        {
            int x = 1;
            return x;
        }

        public int Stand()
        {
            int x = 1;
            return x;
        }

        static void Main(string[] args)
        {

            //CREATE PLAYER AND DEALER OBJECTS
            Player player = new Player(0, false);
            Dealer dealer = new Dealer(0, 0, false);
            GameInfo game = new GameInfo(true);

            //CREATE DECK
            Queue<int> deck = new Queue<int>();
            deck.Enqueue(3);
            deck.Enqueue(2);
            deck.Enqueue(7);
            deck.Enqueue(4);
            deck.Enqueue(25);
            deck.Enqueue(44);
            deck.Enqueue(15);
            deck.Enqueue(10);
            deck.Enqueue(51);
            deck.Enqueue(34);
            deck.Enqueue(11);
            deck.Enqueue(38);
            deck.Enqueue(37);
            deck.Enqueue(45);
            deck.Enqueue(17);
            deck.Enqueue(29);
            deck.Enqueue(27);
            deck.Enqueue(21);
            deck.Enqueue(12);
            deck.Enqueue(14);
            deck.Enqueue(28);
            deck.Enqueue(8);
            deck.Enqueue(32);
            deck.Enqueue(47);
            deck.Enqueue(33);
            deck.Enqueue(24);
            deck.Enqueue(43);
            deck.Enqueue(35);
            deck.Enqueue(6);
            deck.Enqueue(30);
            deck.Enqueue(52);
            deck.Enqueue(18);
            deck.Enqueue(31);
            deck.Enqueue(23);
            deck.Enqueue(16);
            deck.Enqueue(1);
            deck.Enqueue(26);
            deck.Enqueue(39);
            deck.Enqueue(49);
            deck.Enqueue(9);
            deck.Enqueue(20);
            deck.Enqueue(48);
            deck.Enqueue(42);
            deck.Enqueue(19);
            deck.Enqueue(22);
            deck.Enqueue(50);
            deck.Enqueue(41);
            deck.Enqueue(13);
            deck.Enqueue(36);
            deck.Enqueue(40);
            deck.Enqueue(46);
            deck.Enqueue(5);

            List<int> phand = new List<int>();
            List<int> dhand = new List<int>();

            //List<int> localList = repo.returnlist();

            //DRAW FIRST CARD IN DECK LIST AND SAVE TO drawncard
            int drawncard = deck.Dequeue();

            if (drawncard == 1 || drawncard == 14 || drawncard == 27 || drawncard == 40)
            {
                Console.WriteLine("You receive an Ace!");
                Console.WriteLine("Is the value of the Ace a 1 or 11?");
                int ace = 0;
                while (ace != 1 || ace != 11)
                {
                    Console.WriteLine("Please enter a 1 or 11");
                    ace = Int32.Parse(Console.ReadLine());
                }
                drawncard = ace;
                //phand.Add(drawncard);
                player.HandValue += drawncard; //was phand.sum();
                Console.WriteLine($"The value of your hand is now {player.HandValue}");
            }
            else if (drawncard == 2 || drawncard == 15 || drawncard == 28 || drawncard == 41)
            {
                drawncard = 2;
                //phand.Add(drawncard);
                player.HandValue += drawncard; //was phand.sum();
                Console.WriteLine($"You have received a 2. The value of your hand is now {player.HandValue}");
            }
            else if (drawncard == 3 || drawncard == 16 || drawncard == 29 || drawncard == 42)
            {
                drawncard = 3;
                //phand.Add(drawncard);
                player.HandValue += drawncard; //was phand.sum();
                Console.WriteLine($"You have received a 3. The value of your hand is now {player.HandValue}");
            }
            else if (drawncard == 4 || drawncard == 17 || drawncard == 30 || drawncard == 43)
            {
                drawncard = 4;
                //phand.Add(drawncard);
                player.HandValue += drawncard; //was phand.sum();
                Console.WriteLine($"You have received a 4. The value of your hand is now {player.HandValue}");
            }
            else if (drawncard == 5 || drawncard == 18 || drawncard == 31 || drawncard == 44)
            {
                drawncard = 5;
                //phand.Add(drawncard);
                player.HandValue += drawncard; //was phand.sum();
                Console.WriteLine($"You have received a 5. The value of your hand is now {player.HandValue}");
            }
            else if (drawncard == 6 || drawncard == 19 || drawncard == 32 || drawncard == 45)
            {
                drawncard = 6;
                //phand.Add(drawncard);
                player.HandValue += drawncard; //was phand.sum();
                Console.WriteLine($"You have received a 6. The value of your hand is now {player.HandValue}");
            }
            else if (drawncard == 7 || drawncard == 20 || drawncard == 33 || drawncard == 46)
            {
                drawncard = 7;
                //phand.Add(drawncard);
                player.HandValue += drawncard; //was phand.sum();
                Console.WriteLine($"You have received a 7. The value of your hand is now {player.HandValue}");
            }
            else if (drawncard == 8 || drawncard == 21 || drawncard == 34 || drawncard == 47)
            {
                drawncard = 8;
                //phand.Add(drawncard);
                player.HandValue += drawncard; //was phand.sum();
                Console.WriteLine($"You have received a 8. The value of your hand is now {player.HandValue}");
            }
            else if (drawncard == 9 || drawncard == 22 || drawncard == 35 || drawncard == 48)
            {
                drawncard = 9;
                //phand.Add(drawncard);
                player.HandValue += drawncard; //was phand.sum();
                Console.WriteLine($"You have received a 9. The value of your hand is now {player.HandValue}");
            }
            else if (drawncard == 10 || drawncard == 23 || drawncard == 36 || drawncard == 49)
            {
                drawncard = 10;
                //phand.Add(drawncard);
                player.HandValue += drawncard; //was phand.sum();
                Console.WriteLine($"You have received a 10. The value of your hand is now {player.HandValue}");
            }
            else if (drawncard == 11 || drawncard == 24 || drawncard == 37 || drawncard == 50)
            {
                drawncard = 10;
                //phand.Add(drawncard);
                player.HandValue += drawncard; //was phand.sum();
                Console.WriteLine($"You have received a Jack. The value of your hand is now {player.HandValue}");
            }
            else if (drawncard == 12 || drawncard == 25 || drawncard == 38 || drawncard == 51)
            {
                drawncard = 10;
                //phand.Add(drawncard);
                player.HandValue += drawncard; //was phand.sum();
                Console.WriteLine($"You have received a Queen. The value of your hand is now {player.HandValue}");
            }
            else if (drawncard == 13 || drawncard == 26 || drawncard == 39 || drawncard == 52)
            {
                drawncard = 10;
                //phand.Add(drawncard);
                player.HandValue += drawncard; //was phand.sum();
                Console.WriteLine($"You have received a King. The value of your hand is now {player.HandValue}");
            }
            //Console.WriteLine(player.HandValue);

            //DEAL FIRST CARD TO DEALER
            dealer.OpenValue = deck.Dequeue();
            drawncard = dealer.OpenValue;
            if (drawncard == 1 || drawncard == 14 || drawncard == 27 || drawncard == 40)
            {

                //THE DEALER WILL EVALUATE AN ACE DIFFERENTLY FOR THE FIRST CARD
                /*Console.WriteLine("You receive an Ace!");
                Console.WriteLine("Is the value of the Ace a 1 or 11?");
                int ace = Int32.Parse(Console.ReadLine());
                while (ace != 1 || ace != 11)
                {
                    Console.WriteLine("Please enter a 1 or 11");
                }*/

                drawncard = 11;
                //dhand.Add(drawncard);
                dealer.OpenValue = drawncard; //was dhand.Sum();
                Console.WriteLine($"The Dealer has drawn an Ace and his hand is now at 11");
            }
            else if (drawncard == 2 || drawncard == 15 || drawncard == 28 || drawncard == 41)
            {
                drawncard = 2;
                //dhand.Add(drawncard);
                dealer.OpenValue = drawncard;
                Console.WriteLine($"The Dealer has drawn an Ace and his hand is now at 2");
            }
            else if (drawncard == 3 || drawncard == 16 || drawncard == 29 || drawncard == 42)
            {
                drawncard = 3;
                //dhand.Add(drawncard);
                dealer.OpenValue = drawncard;
                Console.WriteLine($"The Dealer has drawn an 3 and his hand is now at 3");
            }
            else if (drawncard == 4 || drawncard == 17 || drawncard == 30 || drawncard == 43)
            {
                drawncard = 4;
                //dhand.Add(drawncard);
                dealer.OpenValue = drawncard;
                Console.WriteLine($"The Dealer has drawn a 4 and his hand is now at 4");
            }
            else if (drawncard == 5 || drawncard == 18 || drawncard == 31 || drawncard == 44)
            {
                drawncard = 5;
                //dhand.Add(drawncard);
                dealer.OpenValue = drawncard;
                Console.WriteLine($"The Dealer has drawn a 5 and his hand is now at 5");
            }
            else if (drawncard == 6 || drawncard == 19 || drawncard == 32 || drawncard == 45)
            {
                drawncard = 6;
                //dhand.Add(drawncard);
                dealer.OpenValue = drawncard;
                Console.WriteLine($"The Dealer has drawn a 6 and his hand is now at 6");
            }
            else if (drawncard == 7 || drawncard == 20 || drawncard == 33 || drawncard == 46)
            {
                drawncard = 7;
                //dhand.Add(drawncard);
                dealer.OpenValue = drawncard;
                Console.WriteLine($"The Dealer has drawn a 7 and his hand is now at 7");
            }
            else if (drawncard == 8 || drawncard == 21 || drawncard == 34 || drawncard == 47)
            {
                drawncard = 8;
                //dhand.Add(drawncard);
                dealer.OpenValue = drawncard;
                Console.WriteLine($"The Dealer has drawn a 8 and his hand is now at 8");
            }
            else if (drawncard == 9 || drawncard == 22 || drawncard == 35 || drawncard == 48)
            {
                drawncard = 9;
                //dhand.Add(drawncard);
                dealer.OpenValue = drawncard;
                Console.WriteLine($"The Dealer has drawn a 9 and his hand is now at 9");
            }
            else if (drawncard == 10 || drawncard == 23 || drawncard == 36 || drawncard == 49)
            {
                drawncard = 10;
                //dhand.Add(drawncard);
                dealer.OpenValue = drawncard;
                Console.WriteLine($"The Dealer has drawn a 10 and his hand is now at 10");
            }
            else if (drawncard == 11 || drawncard == 24 || drawncard == 37 || drawncard == 50)
            {
                drawncard = 10;
                //dhand.Add(drawncard);
                dealer.OpenValue = drawncard;
                Console.WriteLine($"The Dealer has drawn a Jack and his hand is now at 11");
            }
            else if (drawncard == 12 || drawncard == 25 || drawncard == 38 || drawncard == 51)
            {
                drawncard = 10;
                //dhand.Add(drawncard);
                dealer.OpenValue = drawncard;
                Console.WriteLine($"The Dealer has drawn a Queen and his hand is now at 12");
            }
            else if (drawncard == 13 || drawncard == 26 || drawncard == 39 || drawncard == 52)
            {
                drawncard = 10;
                //dhand.Add(drawncard);
                dealer.OpenValue = drawncard;
                Console.WriteLine($"The Dealer has drawn a King and his hand is now at 13");
            }
            dealer.HidValue = dealer.OpenValue;

            //DRAW SECOND CARD FOR PLAYER
            drawncard = deck.Dequeue();
            if (drawncard == 1 || drawncard == 14 || drawncard == 27 || drawncard == 40)
            {
                Console.WriteLine("You receive an Ace!");
                Console.WriteLine("Is the value of the Ace a 1 or 11?");
                int ace = 0;
                while (ace != 1 || ace != 11)
                {
                    Console.WriteLine("Please enter a 1 or 11");
                    ace = Int32.Parse(Console.ReadLine());
                }
                player.HandValue += ace;
                Console.WriteLine($"The value of your hand is now {player.HandValue}");
            }
            else if (drawncard == 2 || drawncard == 15 || drawncard == 28 || drawncard == 41)
            {
                drawncard = 2;
                //phand.Add(drawncard);
                player.HandValue += drawncard; //was phand.sum();
                Console.WriteLine($"You have received a 2. The value of your hand is now {player.HandValue}");
            }
            else if (drawncard == 3 || drawncard == 16 || drawncard == 29 || drawncard == 42)
            {
                drawncard = 3;
                //phand.Add(drawncard);
                player.HandValue += drawncard; //was phand.sum();
                Console.WriteLine($"You have received a 3. The value of your hand is now {player.HandValue}");
            }
            else if (drawncard == 4 || drawncard == 17 || drawncard == 30 || drawncard == 43)
            {
                drawncard = 4;
                //phand.Add(drawncard);
                player.HandValue += drawncard; //was phand.sum();
                Console.WriteLine($"You have received a 4. The value of your hand is now {player.HandValue}");
            }
            else if (drawncard == 5 || drawncard == 18 || drawncard == 31 || drawncard == 44)
            {
                drawncard = 5;
                //phand.Add(drawncard);
                player.HandValue += drawncard; //was phand.sum();
                Console.WriteLine($"You have received a 5. The value of your hand is now {player.HandValue}");
            }
            else if (drawncard == 6 || drawncard == 19 || drawncard == 32 || drawncard == 45)
            {
                drawncard = 6;
                //phand.Add(drawncard);
                player.HandValue += drawncard; //was phand.sum();
                Console.WriteLine($"You have received a 6. The value of your hand is now {player.HandValue}");
            }
            else if (drawncard == 7 || drawncard == 20 || drawncard == 33 || drawncard == 46)
            {
                drawncard = 7;
                //phand.Add(drawncard);
                player.HandValue += drawncard; //was phand.sum();
                Console.WriteLine($"You have received a 7. The value of your hand is now {player.HandValue}");
            }
            else if (drawncard == 8 || drawncard == 21 || drawncard == 34 || drawncard == 47)
            {
                drawncard = 8;
                //phand.Add(drawncard);
                player.HandValue += drawncard; //was phand.sum();
                Console.WriteLine($"You have received a 8. The value of your hand is now {player.HandValue}");
            }
            else if (drawncard == 9 || drawncard == 22 || drawncard == 35 || drawncard == 48)
            {
                drawncard = 9;
                //phand.Add(drawncard);
                player.HandValue += drawncard; //was phand.sum();
                Console.WriteLine($"You have received a 9. The value of your hand is now {player.HandValue}");
            }
            else if (drawncard == 10 || drawncard == 23 || drawncard == 36 || drawncard == 49)
            {
                drawncard = 10;
                //phand.Add(drawncard);
                player.HandValue += drawncard; //was phand.sum();
                Console.WriteLine($"You have received a 10. The value of your hand is now {player.HandValue}");
            }
            else if (drawncard == 11 || drawncard == 24 || drawncard == 37 || drawncard == 50)
            {
                drawncard = 10;
                //phand.Add(drawncard);
                player.HandValue += drawncard; //was phand.sum();
                Console.WriteLine($"You have received a Jack. The value of your hand is now {player.HandValue}");
            }
            else if (drawncard == 12 || drawncard == 25 || drawncard == 38 || drawncard == 51)
            {
                drawncard = 10;
                //phand.Add(drawncard);
                player.HandValue += drawncard; //was phand.sum();
                Console.WriteLine($"You have received a Queen. The value of your hand is now {player.HandValue}");
            }
            else if (drawncard == 13 || drawncard == 26 || drawncard == 39 || drawncard == 52)
            {
                drawncard += 10;
                //phand.Add(drawncard);
                player.HandValue += drawncard; //was phand.sum();
                Console.WriteLine($"You have received a King. The value of your hand is now {player.HandValue}");
            }

            //DEAL THE DEALER ANOTHER CARD
            drawncard = deck.Dequeue();
            if (drawncard == 1 || drawncard == 14 || drawncard == 27 || drawncard == 40)
            {

                //THE DEALER WILL EVALUATE AN ACE DIFFERENTLY FOR THE FIRST CARD
                /*Console.WriteLine("You receive an Ace!");
                Console.WriteLine("Is the value of the Ace a 1 or 11?");
                int ace = Int32.Parse(Console.ReadLine());
                while (ace != 1 || ace != 11)
                {
                    Console.WriteLine("Please enter a 1 or 11");
                }*/

                drawncard = 11;
                //dhand.Add(drawncard);
                dealer.HidValue += drawncard; //was dhand.Sum();
                Console.WriteLine($"The Dealer has drawn a card their value remains at {dealer.OpenValue}");
            }
            else if (drawncard == 2 || drawncard == 15 || drawncard == 28 || drawncard == 41)
            {
                drawncard = 2;
                //dhand.Add(drawncard);
                dealer.HidValue += drawncard; //was dhand.Sum();
                Console.WriteLine($"The Dealer has drawn a card their value remains at {dealer.OpenValue}");
            }
            else if (drawncard == 3 || drawncard == 16 || drawncard == 29 || drawncard == 42)
            {
                drawncard = 3;
                //dhand.Add(drawncard);
                dealer.HidValue += drawncard; //was dhand.Sum();
                Console.WriteLine($"The Dealer has drawn a card their value remains at {dealer.OpenValue}");
            }
            else if (drawncard == 4 || drawncard == 17 || drawncard == 30 || drawncard == 43)
            {
                drawncard = 4;
                //dhand.Add(drawncard);
                dealer.HidValue += drawncard; //was dhand.Sum();
                Console.WriteLine($"The Dealer has drawn a card their value remains at {dealer.OpenValue}");
            }
            else if (drawncard == 5 || drawncard == 18 || drawncard == 31 || drawncard == 44)
            {
                drawncard = 5;
                //dhand.Add(drawncard);
                dealer.HidValue += drawncard; //was dhand.Sum();
                Console.WriteLine($"The Dealer has drawn a card their value remains at {dealer.OpenValue}");
            }
            else if (drawncard == 6 || drawncard == 19 || drawncard == 32 || drawncard == 45)
            {
                drawncard = 6;
                //dhand.Add(drawncard);
                dealer.HidValue += drawncard; //was dhand.Sum();
                Console.WriteLine($"The Dealer has drawn a card their value remains at {dealer.OpenValue}");
            }
            else if (drawncard == 7 || drawncard == 20 || drawncard == 33 || drawncard == 46)
            {
                drawncard = 7;
                //dhand.Add(drawncard);
                dealer.HidValue += drawncard; //was dhand.Sum();
                Console.WriteLine($"The Dealer has drawn a card their value remains at {dealer.OpenValue}");
            }
            else if (drawncard == 8 || drawncard == 21 || drawncard == 34 || drawncard == 47)
            {
                drawncard = 8;
                //dhand.Add(drawncard);
                dealer.HidValue += drawncard; //was dhand.Sum();
                Console.WriteLine($"The Dealer has drawn a card their value remains at {dealer.OpenValue}");
            }
            else if (drawncard == 9 || drawncard == 22 || drawncard == 35 || drawncard == 48)
            {
                drawncard = 9;
                //dhand.Add(drawncard);
                dealer.HidValue += drawncard; //was dhand.Sum();
                Console.WriteLine($"The Dealer has drawn a card their value remains at {dealer.OpenValue}");
            }
            else if (drawncard == 10 || drawncard == 23 || drawncard == 36 || drawncard == 49)
            {
                drawncard = 10;
                //dhand.Add(drawncard);
                dealer.HidValue += drawncard; //was dhand.Sum();
                Console.WriteLine($"The Dealer has drawn a card their value remains at {dealer.OpenValue}");
            }
            else if (drawncard == 11 || drawncard == 24 || drawncard == 37 || drawncard == 50)
            {
                drawncard = 10;
                //dhand.Add(drawncard);
                dealer.HidValue += drawncard; //was dhand.Sum();
                Console.WriteLine($"The Dealer has drawn a card their value remains at {dealer.OpenValue}");
            }
            else if (drawncard == 12 || drawncard == 25 || drawncard == 38 || drawncard == 51)
            {
                drawncard = 10;
                //dhand.Add(drawncard);
                dealer.HidValue += drawncard; //was dhand.Sum();
                Console.WriteLine($"The Dealer has drawn a card their value remains at {dealer.OpenValue}");
            }
            else if (drawncard == 13 || drawncard == 26 || drawncard == 39 || drawncard == 52)
            {
                drawncard = 10;
                //dhand.Add(drawncard);
                dealer.HidValue += drawncard; //was dhand.Sum();
                Console.WriteLine($"The Dealer has drawn a card their value remains at {dealer.OpenValue}");
            }

            //START THE TURNS WITH THE PLAYER'S FIRST TURN
            //IS IT THE PLAYER'S TURN?

            //RUN THE GAME
            while (game.Active)
            {

                //PLAYER'S TURN
                while (player.Stand == false && game.Active == true)
                {
                    Console.WriteLine($"Your hand is currently at {player.HandValue} \n" +
                    $"The Dealer's hand is currently at {dealer.OpenValue}");

                    Console.WriteLine($"Would you like to \n" +
                        $"1. draw a card\n" +
                        $"2. stand\n" +
                        $"3. exit");
                    int opt = Int32.Parse(Console.ReadLine());

                    if (opt == 1)
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
                            player.HandValue += ace;
                            Console.WriteLine($"The value of your hand is now {player.HandValue}");
                        }
                        else if (drawncard == 2 || drawncard == 15 || drawncard == 28 || drawncard == 41)
                        {
                            drawncard = 2;
                            player.HandValue += drawncard;
                            Console.WriteLine($"You have received a 2. The value of your hand is now {player.HandValue}");
                        }
                        else if (drawncard == 3 || drawncard == 16 || drawncard == 29 || drawncard == 42)
                        {
                            drawncard = 3;
                            player.HandValue += drawncard;
                            Console.WriteLine($"You have received a 3. The value of your hand is now {player.HandValue}");
                        }
                        else if (drawncard == 4 || drawncard == 17 || drawncard == 30 || drawncard == 43)
                        {
                            drawncard = 4;
                            player.HandValue += drawncard;
                            Console.WriteLine($"You have received a 4. The value of your hand is now {player.HandValue}");
                        }
                        else if (drawncard == 5 || drawncard == 18 || drawncard == 31 || drawncard == 44)
                        {
                            drawncard = 5;
                            player.HandValue += drawncard;
                            Console.WriteLine($"You have received a 5. The value of your hand is now {player.HandValue}");
                        }
                        else if (drawncard == 6 || drawncard == 19 || drawncard == 32 || drawncard == 45)
                        {
                            drawncard = 6;
                            player.HandValue += drawncard;
                            Console.WriteLine($"You have received a 6. The value of your hand is now {player.HandValue}");
                        }
                        else if (drawncard == 7 || drawncard == 20 || drawncard == 33 || drawncard == 46)
                        {
                            drawncard = 7;
                            player.HandValue += drawncard;
                            Console.WriteLine($"You have received a 7. The value of your hand is now {player.HandValue}");
                        }
                        else if (drawncard == 8 || drawncard == 21 || drawncard == 34 || drawncard == 47)
                        {
                            drawncard = 8;
                            player.HandValue += drawncard;
                            Console.WriteLine($"You have received a 8. The value of your hand is now {player.HandValue}");
                        }
                        else if (drawncard == 9 || drawncard == 22 || drawncard == 35 || drawncard == 48)
                        {
                            drawncard = 9;
                            player.HandValue += drawncard;
                            Console.WriteLine($"You have received a 9. The value of your hand is now {player.HandValue}");
                        }
                        else if (drawncard == 10 || drawncard == 23 || drawncard == 36 || drawncard == 49)
                        {
                            drawncard = 10;
                            player.HandValue += drawncard;
                            Console.WriteLine($"You have received a 10. The value of your hand is now {player.HandValue}");
                        }
                        else if (drawncard == 11 || drawncard == 24 || drawncard == 37 || drawncard == 50)
                        {
                            drawncard = 10;
                            player.HandValue += drawncard;
                            Console.WriteLine($"You have received a Jack. The value of your hand is now {player.HandValue}");
                        }
                        else if (drawncard == 12 || drawncard == 25 || drawncard == 38 || drawncard == 51)
                        {
                            drawncard = 10;
                            player.HandValue += drawncard;
                            Console.WriteLine($"You have received a Queen. The value of your hand is now {player.HandValue}");
                        }
                        else if (drawncard == 13 || drawncard == 26 || drawncard == 39 || drawncard == 52)
                        {
                            drawncard = 10;
                            player.HandValue += drawncard;
                            Console.WriteLine($"You have received a King. The value of your hand is now {player.HandValue}");
                        }
                        //EVALUATE HAND
                        if (player.HandValue > 21)
                        {
                            Console.WriteLine($"I'm sorry, you have busted with a hand value of {player.HandValue}.");
                            Console.WriteLine("Game over. Press any key to exit");
                            Console.ReadKey();
                            game.Active = false;
                        }
                        else
                        {
                            game.Active = true;
                        }
                    }
                    else if (opt == 2)
                    {
                        player.Stand = true;
                        Console.WriteLine($"You have opted to stand with the value of {player.HandValue}");
                        Console.WriteLine($"The Dealer's hand is {dealer.HidValue}");


                        while (dealer.HidValue < 17 && player.HandValue <= 21)
                        {
                            drawncard = deck.Dequeue();
                            if (drawncard == 1 || drawncard == 14 || drawncard == 27 || drawncard == 40)
                            {

                                //THE DEALER WILL EVALUATE AN ACE DIFFERENTLY FOR THE FIRST CARD
                                /*Console.WriteLine("You receive an Ace!");
                                Console.WriteLine("Is the value of the Ace a 1 or 11?");
                                int ace = Int32.Parse(Console.ReadLine());
                                while (ace != 1 || ace != 11)
                                {
                                    Console.WriteLine("Please enter a 1 or 11");
                                }*/

                                drawncard = 11;
                                //dhand.Add(drawncard);
                                dealer.HidValue += drawncard; //was dhand.Sum();
                                Console.WriteLine($"The Dealer has drawn a card their value is {dealer.HidValue}");
                            }
                            else if (drawncard == 2 || drawncard == 15 || drawncard == 28 || drawncard == 41)
                            {
                                drawncard = 2;
                                //dhand.Add(drawncard);
                                dealer.HidValue += drawncard; //was dhand.Sum();
                                Console.WriteLine($"The Dealer has drawn a card their value is {dealer.HidValue}");
                            }
                            else if (drawncard == 3 || drawncard == 16 || drawncard == 29 || drawncard == 42)
                            {
                                drawncard = 3;
                                //dhand.Add(drawncard);
                                dealer.HidValue += drawncard; //was dhand.Sum();
                                Console.WriteLine($"The Dealer has drawn a card their value is {dealer.HidValue}");
                            }
                            else if (drawncard == 4 || drawncard == 17 || drawncard == 30 || drawncard == 43)
                            {
                                drawncard = 4;
                                //dhand.Add(drawncard);
                                dealer.HidValue += drawncard; //was dhand.Sum();
                                Console.WriteLine($"The Dealer has drawn a card their value is {dealer.HidValue}");
                            }
                            else if (drawncard == 5 || drawncard == 18 || drawncard == 31 || drawncard == 44)
                            {
                                drawncard = 5;
                                //dhand.Add(drawncard);
                                dealer.HidValue += drawncard; //was dhand.Sum();
                                Console.WriteLine($"The Dealer has drawn a card their value is {dealer.HidValue}");
                            }
                            else if (drawncard == 6 || drawncard == 19 || drawncard == 32 || drawncard == 45)
                            {
                                drawncard = 6;
                                //dhand.Add(drawncard);
                                dealer.HidValue += drawncard; //was dhand.Sum();
                                Console.WriteLine($"The Dealer has drawn a card their value is {dealer.HidValue}");
                            }
                            else if (drawncard == 7 || drawncard == 20 || drawncard == 33 || drawncard == 46)
                            {
                                drawncard = 7;
                                //dhand.Add(drawncard);
                                dealer.HidValue += drawncard; //was dhand.Sum();
                                Console.WriteLine($"The Dealer has drawn a card their value is {dealer.HidValue}");
                            }
                            else if (drawncard == 8 || drawncard == 21 || drawncard == 34 || drawncard == 47)
                            {
                                drawncard = 8;
                                //dhand.Add(drawncard);
                                dealer.HidValue += drawncard; //was dhand.Sum();
                                Console.WriteLine($"The Dealer has drawn a card their value is {dealer.HidValue}");
                            }
                            else if (drawncard == 9 || drawncard == 22 || drawncard == 35 || drawncard == 48)
                            {
                                drawncard = 9;
                                //dhand.Add(drawncard);
                                dealer.HidValue += drawncard; //was dhand.Sum();
                                Console.WriteLine($"The Dealer has drawn a card their value is {dealer.HidValue}");
                            }
                            else if (drawncard == 10 || drawncard == 23 || drawncard == 36 || drawncard == 49)
                            {
                                drawncard = 10;
                                //dhand.Add(drawncard);
                                dealer.HidValue += drawncard; //was dhand.Sum();
                                Console.WriteLine($"The Dealer has drawn a card their value remains at {dealer.HidValue}");
                            }
                            else if (drawncard == 11 || drawncard == 24 || drawncard == 37 || drawncard == 50)
                            {
                                drawncard = 10;
                                //dhand.Add(drawncard);
                                dealer.HidValue += drawncard; //was dhand.Sum();
                                Console.WriteLine($"The Dealer has drawn a card their value is {dealer.HidValue}");
                            }
                            else if (drawncard == 12 || drawncard == 25 || drawncard == 38 || drawncard == 51)
                            {
                                drawncard = 10;
                                //dhand.Add(drawncard);
                                dealer.HidValue += drawncard; //was dhand.Sum();
                                Console.WriteLine($"The Dealer has drawn a card their value is {dealer.HidValue}");
                            }
                            else if (drawncard == 13 || drawncard == 26 || drawncard == 39 || drawncard == 52)
                            {
                                drawncard = 10;
                                //dhand.Add(drawncard);
                                dealer.HidValue += drawncard; //was dhand.Sum();
                                Console.WriteLine($"The Dealer has drawn a card their value is {dealer.HidValue}");
                            }
                        }
                    }

                    if (dealer.HidValue > 21 && player.HandValue <= 21)
                    {
                        Console.WriteLine($"The Dealer has busted with a hand value of {dealer.HidValue}. Congratulations! You won!");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        game.Active = false;
                    }
                    if (dealer.HidValue <= 21 && dealer.HidValue >= 17 && player.HandValue <= 21)
                    {

                        if (dealer.HidValue == player.HandValue && player.HandValue <= 21)
                        {
                            Console.WriteLine($"The Dealer's hand is {dealer.HidValue} and your hand is {player.HandValue}. The game is a draw. ");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                        }
                        else if (dealer.HidValue > player.HandValue && player.HandValue <= 21)
                        {
                            Console.WriteLine($"The Dealer's hand is {dealer.HidValue}, and your hand is {player.HandValue}. You lose.");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                        }
                        else if (dealer.HidValue < player.HandValue && player.HandValue <= 21)
                        {
                            Console.WriteLine($"The Dealer's hand is {dealer.HidValue}, and your hand is {player.HandValue}. Congratulations! You win!");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                        }
                        game.Active = false;
                    }

                    else if (opt == 3)
                    {
                        game.Active = false;
                    } else
                    {
                        Console.WriteLine("Please select an appropriate value");
                    }
                }
            }
        }
    }
}
