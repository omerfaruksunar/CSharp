using Entities.Models;
using Entities.DTOs;
namespace DataAccess.Interfaces;
public interface IDalDtoProductCatName : IEntityRepo<Product> 
{
	IQueryable<DtoProductCatName> GetProductsCatName();
	IQueryable<Product> GetProductsByCategory(int catID);
}

