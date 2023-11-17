using EntityLayer.Enum;
using EntityLayer.Interfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Models
{
    public class AppUser : IdentityUser<int>, IEntity
    {
        public AppUser()
        {
            InsertedDate = DateTime.Now;
            Status = DataStatus.Inserted;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime InsertedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DataStatus Status { get; set; }
    }
}
