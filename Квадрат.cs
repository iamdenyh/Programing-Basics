using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int row = 0;  row < size;  row++)
            {

            }

        }
            
    }
}

//var size = int.Parse(Console.ReadLine());
//var fill = "";
//Console.WriteLine($"+{}+");
//for (int i = 0; i<size - 2; i++)
// {fill += "- ";
//   }
//FisrstRow
//  Console.WriteLine($"+ {fill}+");

//Middle Row
//for (int i = 0; i<size - 2; i++)
// {
//     Console.WriteLine($"| {fill}|");
//  }

// //LastRoww
//  Console.WriteLine($"+ {fill}+");

var sizeOfRombus = int.Parse(Console.ReadLine());
            for (int row = 1; row <= sizeOfRombus; row++)
            {
                var numberOfStars = row;
var numberOfStartSpaces = sizeOfRombus - numberOfStars;
Console.Write(new string (' ', numberOfStartSpaces));
                for (int col = 0; col<numberOfStars; col++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();

                //Second half
                for (int row = sizeOfRombus; row >= 1; row++)
                {
                    var numberOfStars = row;
var numberOfStartSpaces = sizeOfRombus - numberOfStars;
Console.Write(new string (' ', numberOfStartSpaces));
                    for (int col = 0; col<numberOfStars; col++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
