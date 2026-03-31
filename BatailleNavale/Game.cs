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
            
            Ships = new List<Ship>()
            {
                new Carrier(),
                new Battleship(),
                new Cruiser(),
                new Cruiser(),
                new Destroyer(),
                new Destroyer(),
                new Submarine(),
            };
          

            InitializationBoard();
            ShowMyBoard();

            InitializationShip();
            ShowMyBoard();


        }
        public String[][] Board1 { get; private set; }

        public List<Ship> Ships { get; private set; }





        public void InitializationBoard()
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

        public void InitializationShip()
        {

      

            Console.WriteLine("Where do you want to place your {0} ({1} case(s)) ?", Ships[0].Name, Ships[0].Size);
            Console.WriteLine("Choose a case(By example B6)");
            Ships[0].Begin= Console.ReadLine();
            Console.WriteLine("Choose the last case where you want to put your {0}", Ships[0].Name);
            Ships[0].End = Console.ReadLine();
            StringToIndication(Ships[0].Begin);
            StringToIndication(Ships[0].End);

        }

        public void StringToIndication(string st)
        {
            
            string part1string = st.Substring(0,1);
            string part2string = st.Substring(1,1);
            char part1char= part1string.ToCharArray()[0];
            int part1Int=(int) part1char-64;
                                        
            Int32.TryParse(part2string, out int part2Int);
            Board1[part2Int][part1Int]="W";



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
