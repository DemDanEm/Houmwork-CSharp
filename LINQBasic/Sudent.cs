using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQBasic
{
    internal class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Group { get; set; }
        public int[] Grades { get; set; }
        public Student(string firstName, string lastName, string group, int[] grades)
        {
            FirstName = firstName;
            LastName = lastName;
            Group = group;
            Grades = grades;
        }

        public static List<Student> fish()
        {
            List<Student> list = new List<Student>();
            list.Add(new Student("Dave", "The", "Gobbers", new int[] { 2, 4, 5, 5, 3 }));
            list.Add(new Student("Wave", "Move", "Wavers", new int[] { 3, 3, 3, 3 }));
            list.Add(new Student("Cave", "Diver", "Gobbers", new int[] { 2, 4, 5, 5, 3 }));
            list.Add(new Student("Save", "Tail", "Critters", new int[] { 1, 1, 1 , 1 }));
            list.Add(new Student("Knave", "Knight", "Gobbers", new int[] { 2, 4, 5, 5, 3 }));
            list.Add(new Student("Pave", "Walk", "Critters", new int[] { 2, 3, 4, 4, 3, 2 }));

            return list;
        }

    }

}
