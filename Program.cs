using System;

namespace Phon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Galaxy s8 = new Galaxy("s8", 100, "T-Mobile", "Bingle Dingle Ding A Roo");
            Nokia elevenHundred = new Nokia("1100", 60, "Metro POS", "Ringo Beeple Deeple Dee");

            s8.DisplayInfo();
            Console.WriteLine(s8.Ring());
            Console.WriteLine(s8.Unlock());
            Console.WriteLine("");
            elevenHundred.DisplayInfo();
            Console.WriteLine(elevenHundred.Ring());
            Console.WriteLine(elevenHundred.Unlock());
            Console.WriteLine("");
        }
    }
}
