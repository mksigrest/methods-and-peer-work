/*
 * Max Sigrest
 * IGME.201.01 - Interac Des & Alg Prob Sol III
 * 10/12/25
 */

using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        //Declaring Vars
        int maxsFavoriteNum;
        int samsFavoriteNum;
        int addNums;
        int subNums;

        //Initializing Vars 
        maxsFavoriteNum = 8;
        samsFavoriteNum = 13;

        //Interior function (subtract)
        int Subtract (int int1, int int2) {
            int value;
            value = int1 - int2;
            return value;
        }

        //Start of the program
        Console.WriteLine("Max's Favorite Number is " + maxsFavoriteNum);
        Console.WriteLine("Sam's Favorite Number is " + samsFavoriteNum);

        addNums = Add(maxsFavoriteNum, samsFavoriteNum);
        Console.WriteLine("The numbers added equal: " + addNums);

        subNums = Subtract(maxsFavoriteNum, samsFavoriteNum);
        Console.WriteLine("The numbers subtracted equal: " + subNums);
    }

    //Exterior function (add)
    static int Add (int int1, int int2)
    {
        int value;
        value = int1 + int2;
        return value;
    }
}