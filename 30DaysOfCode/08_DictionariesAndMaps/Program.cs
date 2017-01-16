using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());

            var phoneBook = new SortedDictionary<string, string>();

            for(int i=0; i<n; i++)
            {
                var input = Console.ReadLine().Split(' ');
                phoneBook[input[0]] = input[1];
            }

            var name = Console.ReadLine();
            while(!String.IsNullOrWhiteSpace(name) )
            {
                string phone;
                if(phoneBook.TryGetValue(name, out phone))
                    Console.WriteLine($"{name}={phone}");
                else
                    Console.WriteLine("Not found");

                name = Console.ReadLine();
            }
        }
    }
}
