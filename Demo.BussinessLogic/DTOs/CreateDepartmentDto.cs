using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BussinessLogic.DTOs
{
    public class CreateDepartmentDto
    {

        public required string Name { get; set; }
        public string Code { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime? DateOfCreation { get; set; }

    }
}
