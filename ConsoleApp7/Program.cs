using ConsoleApp7.Managers;
using ConsoleApp7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {

            StudentManager studentManager = new StudentManager();
            List<StudentModel> students = studentManager.GetStudents(63);
            TeacherManager teacherManager = new TeacherManager();
            List<TeacherModel> teachers = teacherManager.GetTeachers(4);
            UniversityManager universityManager = new UniversityManager();
            List<TeacherModel> swappedTeachers = universityManager
                                             .SwapFromTeacherToStudent(teachers, students);
            Console.WriteLine("students");
            for (int i = 0; i < teachers.Count; i++)
            {
                Console.WriteLine("Teacher**************************************");
                Console.WriteLine($"id - {teachers[i]._id} age - {teachers[i]._age} name - {teachers[i]._name} bd - {teachers[i]._birthDate}");
                Console.WriteLine("*********************************************");
                for (int j = 0; j < teachers[i]._students.Capacity; j++)
                {
                    Console.WriteLine($"id - {teachers[i]._students[j]._id} age - {teachers[i]._students[j]._age} name - {teachers[i]._students[j]._name} bd - {teachers[i]._students[j]._birthDate}");

                }
            }

            List<StudentModel> swappedStudens = universityManager
                                   .SwapFromStudentToTeacher(swappedTeachers, students);
            for (int i = 0; i < swappedStudens.Count; i++)
            {
                Console.WriteLine("Student**************************************");
                Console.WriteLine($"id - {swappedStudens[i]._id} age - {swappedStudens[i]._age} name - {swappedStudens[i]._name} bd - {swappedStudens[i]._birthDate}");
                Console.WriteLine("Teacher**************************************");
                Console.WriteLine($"id - {swappedStudens[i]._teacher._id} age - {swappedStudens[i]._teacher._age} name - {swappedStudens[i]._teacher._name} bd - {swappedStudens[i]._teacher._birthDate}");

            }
        }
    }
}
