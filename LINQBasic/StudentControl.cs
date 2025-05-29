using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQBasic
{
    internal class StudentControl
    {
        public static double student_avg(Student student)
        {
            return student.Grades.Average();
        }

        public static List<Student> student_cut_avg(List<Student> list, double targetAvg)
        {
            return list.Where(stud => student_avg(stud) >= targetAvg).ToList();
        }

        public static List<Student> student_sorted(List<Student> students)
        {
            return students.OrderBy(stud=> stud.LastName).ToList();
        }

        public static List<Student> student_has_grade(List<Student> students, int grade)
        {
            return students.Where(stud=> stud.Grades.Any(gr => grade == gr )).ToList();
        }

        public static Dictionary<string, double> sudent_avg_by_group(List<Student> students)
        {
            Dictionary<string, double> dict = new Dictionary<string, double>();
            
            foreach(var group in students.GroupBy(stud=> stud.Group))
            {
                int avg = 0;
                foreach (var student in group)
                {
                    avg += student.Grades.Sum();
                }
                avg = avg / students.Count();
                dict.Add(group.Key, avg);
            }
            return dict;
        }


        public static List<string> that_one(List<Student> students, string targetGroup, int targetGrade)
        {
            return students
                .Where(stud => stud.Group == targetGroup)
                .Where(stud => student_avg(stud) >= targetGrade)
                .OrderBy(stud => stud.FirstName)
                .Select(stud => stud.LastName).ToList();s

        }
    }
}
