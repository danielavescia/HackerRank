using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HackerRank.ProblemSolving.C_.Data_Structures.ArrayRotation
{
    public class ArrayRotationLeft
    {
        public static List<int> rotateLeft( int d, List<int> arr )
        {
            int size = arr.Count;
            IsParametersValid( arr, d, size );

            for ( int i = 0; i < d ; i++ )
            {
                int aux = arr [0];
                arr.Remove( arr [0] );
                arr.Add( aux );
            }

            return arr;
        }


        public static void IsParametersValid( List<int> arr, int d, int size ) 
        {
            if ( d < 0 )
            {
                throw new ArgumentOutOfRangeException("d must be non-negative." );
            }

            if ( size == 0 & d > 0 )
            {
                throw new InvalidOperationException( "Cannot rotate an empty array." );
            }


        }
    }

   
}
