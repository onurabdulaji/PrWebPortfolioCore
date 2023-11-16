using EntityLayer.Enum;
using EntityLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Models
{
    public class About : IEntity
    {
        public About()
        {
            InsertedDate = DateTime.Now;
            Status = DataStatus.Inserted;
        }
        public int AboutID { get; set; }
        public string? AboutTitle { get; set; }
        public string? AboutImage { get; set; }
        public string? AboutCV { get; set; }
        public string? AboutDesc1 { get; set; }
        public string? AboutDesc2 { get; set; }
        public string? AboutDesc3 { get; set; }
        public string? AboutDesc4 { get; set; }
        public bool AboutStatus { get; set; }
        public DateTime InsertedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DataStatus Status { get; set; }
    }
}
