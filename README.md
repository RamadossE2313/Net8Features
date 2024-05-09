<h1>Net 8 features and C#12 features</h1>
<h4>Primary Constructor</h4>
<p>Primary Constructor for class and struct is a new feature of C# 12, which allows you to have a constructor in an easier way. As presented, it’s also possible to use Primary Constructor for DI, reducing the number of lines of your code.</p>
 1. it follows like record type approach like above </br>
 2. in record FirstName and LastName are properties </br>
 3. but in primary constructor firstName and lastName are parameters </br>
 4. primary constructor used to reduce the code </br>
 5. primary constructor are introduced in C#12 with Net 8 </br>
 6. https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-12#primary-constructors </br>
 7. scope of the primary constructor is within the class body, so that we can assign the value for the parameter </br>
 </br>
<b>Example</b> <a href="https://github.com/RamadossE2313/Net8Features/tree/main/PrimaryConstructor">Primary constructor</a>

<h1>C#9 features</h1>
<h4>Record</h4>
<b>Example</b> <a href="https://github.com/RamadossE2313/Net8Features/blob/main/Records/EmployeeRecord.cs">Record</a>
 <h5> Understanding of records </h5>
 1. Record is part of C#9 </br>
 2. Record is just a fancy class </br>
 3. Record is immutable, means you can assign the value through construtor </br>
 4. You can't change the value of record property once instance is created </br>
 5. We can say record as readonly class, means you can assign the value of the property in the intialiation and later you can't change it </br>
 6. it's a thread safe because two thread will use only read data so no issues will come

 <h5> When to use records </h5>
 1. When the value can't change it.
 2. Reading data from database when changes are not required
 3. Processing data
