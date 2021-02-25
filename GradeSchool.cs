using System;
using System.Collections.Generic;
using System.Linq;

public class GradeSchool
{
    List<Student> students = new List<Student>();
    public void Add(string student, int grade)
    {
        students.Add(new Student(student, grade));
        //var newStudent = new Student
        //{
        //    Name = student,
        //    Grade = grade
        //};

    }

    public IEnumerable<string> Roster()
    {
        var studentRoster = students
            .OrderBy(x => x.Grade)
           .ThenBy(x => x.Name)
            .Select(x => x.Name);
            
        
        return studentRoster;
    }

    public IEnumerable<string> Grade(int grade)
    {
        var studentNames = students
            .Where(x => x.Grade == grade)
            .Select(x => x.Name)
            .OrderBy(x => x);
        return studentNames;

    }
}

public class Student
{
    public Student(string student, int grade)
    {
        Name = student;
        Grade = grade;
    }

    public int Grade { get; set; }
    public string Name { get; set; }

}