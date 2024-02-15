using KodlamaIoDemo.Business.Concretes;
using KodlamaIoDemo.DataAccess.Concretes;
using KodlamaIoDemo.Entities.Concretes;

Course course = new Course();
course.Name = "Java";
course.Price = 0;
course.Id = 3;

CourseManager courseManager = new CourseManager(new CourseDal());
courseManager.Add(course);