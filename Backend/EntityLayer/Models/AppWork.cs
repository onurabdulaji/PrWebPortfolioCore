using EntityLayer.Enum;
using EntityLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Models
{
    public class AppWork : IEntity
    {
        public AppWork()
        {
            InsertedDate = DateTime.Now;
            Status = DataStatus.Inserted;
        }
        public int WorkID { get; set; }
        public string? WorkTitle { get; set; }
        public string? WorkPlatform { get; set; }
        public string? WorkImage { get; set; }
        public string? WorkDescription { get; set; }
        public string? WorkLinkToWeb { get; set; }
        public DateTime InsertedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DataStatus Status { get; set; }
    }
}
