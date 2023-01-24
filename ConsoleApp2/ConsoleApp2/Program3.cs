//using AutoMapper;

//using ServiceStack.Text;

//using System;

//using System.Collections.Generic;

//using System.Linq;

//using System.Net.Sockets;

//using System.Reflection.Metadata.Ecma335;

//using System.Text;

//using System.Threading.Tasks;

//namespace ConsoleApp2

//{
//    class Program3

//    {
//        static Mapper InitializeAutomapper()

//        {
//            var config = new MapperConfiguration
//
//            (
//
//            cfg => {

//                cfg.CreateMap<Address, Address2>();
//
//                cfg.CreateMap<Student, Student2>()

//                .ForMember(dest=> dest.address2,
//
//                act=> act.MapFrom(src=> src.Address));

//            });



            

//            var mapper = new Mapper(config);

//            return mapper;

//        }
        
//        static void Main(string[] args)

//        {
            

//            Address studentAddress = new Address()

//            {
//                City = "Jaipur",

//                State = "Rajasthan",

//                Country = "India"

//            };

//            Student student = new Student()

//            {

//                Name = "Ishansi Agrawal",

//                Salary = "20000",

//                Department = "Manager",

//                Address = studentAddress

//            };


//            var mapper2 = InitializeAutomapper();

//            var student2 = mapper2.Map<Student2>(student);

//            Console.WriteLine("Name: " + student2.Name + "Salary : " + student2.Salary + "Department :" +
//
//            student2.Department);

//            Console.WriteLine("City:" + student2.address2.City + "State: " + student2.address2.State +
//
//            "Country: " + student2.address2.Country);



//            Console.ReadLine();
//        }

           
//        }
    
//public class Student

//{

//    public string Name { get; set; }

//    public string Salary { get; set; }
    
//    public string Department { get; set; }

//    public Address Address { get; set; }

//}

//public class Student2

//{

//    public string Name { get; set; }

//    public string Salary { get; set; }

//    public string Department { get; set; }

//    public Address2 address2 { get; set; }

//}

//public class Address

//{
//    public string City { get; set; }

//    public string State { get; set; }

//    public string Country { get; set; }

//}

//public class Address2

//{

//    public string City { get; set; }

//    public string State { get; set; }

//    public string Country { get; set; }

//}

//}
