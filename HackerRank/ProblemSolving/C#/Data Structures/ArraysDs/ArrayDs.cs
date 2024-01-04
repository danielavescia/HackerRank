using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.ProblemSolving.C_.Data_Structures.ArraysDs
{
    public class ArrayDs
    {
        public static List<int> ReverseArray( List<int> a )
        {
            int j = 0;
            int n = a.Count - 1;
            List<int> reversed = new ();

            for ( int i = n ; i >= 0 ; i-- )
            {

                reversed.Add( a [i] );
                j++;

            }

            return reversed;

        }
    }

    /*
    class Solution
    {
        public static void Main( string [] args )
        {
            TextWriter textWriter = new StreamWriter( Environment.GetEnvironmentVariable( "OUTPUT_PATH" ), true );

            int arrCount = Convert.ToInt32( Console.ReadLine().Trim() );

            List<int> arr = Console.ReadLine().TrimEnd().Split( ' ' ).ToList().Select( arrTemp => Convert.ToInt32( arrTemp ) ).ToList();

            List<int> res = ArrayDs.ReverseArray( arr );

            textWriter.WriteLine( String.Join( " ", res ) );

            textWriter.Flush();
            textWriter.Close();
        }

    }*/
}