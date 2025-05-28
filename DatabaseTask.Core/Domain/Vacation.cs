using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class Vacation
    {
        public int VacationId { get; set; } // PK

        // FK Employee
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public string Type { get; set; }
        public int VacationDaysTotal { get; set; }
        public string Comments { get; set; }
    }
}