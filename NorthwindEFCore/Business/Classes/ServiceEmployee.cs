using DataAccess.Interfaces;
using Entities.Context;
using Entities.Models;

namespace Business.Classes;

public class ServiceEmployee : ServiceRepo<Employee>, IServiceEmployee
{
	public ServiceEmployee(Entities.Context.NorthwindContext p_context) 
							: base(p_context) { }
}
