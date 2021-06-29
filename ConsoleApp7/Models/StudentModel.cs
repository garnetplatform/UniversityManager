using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.Models
{
    public class StudentModel
    {
        public StudentModel()
        {

        }
        public StudentModel(int age, string name, DateTime birthDate, Guid id)
        {
            _age = age;
            _name = name;
            _birthDate = birthDate;
            _id = id;
        }
        public Guid _id;
        public int _age;
        public string _name;
        public DateTime _birthDate;
        public TeacherModel _teacher;
    }
}
