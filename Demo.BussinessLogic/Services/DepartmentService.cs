using System;
using Demo.DataAccess.Repositories;

namespace Demo.BussinessLogic.Services
{
    internal class DepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;

        // Constructor لتلقي الـ Dependency (وهو هنا IDepartmentRepository)
        public DepartmentService(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }
    }
}
