using System;
using Demo.BussinessLogic.DTOs;
using Demo.BussinessLogic.Factories;
using Demo.DataAccess.Models;
using Demo.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Demo.BussinessLogic.Services
{
    internal class DepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentService(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        // Get all departments 
        public IEnumerable<DepartmentDto> GetAllDepartments()
        {
            var departments = _departmentRepository.GetAll();

            var departmentsToReturn = departments.Select(d => d.ToDepartmentDto());

            return departmentsToReturn;
        }

        // Get  departments  by id 
        public DepartmentDetailsDto? GetDepatmentById(int id)
        {
            var department = _departmentRepository.GetById(id);

            // manual mapping
            //return department == null ? null : new DepartmentDetailsDto()
            //{
            //    DeptId = department.Id,
            //    Name = department.Name,
            //    Code = department.Code,
            //    Description = department.Description,
            //    DateOfCreation = department.CreatedOn,
            //    CreatedBy = department.CreatedBy,
            //    LastModifiedBy = department.LastModifiedBy,
            //    IsDeleted = department.IsDeleted
            //};




            return department is null ? null : department.ToDepartmentDetailsDto();


            // types of mapping 
            // 1) manual mapping 
            //2) auto mapper 
            //Constructor mapping
            //enxtention methods
        }



        public int? CreateDepartment(CreateDepartmentDto createDepartmentDto)
        {
            var res = _departmentRepository.Add(createDepartmentDto.ToEntity());
            return res;

        }

        public int? UpdateDepartment(CreateDepartmentDto createDepartmentDto)
        {
            var res = _departmentRepository.    Update(createDepartmentDto.ToEntity());
            return res;

        }
    }

}
