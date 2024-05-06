namespace Net8Features.PrimaryConstructor
{
    // exmaple get and set property with primary constructor
    public class PrimaryConstructorWithProperties(string name, int age)
    {
        public string Name { get; set; } = name;
        public int Age { get; set; } = age;

        public void Print()
        {
            Console.WriteLine($"Printing name {Name} and age {Age}");
        }
    }

    // exmaple get and set property with primary constructor
    public class PrimaryConstructorWithPropertiesWithGet(string name, int age)
    {
        public string Name { get; } = name;
        public int Age { get; } = age;

        public void Print()
        {
            Console.WriteLine($"Printing name {Name} and age {Age}");
        }
    }
}
