namespace oo_cookies
{
    public class Subject
    {
        public string name, yearOfDelivery;
        public int grade { get; set; }
        public Subject(string name, string yearOfDelivery)
        {
            this.name = name;
            this.yearOfDelivery = yearOfDelivery;
        }
    }
}