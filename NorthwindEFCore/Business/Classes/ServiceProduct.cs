using DataAccess.Classes;
using DataAccess.Interfaces;
using Entities.Context;
using Entities.Models;

namespace Business.Classes;

public class DalProduct : ServiceRepo<Product>,IServiceProduct
{
	public DalProduct(Entities.Context.NorthwindContext p_context) 
		: base(p_context){ }
}
