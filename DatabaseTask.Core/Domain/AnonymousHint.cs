using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class AnonymousHint
    {
        public int HintId { get; set; } // PK

        public string HintType { get; set; }
        public DateTime HintDate { get; set; }
        public string Comment { get; set; }

        // FK Company
        public int CompanyId { get; set; } 
        public Company Company { get; set; }
    }
}