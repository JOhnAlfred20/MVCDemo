using System;
using Demo.DataAccess.Models;

namespace Demo.BussinessLogic.DTOs
{
    public class DepartmentDetailsDto
    {
        public DepartmentDetailsDto()
        {
        }

        public DepartmentDetailsDto(Department department)
        {
            Name = department.Name;
            Code = department.Code;
            DeptId = department.Id;
            Description = department.Description;
            DateOfCreation = department.CreatedOn;
            CreatedBy = department.CreatedBy;
            //LastModifiedBy = department.LastModifiedBy;
            //IsDeleted = department.IsDeleted;
        }

        public required string Name { get; set; }
        public string Code { get; set; } = null!;
        public int DeptId { get; set; }
        public string? Description { get; set; }
        public DateTime? DateOfCreation { get; set; }
        public int CreatedBy { get; set; }
        public int LastModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
    }
}
