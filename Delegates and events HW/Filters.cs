using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_and_events_HW
{
    static class Filters
    {
        public static bool ByGrade(Student student, string grade)
        {
            return student.Grade == int.Parse(grade);
        }
        public static bool ByFirstName(Student student, string firstname)
        {
            return student.FirstName == firstname;
        }
        public static bool ByLastName(Student student, string lastname)
        {
            return student.LastName == lastname;
        }
        public static bool ById(Student student, string id)
        {
            return student.Id == id;
        }
        public static bool GradeBelow50(Student student)
        {
            return (student.Grade) < 50;
        }
        public static bool SameChar(Student student)
        {
            return student.FirstName[0] == student.LastName[0];
        }
    }
}
