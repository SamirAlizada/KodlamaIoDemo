using KodlamaIoDemo.Business.Abstracts;
using KodlamaIoDemo.DataAccess.Abstracts;
using KodlamaIoDemo.Entities.Concretes;

namespace KodlamaIoDemo.Business.Concretes;
public class CategoryManager : ICategoryService
{
    private readonly ICategoryDal _categoryDal;

    public CategoryManager(ICategoryDal categoryDal)
    {
        _categoryDal = categoryDal;
    }

    public void Add(Category category)
    {
        _categoryDal.Add(category);
    }

    public void Delete(int id)
    {
        _categoryDal.Delete(id);
    }

    public List<Category> GetAll()
    {
        return _categoryDal.GetAll();
    }

    public Category GetById(int id)
    {
        return _categoryDal.GetById(id);
    }

    public void Update(Category category)
    {
        _categoryDal.Update(category);
    }
}