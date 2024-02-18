using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class CourseDal : ICourseDal
    {
        private List<Course> _courses;

        public CourseDal()
        {

            _courses = new List<Course>
            {
                new Course { Id = 1, CourseName = "C# Course", Description = "C# Zero to Hero", Price = 9.99, CategoryId = 1, InstructorId = 1 },
                new Course { Id = 2, CourseName = "Dart Course", Description = "Dart Advanced Level", Price = 11.99, CategoryId = 2, InstructorId = 2 },
                new Course { Id = 3, CourseName = "Python Course", Description = "Python Beginner Level", Price = 5.99, CategoryId = 3, InstructorId = 3 },
                new Course { Id = 4, CourseName = "Javascript Course", Description = "Javascript Intermediate Level", Price = 7.99, CategoryId = 4, InstructorId = 4 }
            };
        }
        public void Add(Course course)
        {
            _courses.Add(course);
        }

        public void Delete(int id)
        {
            Course courseToDelete = _courses.FirstOrDefault(c => c.Id == id);
            if (courseToDelete != null)
            {
                _courses.Remove(courseToDelete);
            }
        }

        public List<Course> GetAll()
        {
            foreach (var course in _courses)
            {
                Console.WriteLine($"Course Name: {course.CourseName}, Description: {course.Description}, Price: {course.Price}");
            }

            return _courses;
        }

        public Course GetById(int id)
        {
            return _courses.FirstOrDefault(c => c.Id == id);
        }

        public void Update(Course course)
        {

            Course courseToUpdate = _courses.FirstOrDefault(c => c.Id == course.Id);
            if (courseToUpdate != null)
            {
                courseToUpdate.CourseName = course.CourseName;
                courseToUpdate.Description = course.Description;
                courseToUpdate.Price = course.Price;
                courseToUpdate.CategoryId = course.CategoryId;
                courseToUpdate.InstructorId = course.InstructorId;
            }
        }
    }
}
