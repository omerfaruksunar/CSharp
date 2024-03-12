using DataAccess.Interfaces;
using Entities.Context;
using Entities.Models;

namespace Business.Classes;

public class ServiceTerritory : ServiceRepo<Territory>, IServiceTerritory
{
	public ServiceTerritory(Entities.Context.NorthwindContext p_context) 
							: base(p_context) { }
}
