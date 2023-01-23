using Microsoft.AspNetCore.Mvc;
using WebApplication6.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]

    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        [Route("getall")]
        public List<Person> GetPersons()
        {
            PersonDB db = new PersonDB();

            List<Person> obj = db.GetPersons();

            return obj;
        }


        [HttpDelete]
        [Route("delete")]
        public bool DeletePerson(Person person, int PersonID)
        {
            PersonDB db = new PersonDB();

            List<Person> obj2 = db.GetPersons();

            var PersonToBeDeleted = (from s in obj2
                                     where s.PersonID == PersonID
                                     select s).FirstOrDefault();
            obj2.Remove(PersonToBeDeleted);

            return true;

        }


        [HttpPut]
        [Route("put")]

        public bool UpdatePerson(Person person, int PersonID)
        {
            PersonDB db = new PersonDB();
            List<Person> obj3 = db.GetPersons();

            for (int i = 0; i < obj3.Count; i++)
            {
                if (obj3[i].PersonID == PersonID)
                {
                    obj3[i].PersonID = PersonID;

                    obj3[i].FirstName = person.FirstName;

                    obj3[i].LastName = person.LastName;

                    obj3[i].Address = person.Address;

                    obj3[i].City = person.City;

                }

                else
                {
                    return false;
                }

            }

            return true;
        }



        [HttpGet]

        [Route("get")]

        public Person GetPersonByID(Person person,int PersonID)
        {
            PersonDB db = new PersonDB();

            Person personselected = new Person();

            List<Person> obj4 = db.GetPersons();

            personselected = (from s in obj4
                         where s.PersonID == PersonID
                         select s).FirstOrDefault();

            return personselected;

            
        }


        [HttpPost]
        [Route("post")]

        public bool CreatePerson(Person person)
        {
            PersonDB db = new PersonDB();

            List<Person> obj5 = db.GetPersons();

            obj5.Add(person);

            return true;
        }


    }
}
