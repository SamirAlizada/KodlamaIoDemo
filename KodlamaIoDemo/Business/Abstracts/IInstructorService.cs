using KodlamaIoDemo.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoDemo.Business.Abstracts;
public interface IInstructorService
{
    List<Instructor> GetAll();
    Instructor GetById(int id);
    void Add(Instructor instructor);
    void Update(Instructor instructor);
    void Delete(int id);
}
