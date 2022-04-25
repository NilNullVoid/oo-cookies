using System;

namespace oo_cookies
{
    class Program
    {
        static void Main(string[] args)
        {
            colour brown = new colour(150,75,0,"brown");
            cookie chocolate = new cookie(1,"circle",brown);
            cookie squarechocolate = new cookie(2,"square",brown);
            colour black = new colour(0,0,0,"black");
            cookie darkchocolate = new cookie(1,"circle",black);
            cookie squaredarkchocolate = new cookie(2,"square",black);
            Console.WriteLine(chocolate.colour.red);
        }
    }
}
