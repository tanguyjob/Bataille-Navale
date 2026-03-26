using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatailleNavale
{
    internal class Game
    {
        public Game() 
        {
            Initialisation();
            ShowMyBoard();
            Ships = new List<Ship> 
            {
               //new Ship("Carrier",5),
               //new Ship("Battleship",4),
               //new Ship("Battleship",4),
               //new Ship("Cruiser",5),
               //new Ship("Cruiser",5),
               //new Ship("Cruiser",5),
               //new Ship("Carrier",5),

            
            };
            

        }
        public String[][] Board1 { get; private set; }

        public List<Ship> Ships { get; private set; }





        public void Initialisation()
        {
            Board1 = new String[11][];

            Board1[0] = new string[11] { "__|", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
            Board1[1] = new String[11] { "1 |", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O" };
            Board1[2] = new String[11] { "2 |", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O" };
            Board1[3] = new String[11] { "3 |", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O" };
            Board1[4] = new String[11] { "4 |", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O" };
            Board1[5] = new String[11] { "5 |", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O" };
            Board1[6] = new String[11] { "6 |", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O" };
            Board1[7] = new String[11] { "7 |", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O" };
            Board1[8] = new String[11] { "8 |", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O" };
            Board1[9] = new String[11] { "9 |", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O" };
            Board1[10] = new String[11] { "10|", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O" };


            Console.WriteLine("Hello this is your board!!!!\n");
        }

        public void ShowMyBoard()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(Board1[i][j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");
        }

        


    }
}
