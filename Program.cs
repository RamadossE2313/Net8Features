using Net8Features.PrimaryConstructor;
using Net8Features.Records;

#region PrimaryConstructor
WithoutPrimaryConstructor primaryConstructorBefore = new("x", "y");
primaryConstructorBefore.GetFullName();

PrimaryConstructor primaryConstructorAfter = new("x", "y");
primaryConstructorAfter.GetFullName();

PrimaryConstructorWithProperties primaryConstructorWithProperties = new("X", 18);
primaryConstructorWithProperties.Name = "Changed";
primaryConstructorWithProperties.Age = 30;
primaryConstructorWithProperties.Print();

PrimaryConstructorWithPropertiesWithGet primaryConstructorWithPropertiesWithGet = new("X", 18);
//you can't set value for the get property
//instance2.Name = "Changed";
//instance2.Age = 30;
primaryConstructorWithPropertiesWithGet.Print();

#endregion

#region Record
Console.WriteLine("******************* Record examples ************************");
#region UnderstandingImmuntable
EmployeeRecord employeeRecord = new("x", "y");
// you can't change the value of the property of the record
// employeeRecord.FirstName = "New Value";

// in class you can change the value
EmployeeClass employeeClass = new("x", "y");
employeeClass.FirstName = "New Value";

#endregion

#region UnderstadingToString
// To String feature
EmployeeRecord employeeRecord1 = new("x", "y");
EmployeeClass employeeClass1 = new("x", "y");
// output of record will be like this  EmployeeRecord { FirstName = x, LastName = y }
Console.WriteLine($"To string Record: {employeeRecord1} ");
// output of the class will be like this  Net8Features.Records.EmployeeClass
Console.WriteLine($"To string Class: {employeeClass1} ");
#endregion

#region UnderstandingEquals
EmployeeRecord employeeRecord2 = new("x", "y");
EmployeeRecord employeeRecord3 = new("x", "y");

//output of record will be like true, here record will compare actual value not the address(reference)
Console.WriteLine($"Record Object are equal {Equals(employeeRecord2, employeeRecord2)}");

//output of record will be like false, here record will compare actual address(reference)
Console.WriteLine($"Record Object are equal {ReferenceEquals(employeeRecord2, employeeRecord2)}");

EmployeeClass employeeClass2 = new("x", "y");
EmployeeClass employeeClass3 = new("x", "y");

//output of class will be false, here class will compare actual reference(address) not the value
Console.WriteLine($"Class Object are equal {Equals(employeeClass2, employeeClass3)}");

//output of record will be like false, here record will compare actual address(reference)
Console.WriteLine($"Class Object are equal {ReferenceEquals(employeeClass2, employeeClass3)}");
#endregion

#region Deconstruct
Console.WriteLine("***************Deconstruct****************");
/********************************* deconstruct supported by default in Record **********/
EmployeeRecord employeeRecord4 = new("x", "y");
var (firstName, lastName) = employeeRecord4;
Console.WriteLine($"value of the records {firstName} {lastName}");

/********************************* deconstruct not supported by default in Record, we have written method for that see it the employee class **********/
EmployeeClass employeeClass4 = new("x", "y");
var (firstNameclass, lastNameClass) = employeeClass4;
Console.WriteLine($"value of the class {firstNameclass} {lastNameClass}");

#endregion

#region RecordWithPropAndMethods

Console.WriteLine("*************RecordWithPropAndMethods************");
EmployeeRecordWithPropAndMethods employeeRecordWithPropAndMethods = 
    new EmployeeRecordWithPropAndMethods("FirstName", "LastName");

Console.WriteLine($"Value of FirstName: {employeeRecordWithPropAndMethods.FirstName}");
Console.WriteLine($"Value of FullName {employeeRecordWithPropAndMethods.FullName()}");
#endregion

#region RecordWithInheritance
TemporaryEmployeeRecord temporaryEmployeeRecord = new(1, "Ramadoss", "E");
Console.WriteLine($"temp {temporaryEmployeeRecord}");

TemporaryEmployeeRecordWithPropAndMethods temporaryEmployeeRecordWithPropAndMethods = new(1, "Ramadoss", "E");
Console.WriteLine($"FullName is : {temporaryEmployeeRecordWithPropAndMethods.FullName()}");
#endregion

#endregion