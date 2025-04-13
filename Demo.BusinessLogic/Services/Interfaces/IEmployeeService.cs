﻿using Demo.BusinessLogic.DTOs.DepartmentDtos;
using Demo.BusinessLogic.DTOs.EmployeeDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BusinessLogic.Services.Interfaces
{
    public interface IEmployeeService
    {
        IEnumerable<GetEmployeeDto> GetAllEmployees();
        EmployeeDetailsDto? GetEmployeeById(int id);

        int CreateEmployee(CreateEmployeeDto createEmployeeDto);
        int? UpdateEmployee(UpdateEmployeeDto updateEmployeeDto);


        public bool DeleteEmployee(int id);

    }

}