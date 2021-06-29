using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.Models
{
    public class TeacherModel
    {
        public TeacherModel()
        {

        }
        public TeacherModel(int age, string name, DateTime birthDate, Guid id)
        {
            _id = id;
            _age = age;
            _name = name;
            _birthDate = birthDate;
        }
        public Guid _id;
        public int _age;
        public string _name;
        public DateTime _birthDate;
        public List<StudentModel> _students;
    }
}
