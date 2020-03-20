using System;
using System.Collections.Generic;

namespace DictionaryLikeDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dictionarylikedictionary = new Dictionary<int, string>();

            dictionarylikedictionary.Add(1, "fire");
            dictionarylikedictionary.Add(2, "Godzilla");
            dictionarylikedictionary.Add(3, "Fire");

            Console.WriteLine(dictionarylikedictionary[1]);


        //    for (int counter_dict = 0; counter_dict < dictionarylikedictionary.Count; counter_dict++)
          //  {
            //    Console.WriteLine("Key: {0}, Value: {1}",
         //                                               dictionarylikedictionary.Keys.ElementAt(counter_dict),
             //                                           dictionarylikedictionary.Keys.ElementAt(counter_dict)]);
           // }

            foreach (KeyValuePair<int, string> dictionar in dictionarylikedictionary)
            {

                Console.WriteLine(dictionar.Key+ " " +dictionar.Value);
                Console.WriteLine(dictionar);
            }
            
            Console.WriteLine("Hello World!");
        }
    }
}
