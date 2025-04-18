﻿
namespace Demo.DataAccess.Repositories
{
    public interface IDepartmentRepository
    {
        int Add(Department department);
        IEnumerable<Department> GetAll(bool withTracking = false);
        Department GetById(int id);
        int Remove(Department department);
        int Update(Department department);
    }
}