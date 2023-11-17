﻿using EntityLayer.Enum;
using EntityLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Models
{
    public class AppMyClient : IEntity
    {
        public AppMyClient()
        {
            InsertedDate = DateTime.Now;
            Status = DataStatus.Inserted;
        }
        public int MyClientID { get; set; }
        public string MyClientImage { get; set; }
        public bool MyClientStatus { get; set; }
        public DateTime InsertedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DataStatus Status { get; set; }
    }
}
