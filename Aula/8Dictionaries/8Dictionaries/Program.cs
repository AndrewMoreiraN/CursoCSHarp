using System;
using System.Collections.Generic;

namespace _8Dictionaries
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();
            cookies["phone"] = "9129391299231";
            cookies["email"] = "asdas@hasdsd.coa";
            cookies["user"] = "asdasd";

            Console.WriteLine(cookies["email"]);
            foreach (string item in cookies.Values)
            {
                Console.WriteLine(item);
            }

            foreach (KeyValuePair<string, string> item in cookies)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
    }
}