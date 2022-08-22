using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitis.Concrete
{
    public class Company: IEntity
    {
        public int Id { get; set; } 
        public string Name { get; set; } 
        public string Address { get; set; } 
        public string TexDepartment { get; set; } 
        public string? TexIdNumber { get; set; } 
        public string? IdentityNumber { get; set; } 
        public DateTime AddedAt { get; set; } 
        public bool IsActive { get; set; } 
    }
}
