using KodlamaIoDemo.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoDemo.DataAccess.Abstracts;
public interface ICourseDal
{
    List<Course> GetAll();
    Course GetById(int id);
    void Add(Course course);
    void Update(Course course);
    void Delete(int id);
}
