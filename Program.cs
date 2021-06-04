using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCourse
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Facade facade = new Facade();
            List<Player> players = facade.players;

            Console.Write("How many players you want to create: ");
            int numberOfPlayers = int.Parse(Console.ReadLine());
            Console.WriteLine("1. Tennis player");
            Console.WriteLine("2. Football player");
            Console.WriteLine("3. Basketball player");

            for (int i = 0; i < numberOfPlayers; i++)
            {
                Console.Write($"Please choose the type of player {i + 1}: ");
                int input = int.Parse(Console.ReadLine());
                
                switch (input)
                {
                    case 1:
                        Console.Write("Now type name for your tennis player: ");
                        var tName = Console.ReadLine();
                        TennisPlayerCreator tennisCreator = new TennisPlayerCreator(players);
                        facade.TennisMethod(tennisCreator, tName);
                        break;
                    case 2:
                        Console.Write("Now type name for your football player: ");
                        var fName = Console.ReadLine();
                        FootballPlayerCreator footballCreator = new FootballPlayerCreator(players);
                        facade.FootballMethod(footballCreator, fName);
                        break;
                    case 3:
                        Console.Write("Now type name for your basketball player: ");
                        var bName = Console.ReadLine();
                        BasketballPlayerCreator basketballCreator = new BasketballPlayerCreator(players);
                        facade.BasketballMethod(basketballCreator, bName);
                        break;
                }
                Console.WriteLine("-------------------------------------");
            }
            Console.WriteLine("-------------------------------------");

            Console.WriteLine("All created players:");
            for (int i = 0; i < players.Count; i++)
            {
                Console.WriteLine($"{i+1}. {players[i].GetName()} --> {players[i].GetType().Name}");
            }     
        }
    }
}
