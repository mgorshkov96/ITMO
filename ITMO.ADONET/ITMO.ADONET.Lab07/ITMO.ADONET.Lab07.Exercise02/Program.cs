using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.ADONET.Lab07.Exercise02
{
    public class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Student> studentQuery =
                from student in students
                where student.Scores[0] > 90 && student.Scores[3] < 80
                orderby student.Scores[0] descending
                select student;                

            foreach (Student student in studentQuery)
            {
                Console.WriteLine("{0}, {1} {2}", student.Last, student.First, student.Scores[0]);
            }

            var studentQuery2 =
                from student in students
                group student by student.Last[0];

            foreach (var studentGroup in studentQuery2)
            {
                Console.WriteLine(studentGroup.Key);
                foreach (Student student in studentGroup)
                {
                    Console.WriteLine(" {0}, {1}", student.Last, student.First);
                }
            }
        }

        public class Student
        {
            public string First { get; set; }
            public string Last { get; set; }
            public int ID { get; set; }

            public List<int> Scores;
        }

        static List<Student> students = new List<Student>
        {
            new Student
            {
                First = "Svetlana",
                Last = "Omelchenko",
                ID = 111,
                Scores = new List<int>{97, 92, 81, 60}
            },
            new Student
            {
                First = "Claire",
                Last = "O'Donnell",
                ID = 112,
                Scores = new List<int>{75, 84, 91, 39}
            },
            new Student
            {
                First = "Ivan",
                Last = "Ivanov",
                ID = 113,
                Scores = new List<int>{95, 84, 99, 10}
            },
            new Student
            {
                First = "Vladimir",
                Last = "Pupkin",
                ID = 114,
                Scores = new List<int>{12, 34, 21, 17}
            },
        };
    }
}
