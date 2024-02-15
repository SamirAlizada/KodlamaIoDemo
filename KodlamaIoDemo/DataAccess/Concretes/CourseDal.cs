﻿using KodlamaIoDemo.DataAccess.Abstracts;
using KodlamaIoDemo.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoDemo.DataAccess.Concretes;
public class CourseDal : ICourseDal
{
    List<Course> courses;

    public CourseDal()
    {
        courses = new List<Course>();
        courses.Add(new Course(1, 1, "C#", 0));
        courses.Add(new Course(2, 1, "Java", 0));
        courses.Add(new Course(3, 1, "Python", 0));
    }
    public void Add(Course course)
    {
        courses.Add(course);
    }

    public void Delete(int id)
    {
        courses.Remove(GetById(id));
    }

    public List<Course> GetAll()
    {
        return courses;
    }

    public Course GetById(int id)
    {
        foreach (var course in courses)
        {
            if (course.Id == id)
            {
                return course;
            }
        }
        return null;
    }

    public void Update(Course course)
    {
        var updateCourse = GetById(course.Id);
        updateCourse.CategoryId = course.CategoryId;
        updateCourse.Name = course.Name;
        updateCourse.Price = course.Price;
    }
}
