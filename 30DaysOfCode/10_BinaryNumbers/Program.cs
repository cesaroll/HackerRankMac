using System;


namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Num:");
            int n = int.Parse(Console.ReadLine());
            //int n =5;

            int max =0;
            int curr=0;
            for(int i = 0; i<32; i++)
            {
                if((n & 1) == 1) {
                    curr++;
                }
                else {
                    curr = 0;
                }

                if(curr > max)
                    max = curr;

                n >>= 1;
            }

            Console.WriteLine(max);
            Console.ReadKey(true);
        }
    }
}
