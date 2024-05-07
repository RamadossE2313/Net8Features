namespace Net8Features.Records
{
    // Record is part of C#8

    // Record is just a fancy class
    // Record is immutable, means you can assign the value through construtor 
    // You can't change the value of record property once instance is created
    // We can say record as readonly class, means you can assign the value of the property in the intialiation and later you can't change it

    public record EmployeeRecord(string FirstName, string LastName);

    public class EmployeeClass
    {
        public EmployeeClass(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
