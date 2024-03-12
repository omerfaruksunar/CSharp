using DataAccess.Interfaces;
using Entities.Context;
using Entities.Models;

namespace Business.Classes;

public class ServiceRegion : ServiceRepo<Region>, IDalRegion
{
	public ServiceRegion(Entities.Context.NorthwindContext p_context) 
							: base(p_context) { }
}
