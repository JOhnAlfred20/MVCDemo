﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DataAccess.Models
{
    internal class BaseEntity
    {
        public int Id { get; set; } /*pk*/
        public int CreatedBy { get; set; }// user id
        public DateTime? CreatedOn { get; set; }

        public int LastModifiedBy { get; set; }// user id\

        public DateTime? LastModifiedOn { get; set; }
        public bool IsDeleted { get; set; } // soft delete 

    }
}
