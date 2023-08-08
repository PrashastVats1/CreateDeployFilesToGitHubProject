using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppStoringDataUsingOOPs
{
    public class SchoolManager
    {
        private List<Student> students = new List<Student>();
        private List<Teacher> teachers = new List<Teacher>();
        private List<Subject> subjects = new List<Subject>();
        public List<Teacher> Teachers => teachers;
        public void AddStudent(Student student)
        {
            students.Add(student);
        }
        public void AddTeacher(Teacher teacher)
        {
            teachers.Add(teacher);
        }
        public void AddSubject(Subject subject)
        {
            subjects.Add(subject);
        }
        public void DisplayStudentsInClass(string classAndSection)
        {
            Console.WriteLine($"Students in Class {classAndSection}");
            foreach(var student in students)
            {
                if (student.ClassAndSection == classAndSection)
                {
                    Console.WriteLine($"- {student.Name}");
                }
            }
        }
        public void DisplaySubjectsTaughtByTeacher(string teacherName)
        {
            Console.WriteLine($"Subjects taught by {teacherName}: ");
            foreach(var subject in subjects)
            {
                if(subject.Teacher.Name== teacherName)
                {
                    Console.WriteLine($"- {subject.Name} (Code: {subject.SubjectCode}");
                }
            }
        }
    }
}
