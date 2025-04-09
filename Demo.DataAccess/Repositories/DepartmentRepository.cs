using System;
using Demo.DataAccess.Contexts;

namespace Demo.DataAccess.Repositories
{
    public class DepartmentRepository(AppDbContext _dbContext) : IDepartmentRepository
    {


        //public DepartmentRepository() : this()
        //    {


        //    }
        //public DepartmentRepository(AppDbContext dbContext)
        //{
        //    _dbContext = dbContext;
        //}

        //  CRUD operations:
        // get all
        public IEnumerable<Department> GetAll(bool WithTracking = false)
        {
            if (WithTracking)
            {
                return _dbContext.Departments.ToList();
            }
            else
            {
                return _dbContext.Departments.AsNoTracking().ToList();
            }
        }

        // get by id
        public Department? GetById(int id) => _dbContext.Departments.Find(id);
        // استخدام _dbContext بدلاً من dbContext





        // add
        public int Add(Department dept)
        {

            _dbContext.Departments.Add(dept);
            return _dbContext.SaveChanges();
        }


        // edit
        public int Update(Department dept)
        {

            _dbContext.Departments.Update(dept);
            return _dbContext.SaveChanges();
        }

        // delete
        public int Remove(Department dept)
        {

            _dbContext.Departments.Remove(dept);
            return _dbContext.SaveChanges();
        }


    }
}
