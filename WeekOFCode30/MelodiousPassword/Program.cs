using System;
using System.Linq;
using System.Text;

namespace ConsoleApplication
{
    public class Program
    {

        static char[] vowels = new char[]{'a','e','i','o','u'};
        static char[] consonants = new char[] {'b','c','d','f','g','h','j','k','l','m','n','p','q','r','s','t','v','w','x','z'};
        public static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());
            int n = 6;

            if(n >= 1) {
                makePassword(n-1, new char[n], vowels, consonants);
                makePassword(n-1, new char[n], consonants, vowels);
            }
            
            

        }

        static void makePassword(int pos, char[] password, char[] source1, char[] source2) {

            for(int i=0; i<source1.Length; i++) {
                password[pos] = source1[i];
                
                if(pos == 0) {
                    Console.WriteLine(password);
                }
                else {
                    makePassword(pos-1, password, source2, source1);
                } 
                
            }

            

        }
        
    }
}
