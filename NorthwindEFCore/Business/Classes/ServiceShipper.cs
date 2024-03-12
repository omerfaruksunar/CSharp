using DataAccess.Interfaces;
using Entities.Context;
using Entities.Models;

namespace Business.Classes;

public class ServiceShipper : ServiceRepo<Shipper>, IServiceShipper
{
	public ServiceShipper(Entities.Context.NorthwindContext p_context) 
							: base(p_context) { }
}
