using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        /*
        int[][] arr = new int[6][];
        for(int arr_i = 0; arr_i < 6; arr_i++){
           string[] arr_temp = Console.ReadLine().Split(' ');
           arr[arr_i] = arr_temp.Select(x => int.Parse(x)).ToArray(); //Array.ConvertAll(arr_temp,Int32.Parse);
        }
        */

        var arr = GetTestArr();

        int op = 4; // In our 6 line/column array we can get up to 4 hour glass levels
        
        int max = int.MinValue;
        int curr = 0;

        for(int i=0; i < op; i++) {

            for(int j=0; j<op; j++) {

                curr = arr[i,j] + arr[i,j+1] + arr[i,j+2];
                curr += arr[i+1,j+1];
                curr += arr[i+2,j] + arr[i+2,j+1] + arr[i+2,j+2];

                if(curr > max) {
                    max = curr;
                }
            }

        }

        Console.WriteLine(max);
    }


    static int[,] GetTestArr(){

        var arr = new int[,] {
                    {1, 1, 1, 0, 0, 0},
                    {0, 1, 0, 0, 0, 0},
                    {1, 1, 1, 0, 0, 0},
                    {0, 0, 2, 4, 4, 0},
                    {0, 0, 0, 2, 0, 0},
                    {0, 0, 1, 2, 4, 0}
                };

        /*
        var arr = new int[,] {
        {-1, -1, 0, -9, -2, -2},
        {-2, -1, -6, -8, -2, -5},
        {-1, -1, -1, -2, -3, -4},
        {-1, -9, -2, -4, -4, -5},
        {-7, -3, -3, -2, -9, -9},
        {-1, -3, -1, -2, -4, -5}
        };*/

        var size = 6;

        Console.WriteLine("\n\n");
        
        for(int i=0; i<size; i++) {
            for(int j=0; j<size; j++) {
                Console.Write($"{arr[i,j]} ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\n\n");

        return arr;
    }

}
