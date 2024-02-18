﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstarct
{
    public interface ICourseService
    {
        List<Course> GetAll();
        Course GetById(int id);
        void Add(Course course);
        void Update(Course course);
        void Delete(int id);
    }
}
