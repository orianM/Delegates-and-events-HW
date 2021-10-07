using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_and_events_HW
{
    class StudentList
    {
        List<Student> students = new();

        public void Add(Student student)
        {
            students.Add(student);
        }

        public void Remove(Student student)
        {
            students.Remove(student);
        }

        public List<Student> Filter(FilterDelegate filterDelegateInstance)
        {
            var filteredList = new List<Student>();
            foreach (var student in students)
            {
                if (filterDelegateInstance(student))
                    filteredList.Add(student);
            }
            return filteredList;
        }

        public void Contains()
        {

        }
    }
}
