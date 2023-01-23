using System.Data;
using System.Data.SqlClient;


namespace WebApplication6.Models
{
    public class PersonDB
    {
            public List<Person> GetPersons()
            {
                string cs = "Data Source=ABJIMA-ISHANSI; Initial Catalog=ado_db;Integrated Security=true;";
            SqlConnection con = new SqlConnection(cs);

            List<Person> PersonList = new List<Person>();

                

                SqlCommand cmd = new SqlCommand("GetPersons", con);

                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Person Person = new Person();

                    Person.PersonID = Convert.ToInt32(dr.GetValue(0).ToString());

                    Person.FirstName = dr.GetValue(1).ToString();

                    Person.LastName = dr.GetValue(2).ToString();

                    Person.Address = dr.GetValue(3).ToString();

                    Person.City = dr.GetValue(4).ToString();

                    PersonList.Add(Person);

                }

                con.Close();



                return PersonList;


            }


        }

    }

