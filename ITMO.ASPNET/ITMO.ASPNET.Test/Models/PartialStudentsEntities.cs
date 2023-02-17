using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITMO.ASPNET.Test.Models
{
    public partial class StudentsEntities
    {
        public int GetSum()
        {
            int sum = 0;

            foreach (var student in Students)
            {                
                sum = sum + student.Score.ScoreValue;                
            }

            return sum;
        }

        public IEnumerable<Student> GetBestStudents()
        {
            IEnumerable<Student> bestStudents =
                (from student in Students
                orderby student.Score.ScoreValue descending
                select student).Take(5);

            return bestStudents;                
        }

        public IEnumerable<Student> GetWorseStudents()
        {
            IEnumerable<Student> worseStudents =
                (from student in Students
                 orderby student.Score.ScoreValue ascending
                 select student).Take(5);

            return worseStudents;
        }
    }
}