using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3.BLL.DTOs.DepartmentDtos
{
    public class DepartmentDetailsDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string? Description { get; set; }
        public DateOnly DateOfCreation { get; set; }
        public int CreatedBy { get; set; }
        public DateOnly LastModifiedOn { get; set; }
        public int LastModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
    }
}
