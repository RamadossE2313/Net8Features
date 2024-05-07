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

#endregion
