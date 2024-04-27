namespace ManageEmployees.Data.Models
{
    public class Employee
    {
        public Guid EmployeeId { get; set; }

        public required string EmployeeName { get; set; }

        public string? Email { get; set; }

        public string? Mobile { get; set; }

        public string? DOB { get; set; }

        public string? DOJ { get; set; }






    }
}