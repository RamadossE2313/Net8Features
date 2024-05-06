namespace Net8Features.PrimaryConstructor
{
    // without primary constructor example for the fields
    public class WithoutPrimaryConstructor
    {
        private string _firstName, _lastName;
        
        public WithoutPrimaryConstructor(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        public void GetFullName() => Console.WriteLine($"Full Name is : {_firstName} {_lastName} ");
    }

    //public record Sample(string FirstName, string LastName);

    // primary constructor example example for the fields

    // it follows like record type approach like above,
    // in record FirstName and LastName are properties
    // but in primary constructor firstName and lastName are parameters
    // primary constructor used to reduce the code
    // primary constructor are introduced in C#12 with Net 8
    // https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-12#primary-constructors
    // scope of the primary constructor is within the class body, so that we can assign the value for the parameter
    public class PrimaryConstructor (string firstName, string lastName)
    {
        public void GetFullName() => Console.WriteLine($"Full Name is : {firstName} {lastName} ");
    }
}
