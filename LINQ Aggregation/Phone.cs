namespace LINQ_Aggregation
{
    public class Phone
    {
        public string Name { get;set; }
        public string Company { get;set; }
        public int Price { get;set; }
        public DateOnly ReleaseDate   { get;set; }

        public Phone(string name, string company, int price, DateOnly releaseDate)
        {
            Name = name;
            Company = company;
            Price = price;
            ReleaseDate = releaseDate;
        }

        public override string ToString()
        {
            return $"Name:{Name}, Company:{Company}, Price:{Price}, ReleaseDate:{ReleaseDate}";
        }
    }
}
