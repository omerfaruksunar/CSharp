using DataAccess.Interfaces;
using Entities.Context;
using Entities.Models;

namespace Business.Classes;

public class ServiceCustomer : ServiceRepo<Customer>, IServiceCustomer
{
	public ServiceCustomer(Entities.Context.NorthwindContext p_context) 
							: base(p_context) { }
}
