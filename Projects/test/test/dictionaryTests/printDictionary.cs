using System;
using System.Collections.Generic;
using System.Linq;
namespace dictionaryTests
{
    public class printDictionary
    {

        public class EmptyClass
        {

            public static void Main(String[] args)
            {
                Dictionary<int, string> dict = new Dictionary<int, string>();

                dict.Add(1, "one");
                dict.Add(2, "two");

                foreach (KeyValuePair<int, string> item in dict)
                {
                    Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
                }

            }
        }

    }
}
