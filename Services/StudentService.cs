using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OData6Demo.Api.Models;

namespace OData6Demo.Api.Services
{
    public class StudentService : IStudentService
    {
        public IQueryable<Student> RetrieveAllStudents()
        {
            return new List<Student>
            {
                new Student
                {
                    Id = 12,
                    SubjectName = "Maths",
                    Name = "Vishu Goli",
                    Score = 56
                },
                new Student
                {
                    Id = 12,
                    SubjectName = "Science",
                    Name = "Vishu Goli",
                    Score = 78
                },
                new Student
                {
                    Id = 12,
                    SubjectName = "Hindi",
                    Name = "Vishu Goli",
                    Score = 99
                },
                new Student
                {
                    Id = 13,
                    SubjectName = "Maths",
                    Name = "Vicky hemnani",
                    Score = 98
                },
                new Student
                {
                    Id = 13,
                    SubjectName = "Science",
                    Name = "Vicky hemnani",
                    Score = 95
                },
                new Student
                {
                    Id = 16,
                    Name = "Kailu Hu",
                    Score = 160
                },
                new Student
                {
                    Id = 17,
                    Name = "Sean Hobbs",
                    Score = 170
                }
            }.AsQueryable(); ;
        }
    }
}
