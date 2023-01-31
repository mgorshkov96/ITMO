using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.ADONET.Lab07.Linq_Student
{
    public class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Student> studentQuery =
                from student in students
                where student.Scores[0] > 90
                select student;

            foreach (Student student in studentQuery)
            {
                Console.WriteLine("{0}, {1}", student.Last, student.First);
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
                Scores = new List<int>{55, 84, 99, 10}
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
