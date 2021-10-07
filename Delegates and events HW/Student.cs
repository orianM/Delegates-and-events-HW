using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_and_events_HW
{
    class Student
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Grade { get; set; }
        public int AmountToPay { get; set; }

        public Student(string id, string firstName, string lastName, int age, int grade, int amountToPay)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Grade = grade;
            AmountToPay = amountToPay;
        }
    }
}
