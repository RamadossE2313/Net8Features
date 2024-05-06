using Net8Features.PrimaryConstructor;

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
