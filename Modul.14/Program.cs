using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqTest
{
    class Program
    {

        static void Main(string[] args)
        {

            string[] words = { "Обезьяна", "Лягушка", "Кот", "Собака", "Черепаха" };

            var orderedWords = words.OrderBy(x => x.Length).Select(x => new {Word = x, Num = x.Length});

            foreach (var word in orderedWords)
            {
                Console.WriteLine($"В слове {word.Word} - {word.Num} букв");
            }
        }


    }
}