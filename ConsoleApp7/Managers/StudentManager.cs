using ConsoleApp7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.Managers
{
    public class StudentManager
    {
        public List<StudentModel> GetStudents(int count)
        {
            List<StudentModel> students = new List<StudentModel>(count);
            Random rnd = new Random();
            for (int i = 0; i < count; i++)
            {
                var student = new StudentModel(rnd.Next(16, 80), $"st-{i + 1}", DateTime.Now.Date, Guid.NewGuid());
                students.Add(student);
            }
            return students;
        }
    }
}
