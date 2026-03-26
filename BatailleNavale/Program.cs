
//int[][] plateau2 = new int[3][];

//plateau2[0]=new int[] { 0,1,2,3,4,5,6,7,8,9};
//plateau2[1] = new int[] { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
//plateau2[2] = new int[] { 20, 21, 22, 23, 24, 25, 26, 27, 28, 29 };



//Console.WriteLine(plateau2[2][5]); 25




//String[][] board1 = new String[11][];

//board1[0] = new string[11] { "__|", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
//board1[1] = new String[11] { "1 |", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O" };
//board1[2] = new String[11] { "2 |", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O" };
//board1[3] = new String[11] { "3 |", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O" };
//board1[4] = new String[11] { "4 |", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O" };
//board1[5] = new String[11] { "5 |", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O" };
//board1[6] = new String[11] { "6 |", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O" };
//board1[7] = new String[11] { "7 |", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O" };
//board1[8] = new String[11] { "8 |", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O" };
//board1[9] = new String[11] { "9 |", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O" };
//board1[10] = new String[11] { "10|", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O" };


//Console.WriteLine("Hello this is your board!!!!\n");

//for (int i = 0; i < 10; i++)
//{
//    for (int j = 0; j < 10; j++)
//    {
//        Console.Write(board1[i][j]);
//    }
//    Console.WriteLine();
//}
//Console.WriteLine("\n");


using BatailleNavale;

Game g1 = new Game();



Console.WriteLine("Veuillez placer votre cuirassé (4 cases) par la première case en commençant par la lettre puis le chiffre par exemple B6");

string indication =Console.ReadLine();
string part1string = indication.Substring(0,1);
string part2string = indication.Substring(1,1);

char part1char = part1string.ToCharArray()[0];
int part1Int = (int)part1char-64;
//Console.WriteLine(part1int);
Int32.TryParse( part2string, out int part2Int);

//board1[part2Int][part1Int] = "B";


//for (int i = 0; i < 10; i++)
//{
//    for (int j = 0; j < 10; j++)
//    {
//        Console.Write(board1[i][j]);
//    }
//    Console.WriteLine();
//}
//Console.WriteLine("\n");

Console.WriteLine("Veuillez placer la dernière partie de votre cuirasser(+3 obligatoirement)");

//string indication = Console.ReadLine();
//string part1string = indication.Substring(0, 1);
//string part2string = indication.Substring(1, 1);

//char part1char = part1string.ToCharArray()[0];
//int part1Int = (int)part1char - 64;
////Console.WriteLine(part1int);
//Int32.TryParse(part2string, out int part2Int);

//board1[part2Int][part1Int] = "B";