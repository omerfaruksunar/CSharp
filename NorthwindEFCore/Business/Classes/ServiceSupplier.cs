using DataAccess.Interfaces;
using Entities.Context;
using Entities.Models;
namespace Business.Classes;
public class ServiceSupplier : ServiceRepo<Supplier>, IServiceSupplier
{
	public ServiceSupplier(Entities.Context.NorthwindContext p_context)
							: base(p_context) { }
}
