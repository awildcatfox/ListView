using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;

namespace ListView
{
    public class Student
    {

        public string _idNumber;
        public string _firstName;
        public string _lastName;
        public string IDNumber => _idNumber;
        public string FirstName => _firstName;
        public string LastName => _lastName;
        public Student(string firstName,string lastName)
        {


            Random rand = new Random();

            _idNumber = rand.Next(100000000, 1000000000).ToString();



            _firstName = firstName;
            _lastName = lastName;




        }










    }

}
