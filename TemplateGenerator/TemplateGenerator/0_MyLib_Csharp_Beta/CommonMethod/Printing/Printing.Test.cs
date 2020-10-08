﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp_Beta.CommonMethod
{
    public static partial class Printing
    {

        public static void Test()
        {
            "Hello World!".Print();
            lnln(); // pure next line two times


            // Value Print //
            int intValue = 42;
            string stringValue = "It is a string";
            bool boolValue = true;

            intValue.Println();
            stringValue.Println();
            boolValue.Print();
            ln(2); // equal to lnln(), next line two times


            // 1D Array Print //
            int[] intArray = { 1, 10007, 42, 456 };
            intArray.Printlnln();


            /// 2D Array Print ///

            // For T[,] //
            int[,] int2dArray = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int2dArray.Printlnln();
            // 1, 2, 3
            // 4, 5, 6
            // 7, 8, 9

            // For T[][] //
            int[][] int2dJaggedArray = { new int[]{ 9, 8, 7, 6 }, new int[] { 5, 4, 3 }, new int[] { 2, 1 }, new int[] { 0 } };
            int2dJaggedArray.Printlnln();
            // 9, 8, 7, 6
            // 5, 4, 3
            // 2, 1
            // 0


            // Apply Println to each value //
            AllPrintln(
                "test1",
                "42",
                "asdsadas",
                "zxczxczx",
                "1234567890",
                "12212121",
                "meow"
            );

        }
        /* Output:
        Hello World!

        42
        It is a string
        True

        1, 10007, 42, 456

        1, 2, 3
        4, 5, 6
        7, 8, 9

        9, 8, 7, 6
        5, 4, 3
        2, 1
        0

        test1
        42
        asdsadas
        zxczxczx
        1234567890
        12212121
        meow
        */

    }
}
