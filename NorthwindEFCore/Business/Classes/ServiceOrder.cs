using DataAccess.Interfaces;
using Entities.Context;
using Entities.Models;

namespace Business.Classes;

public class ServiceOrder : ServiceRepo<Order>, IServiceOrder
{
	public ServiceOrder(Entities.Context.NorthwindContext p_context) 
							: base(p_context) { }
}
