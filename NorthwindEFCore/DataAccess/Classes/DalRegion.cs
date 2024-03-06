using DataAccess.Interfaces;
using Entities.Context;
using Entities.Models;

namespace DataAccess.Classes;

public class DalRegion : EntityRepo<Region>, IDalRegion
{
	public DalRegion(Entities.Context.NorthwindContext p_context) 
							: base(p_context) { }
}
