namespace Net8Features.Records
{
    /************Understanding of records************************/
    // Record is part of C#8
    // Record is just a fancy class
    // Record is immutable, means you can assign the value through construtor 
    // You can't change the value of record property once instance is created
    // We can say record as readonly class, means you can assign the value of the property in the intialiation and later you can't change it
    // it's a thread safe because two thread will use only read data so no issues will come

    /**************When to use records *****************/
    // 1. When the value can't change it.
    // 2. Reading data from database when changes are not required
    // 3. Processing data

    /**************When not to use records *****************/
    // 1. When value will change


    /***************Record*******************/
    public record EmployeeRecord(string FirstName, string LastName);

    /***************Record with full properties and methods *******************/
    public record EmployeeRecordWithPropAndMethods(string FirstName, string LastName)
    {
        public string FirstName { get; init; } = FirstName;
        public string LastName { get; init; } = LastName;
        public string FullName() => $"{FirstName} {LastName}";
    }

    /***************Record with Inheritance *******************/

    public record TemporaryEmployeeRecord(int id, string FirstName , string LastName): EmployeeRecord(FirstName, LastName);

    public record TemporaryEmployeeRecordWithPropAndMethods(int id, string FirstName, string LastName) : EmployeeRecordWithPropAndMethods(FirstName, LastName);

    /***************Record BAD Examples *******************/
    public record EmployeeBadRecord(string FirstName, string LastName)
    {
        public string FirstName { get; set; } = FirstName; // Makes record mutable( means it can modified) Bad examples
        public string LastName { get; set; } = LastName;
    }


    /***************Class with same functionality as records*******************/
    public class EmployeeClass
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public EmployeeClass(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public (string, string) Deconstruct()
        {
            return (this.FirstName, this.LastName);
        }

        public void Deconstruct(out string firstName, out string lastName)
        {
            firstName = FirstName;
            lastName = LastName;
        }

        // deconstruct using tuple exmple
        public (string, string) DeconstructByTuple()
        {
            return (FirstName, LastName);
        }
    }
}
