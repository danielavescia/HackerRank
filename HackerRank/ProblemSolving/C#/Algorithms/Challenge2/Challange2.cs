using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.ProblemSolving.C_.Algorithms.Challenge2
{
    class Challange2
    {
        /*
         * Complete the 'diagonalDifference' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts 2D_INTEGER_ARRAY arr as parameter.
         */

        public static int DiagonalDifference( List<List<int>> arr )
        {
            int size = arr.Count;
            int leftToRightSum = 0;
            int rightToLeftSum = 0;


                for ( int i = 0 ; i < size ; i++ )
                {
                    leftToRightSum += arr [i] [i];
                    rightToLeftSum += arr [i] [size - 1 - i];
                }


            int absoluteDifference = Math.Abs( leftToRightSum - rightToLeftSum );

            return absoluteDifference;
        }
    }
}
