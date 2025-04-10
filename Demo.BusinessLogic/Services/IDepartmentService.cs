﻿using Demo.BusinessLogic.DTOs;
using Demo.DataAccess.Models;

namespace Demo.BusinessLogic.Services
{
    public interface IDepartmentService
    {
        int CreateDepartment(CreateDepartmentDto createDepartmentDto);
        IEnumerable<DepartmentDto> GetAllDepartments();
        DepartmentDetailsDto? GetDepartmentById(int id);
        int? UpdateDepartment(UpdateDepartmentDto updateDepartmentDto);

    }
}