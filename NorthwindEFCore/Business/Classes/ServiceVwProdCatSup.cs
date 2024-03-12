using DataAccess.Interfaces;
using Entities.Context;
using Entities.Models;
namespace Business.Classes;
public class ServiceVwProdCatSup : ServiceRepo<VwProdCatSup>, IServiceVwProdCatSup
{
	public ServiceVwProdCatSup(Entities.Context.NorthwindContext p_context) 
		: base(p_context) { }
}
