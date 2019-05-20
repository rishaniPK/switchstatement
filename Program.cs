using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchstatement
{

    // This is used to find vowel using switch statements
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any Character : ");
            char ch = char.Parse(Console.ReadLine());
            string str =ch.ToString().ToLower();
            switch(str)
            {
               case "a":
                Console.WriteLine(str +"is a vowel");
                break;
                case "e":
                    Console.WriteLine(str + "is a vowel");
                    break;

                case "i":
                    Console.WriteLine(str + "is a vowel");
                    break;


                case "o":
                    Console.WriteLine(str + "is a vowel");
                    break;

                case "u":
                    Console.WriteLine(str + "is a vowel");
                    break;
                default:
                    Console.WriteLine(str + " " + "Is not vowel");
                    break;
            }
        }
    }
}
