using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class Company
    {
        
        public int CompanyId { get; set; }

        public string CompanyName { get; set; }
        public string RegisterCode { get; set; }
        public string Address { get; set; }
    }
}
