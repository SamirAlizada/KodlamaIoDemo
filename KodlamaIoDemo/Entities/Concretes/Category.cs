using KodlamaIoDemo.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoDemo.Entities.Concretes;

public class Category : IEntity
{
    public Category(int id, string name)
    {
        Id = id;
        Name = name;
    }
    public Category()
    {

    }
    public int Id { get; set; }
    public string Name { get; set; }
}
