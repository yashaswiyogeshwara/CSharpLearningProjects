using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace JsonDesrializationLinq
{
    class EmployeeList 
    {
        public List<Employee> objects { get; set; } 
    }
    class Employee
    {
    public string ID{ get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Designation { get; set; }
    public string TeamId { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "ExportJson.json";
            string jsonString = File.ReadAllText(fileName);
            EmployeeList emplyees = JsonSerializer.Deserialize<EmployeeList>(jsonString);
        }
    }
}
