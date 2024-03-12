using DataAccess.Interfaces;
using Entities.Context;
using Entities.Models;

namespace Business.Classes;

public class ServiceCategory : ServiceRepo<Category>, IServiceCategory
{
	public ServiceCategory(Entities.Context.NorthwindContext p_context) 
							: base(p_context) { }
}
