// See https://aka.ms/new-console-template for more information
using AdapterPattern;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

Console.WriteLine("Hello, World!");

string url = "http://localhost:5002/PayRoll";

EmployeeDataReader reader = new EmployeeDataReader();

List<Employee> employees= reader.LoadEmployees();

HttpClient client = new HttpClient();
foreach (var item in employees)
{
    var request = new HttpRequestMessage(HttpMethod.Post, url);

    EmployeeAdapter employeeAdapter = new EmployeeAdapter(item);

    request.Content = new StringContent(JsonSerializer.Serialize(employeeAdapter) , Encoding.UTF8 , "application/json");

    var response = await client.SendAsync(request);

    var result =  await response.Content.ReadAsStringAsync();

    var basicSalary = decimal.Parse(result);

    Console.WriteLine($"Basic Salary of Employee {employeeAdapter.FullName} is {basicSalary}");
}

Console.ReadLine();