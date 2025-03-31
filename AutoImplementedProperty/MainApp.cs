using System;

namespace AutoImplementedProperty
{
    class BirthdayInfo
    {
        public DateTime Birthday { get; set; } = new DateTime(1, 1, 1);
        public string Name { get; set; } = "Unknown";        
        public int Age
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;
            }
        }
    }                
    
    class MainApp
    {
        static void Main(string[] args)
        {
            BirthdayInfo birth = new BirthdayInfo();
            Console.WriteLine($"Name: {birth.Name}");
            Console.WriteLine($"Birthday: {birth.Birthday}");
            Console.WriteLine($"Age: {birth.Age}");

            birth.Name = "dawon";
            birth.Birthday = new DateTime(2000, 12, 16);

            Console.WriteLine($"\nName: {birth.Name}");
            Console.WriteLine($"Birthday: {birth.Birthday.ToShortDateString()}");
            Console.WriteLine($"Age: {birth.Age}");
        }
    }
}
