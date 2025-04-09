using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.BussinessLogic.DTOs;
using Demo.DataAccess.Models;

namespace Demo.BussinessLogic.Factories
{
    public  static class DepartmentFactory
    {

        // mappimg extension method 


        
        public static DepartmentDto ToDepartmentDto (this Department department)
        {
          return   new DepartmentDto()
            {
                DeptId = department.Id,
                Name = department.Name,
                Code = department.Code,
                Description = department.Description,
                DateOfCreation = department.CreatedOn,
            };



        }





        public static DepartmentDetailsDto ToDepartmentDetailsDto(this Department department)
        {
            return new DepartmentDetailsDto()
            {
                DeptId = department.Id,
                Name = department.Name,
                Code = department.Code,
                Description = department.Description,
                DateOfCreation = department.CreatedOn,
                CreatedBy = department.CreatedBy,
                LastModifiedBy = department.LastModifiedBy,
                IsDeleted = department.IsDeleted
            };



        }

        public static Department ToEntity(this CreateDepartmentDto dto)
        {
            return new Department()
            {
                Name = dto.Name,
                Code = dto.Code,
                Description = dto.Description,
                CreatedOn = dto.DateOfCreation
            };
        }

    }
}
