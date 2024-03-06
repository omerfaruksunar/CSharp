using DataAccess.Interfaces;
using Entities.Context;
using Entities.Models;

namespace DataAccess.Classes;

public class DalCustomer : EntityRepo<Customer>, IDalCustomer
{
	public DalCustomer(Entities.Context.NorthwindContext p_context) 
							: base(p_context) { }
}
