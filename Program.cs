using System;

namespace oo_cookies
{
    class Program
    {
        static void Main(string[] args)
        {
            Colour brown = new Colour(150,75,0,"brown");
            Cookie chocolate = new Cookie(1,"circle",brown);
            Cookie squarechocolate = new Cookie(2,"square",brown);
            Colour black = new Colour(0,0,0,"black");
            Cookie darkchocolate = new Cookie(1,"circle",black);
            Cookie squaredarkchocolate = new Cookie(2,"square",black);
            Console.WriteLine(chocolate.colour.red);

            Person John = new Person("John", "Doe", "1/1/1", 150);
            Person Jane = new Person("Jane", "Doe", "1/1/1", 145);
            Person Joseph = new Person("Joseph ", "Doe", "1/1/1", 155);
            Console.WriteLine(John.getFullName());
            Console.WriteLine(John.getHeightDifference(Jane));
            Console.WriteLine(John.id);

            Subject Math = new Subject("Math", "1/1/1");
            Math.grade = 100;
            Subject English = new Subject("English", "1/1/1");
            Math.grade = 20;
            John.subjects.Add(Math);
            John.subjects.Add(English);
            John.printSubjects();
        }
    }
}
