using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete;

public class InstructorDal : IInstructorDal
{
    private List<Instructor> _instructors;

    public InstructorDal()
    {

        _instructors = new List<Instructor>
            {
                new Instructor { Id = 1, FirstName = "Engin", LastName = "Demiroğ" },
                new Instructor { Id = 2, FirstName = "Emre", LastName = "Altunbilek" },
                new Instructor { Id = 3, FirstName = "Atil", LastName = "Samancıoğlu" },
                new Instructor { Id = 4, FirstName = "Murat", LastName = "Yücedağ" }
            };
    }
    public void Add(Instructor instructor)
    {
        _instructors.Add(instructor);
    }

    public void Delete(int id)
    {
        Instructor instructorToDelete = _instructors.FirstOrDefault(i => i.Id == id);
        if (instructorToDelete != null)
        {
            _instructors.Remove(instructorToDelete);
        }
    }

    public List<Instructor> GetAll()
    {
        foreach (var instructor in _instructors)
        {
            Console.WriteLine($"Id: {instructor.Id}, Name: {instructor.FirstName}, LastName: {instructor.LastName}");
        }

        return _instructors;
    }

    public Instructor GetById(int id)
    {
        return _instructors.FirstOrDefault(i => i.Id == id);
    }

    public void Update(Instructor instructor)
    {
        Instructor instructorToUpdate = _instructors.FirstOrDefault(i => i.Id == instructor.Id);
        if (instructorToUpdate != null)
        {
            instructorToUpdate.FirstName = instructor.FirstName;
            instructorToUpdate.LastName = instructor.LastName;
        }
    }
}
