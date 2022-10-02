using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessUCIBase
{
    internal class Movelist
    {
        // so when A1 = 1 and  H8 = 64 we have an table with an int and give all possible movable int with it. 
        // there is a hastable for everypiece (exept for the pawn where black and white have an other table)
        // there is also a kingchech table
        // for the pinned pieces we can just use the queen table
        Hashtable movesRook = new Hashtable();
        Hashtable movesKnight = new Hashtable();
        Hashtable movesQueen = new Hashtable(); // also pinned chech table
        Hashtable movesBishop = new Hashtable();
        Hashtable movesKing = new Hashtable();
        Hashtable movesWhitePawn = new Hashtable();
        Hashtable movesBlackPawn = new Hashtable();

        public static void Startup()
        {

            Hashtable movesRook = GenMovesRook();

        }
        public static Hashtable GenMovesRook()
        {
            Hashtable movesRook = new Hashtable();
            for (int i = 1; i < 64; i++)
            {
                ArrayList moves = new ArrayList();
                //we need 4 directions
                int key = i;
                while (key > 1) //down
                {
                    key -= 8;
                    moves.Add(key);
                }
                while (key < 64) //up
                {
                    key += 8;
                    moves.Add(key);
                }
                double rowDoubel = i / 8;
                int row = (int)Math.Round(rowDoubel, 0);

                for (int j = (row * 8) - 8; j < row * 8; j++) //horizontal row (left & right)
                {
                    if (j != i) //expetion for the square it is already on
                    {
                        moves.Add(j);
                    }
                };
                movesRook.Add(i,moves);


            }
            return movesRook;
        }
        public static Hashtable GenMovesKnight()
        {
            Hashtable movesKnight = new Hashtable();
            for (int i = 1; i < 64; i++)
            {
                ArrayList moves = new ArrayList();
                moves.Add(i - 7); //up left+8-1

            }
            return movesKnight;

        }
        public static void GenMovesBishop()
        {
            for (int i = 0; i < 64; i++)
            {

            }

        }
        public static void GenMovesKing()
        {
            for (int i = 0; i < 64; i++)
            {

            }

        }
        public static void GenMovesQueen()
        {
            for (int i = 0; i < 64; i++)
            {

            }

        }
        public static void GenMovesWhitePawns()
        {
            for (int i = 0; i < 64; i++)
            {

            }
        }
        public static void GenMovesBlackPawns()
        {
            for (int i = 0; i < 64; i++)
            {

            }
        }
    }
}
