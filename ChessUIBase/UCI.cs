using System.Net;

namespace ChessUCIBase
{
    class UCI
    {
        string EngineName = "<enter name>";         // enter the name of your chess engine here
        string AutorName = "<your name>";           // enter your name here
        string CountryName = "<your country>";      // enter the name of your country here
        int DefaultHashsize = 128;                  // set here the default hash size wanted
        bool NullMove = true;                       // set here for nullmovesupport
        //temp code
        public static void Main(string[] args)
        {
            UCI uci = new UCI();
            uci.runUCI();
        }
        public void runUCI()
        {
            string command = Console.ReadLine();
            switch (command)
            {
                case "uci":
                    Console.WriteLine("id name " + EngineName);
                    Console.WriteLine("id author " + AutorName);
                    Console.WriteLine("id country " + CountryName);
                    Console.WriteLine("option name Hash type spin default "+ DefaultHashsize + " min 1 max 128");
                    Console.WriteLine("option name Nullmove type check default " + NullMove);
                    Console.WriteLine("uciok");
                    break;
                //case ""
            }
        }
    }
}