using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class AnonymousHint
    {
        public int HintId { get; set; }

        public string HintType { get; set; }
        public DateTime HintDate { get; set; }
        public string Comment { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}