using ManageEmployees.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ManageEmployees.dbContexts
{
	public class ManageEmployeesContext : DbContext
	{
		public DbSet<Employee> Employees { get; set; }	

		public ManageEmployeesContext(DbContextOptions<ManageEmployeesContext> options) : base(options) 
		{ 
		}
	}
}
