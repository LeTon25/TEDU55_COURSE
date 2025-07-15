using PrototypeSample;

var serviceConfiguration = new ServiceConfiguration();
serviceConfiguration.FileStorageUrl = "empty";
serviceConfiguration.OperationSystem = "os";

var clonedServiceConfiguration = serviceConfiguration.Clone();

Console.WriteLine(clonedServiceConfiguration.PrintDetail());

Employee developer = new Employee();
developer.FirstName = "Toan";
developer.LastName = "Le";

var clonedDeveloper = (Employee)developer.Clone();
Console.WriteLine(clonedDeveloper.GetDetails());