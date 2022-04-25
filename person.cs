using System.Collections.Generic;
namespace oo_cookies
{
    public class Person
    {
        private System.Random rnd = new System.Random();
        public string firstname, surname, dob;
        public int height, id;
        public List<Subject> subjects;
        public Person(string firstname, string surname, string dob, int height)
        {
            this.firstname = firstname;
            this.surname = surname;
            this.dob = dob;
            this.height = height;
            this.id = rnd.Next(1000, 10000);
            this.subjects = new List<Subject>();
        }
        public string getFullName()
        {
            return $"{firstname} {surname}";
        }
        public int getHeightDifference(Person other)
        {
            if(height <= other.height) return other.height - height;
            return height - other.height;
        }
        public void printSubjects()
        {
            foreach (Subject subject in subjects)
            {
                System.Console.WriteLine(subject.name);
            }
        }
    }
}