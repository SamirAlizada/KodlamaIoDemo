using KodlamaIoDemo.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoDemo.Entities.Concretes;
public class Instructor : IEntity
{
    public Instructor(int id, string name)
    {
        Id = id;
        Name = name;
    }
    public Instructor()
    {

    }
    public int Id { get; set; }
    public string Name { get; set; }
}
