using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete;

public class CategoryDal:ICategoryDal
{
    private List<Category> _categories;

    public CategoryDal()
    {

        _categories = new List<Category>
            {
                new Category { Id = 1, CategoryName = "C#" },
                new Category { Id = 2, CategoryName = "Dart" },
                new Category { Id = 3, CategoryName = "Python" },
                new Category { Id = 4,CategoryName="Javascript"}
            };
    }

    public List<Category> GetAll()
    {
        foreach (var category in _categories)
        {
            Console.WriteLine($"Category Name: {category.CategoryName}");
        }

        return _categories;
    }

    public Category GetById(int id)
    {
        return _categories.FirstOrDefault(c => c.Id == id);
    }

    public void Add(Category category)
    {
        _categories.Add(category);
    }

    public void Update(Category category)
    {
        Category categoryToUpdate = _categories.FirstOrDefault(c => c.Id == category.Id);
        if (categoryToUpdate != null)
        {
            categoryToUpdate.CategoryName = category.CategoryName;
        }
    }

    public void Delete(int id)
    {
        Category categoryToDelete = _categories.FirstOrDefault(c => c.Id == id);
        if (categoryToDelete != null)
        {
            _categories.Remove(categoryToDelete);
        }
    }

}

