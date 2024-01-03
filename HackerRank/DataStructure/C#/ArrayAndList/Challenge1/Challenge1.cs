using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace HackerRank.DataStructures.C_.ArrayAndList.Challenge1
{
    class Challenge1
    {
        public static int birthdayCakeCandles( List<int> candles )
        {
            int biggestCandles = 0;
            int totalBiggestCandles = 0;


            foreach ( int candle in candles )
            {
                bool constraint = IsCandleOkay( candle );

                if ( constraint == true )
                {
                    if ( candle > biggestCandles )
                    {
                        biggestCandles = candle;
                    }
                }
            }

            foreach ( int candle in candles )
            {
                if ( candle >= biggestCandles )
                {
                    totalBiggestCandles++;
                }
            }


            return totalBiggestCandles;

        }
        public static bool IsCandleOkay( int candle )
        {
            bool isOkay = false;


            if ( candle >= 1 && candle <= Math.Pow( 10, 7 ) )
            {
                isOkay = true;
            }

            return isOkay;
        }
    }
}



