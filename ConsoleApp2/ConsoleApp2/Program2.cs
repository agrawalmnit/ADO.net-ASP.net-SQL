//using System;

//using AutoMapper;


//namespace ConsoleApp2;

//class Program2

//{

//    static void Main(string[] args)

//    {

//        var config = new MapperConfiguration
//
//        (cfg =>

//        cfg.CreateMap<Employee, Employee2>());



//        Employee emp = new Employee

//        {

//            Name = "Automapper",

//            Salary = "50000",

//            Address = "Noida",

//            Department = "Manager"

//        };
//        var mapper = new Mapper(config);

//        var emp2 = mapper.Map<Employee2>(emp);


//        Console.WriteLine("Name:" + emp2.Name + "Salary:" + emp2.Salary + "Address:" + emp2.Address + "Deparment :" + emp2.Department);

//        Console.ReadLine();


//    }
//}

//public class Employee

//{

//    public string Name { get; set; }

//    public string Salary { get; set; }

//    public string Address { get; set; }

//    public string Department { get; set; }
//}

//public class Employee2

//{

//    public string FirstName { get; set; }

//    public string FirstSalary { get; set; }

//    public string Address { get; set; }

//    public string Department { get; set; }

//}


