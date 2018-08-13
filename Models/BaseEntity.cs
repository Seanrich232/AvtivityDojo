using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DojoActivity.Models
{
    public class BaseEntity
    {   
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}