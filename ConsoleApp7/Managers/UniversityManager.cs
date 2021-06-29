using ConsoleApp7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.Managers
{
    public class UniversityManager
    {
        public List<TeacherModel> SwapFromTeacherToStudent(List<TeacherModel> teachers, List<StudentModel> students)
        {
            int studentsCount = students.Count / teachers.Count;
            int lastTeacherStCount = students.Count % teachers.Count + studentsCount;
            int filledTeacherCount = teachers.Count - 1;
            for (int i = 0; i < filledTeacherCount; i++)
            {
                teachers[i]._students = new List<StudentModel>(studentsCount);
                for (int j = 0; j < studentsCount; j++)
                {
                    var student = students[studentsCount * i + j];
                    teachers[i]._students.Add(student);
                }
            }
            
            teachers[filledTeacherCount]._students = new List<StudentModel>(lastTeacherStCount);

            for (int i = 0; i < lastTeacherStCount; i++)
            {
                var student = students[studentsCount * filledTeacherCount + i];
                teachers[filledTeacherCount]._students.Add(student);
            }
            return teachers;
        }
        public List<StudentModel> SwapFromStudentToTeacher(List<TeacherModel> teachers, List<StudentModel> students)
        {
            for (int i = 0; i < students.Count; i++)
            {
                Guid curStudentId = students[i]._id;
                for (int j = 0; j < teachers.Count; j++)
                {
                    for (int k = 0; k < teachers[j]._students.Count; k++)
                    {
                        if (curStudentId == teachers[j]._students[k]._id)
                        {
                            students[i]._teacher = teachers[j];
                        }
                    }
                }
            }
            return students;
        }
    }
}
