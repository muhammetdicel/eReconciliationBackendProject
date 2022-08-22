using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Concrete
{
    public class User:IEntity
    {
        public int Id { get; set; } 
        public string Name { get; set; } 
        public string Email { get; set; } 
        public byte[] PasswordSalt { get; set; } 
        public byte[] PasswordHash { get; set; } 
        public DateTime AddedAt { get; set; } 
        public bool IsActive { get; set; } 
        public bool MailConfırm { get; set; } 
        public string MailConfırmValue { get; set; } 
        public DateTime MailConfırmDate { get; set; } 
    }
}
