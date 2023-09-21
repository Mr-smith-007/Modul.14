using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqTest
{
    class Program
    {

        static void Main(string[] args)
        {

            string[] text = { "Раз два три", "четыре пять шесть", "семь восемь девять" };
            var words = from str in text 
                        from word in str.Split(' ') 
                        select word; 

            
            foreach (var word in words)
                Console.WriteLine(word);


        }


    }
}