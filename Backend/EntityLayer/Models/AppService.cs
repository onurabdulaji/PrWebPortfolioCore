using EntityLayer.Enum;
using EntityLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Models
{
    public class AppService : IEntity
    {
        public AppService()
        {
            InsertedDate = DateTime.Now;
            Status = DataStatus.Inserted;
        }
        public int ServiceID { get; set; }
        public string? ServiceTitle { get; set; }
        public string? ServiceSubTitle { get; set; }
        public string? ServiceDesc1 { get; set; }
        public string? ServiceDesc2 { get; set; }
        public string? ServiceDesc3 { get; set; }
        public string? ServiceDesc4 { get; set; }
        public string? ServiceDesc5 { get; set; }
        public string? ServiceLogo { get; set; }
        public bool ServiceStatus { get; set; }
        public DateTime InsertedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DataStatus Status { get; set; }
    }
}
