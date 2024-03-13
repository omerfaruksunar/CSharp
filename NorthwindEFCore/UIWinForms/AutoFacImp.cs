using Autofac;
using Business.Classes;
using Business.Interfaces;

namespace UIWinForms;
public static class AutoFacImp
{
	public static IContainer Configure()
	{
		ContainerBuilder builder = new();
		builder.RegisterGeneric(typeof(EntityRepo<>)).As(typeof(IEntityRepo<>)); //Generic T arasındaki baglantı için kullandık.
		builder.RegisterType<DalDtoProductCatName>()
						.As<IDalDtoProductCatName>();
		builder.RegisterType<ServiceDtoProductCatName>()
						.As<IServiceDtoProductCatName>();
		builder.RegisterType<ServiceCategory>().As<IServiceCategory>();
		builder.RegisterType<ServiceProduct>().As<IServiceProduct>();
		builder.RegisterType<ServiceSupplier>().As<IServiceSupplier>();
		builder.RegisterType<ServiceCustomer>().As<IServiceCustomer>();
		builder.RegisterType<ServiceEmployee>().As<IServiceEmployee>();
		builder.RegisterType<ServiceOrder>().As<IServiceOrder>();
		builder.RegisterType<ServiceRegion>().As<IServiceRegion>();
		builder.RegisterType<ServiceShipper>().As<IServiceShipper>();
		builder.RegisterType<ServiceTerritory>().As<IServiceTerritory>();
		builder.RegisterType<ServiceVwProdCatSup>().As<IServiceVwProdCatSup>();
		builder.RegisterType<Entities.Context.NorthwindContext>();
		builder.RegisterType<frmCategories>();
		builder.RegisterType<frmProdCatSup>();
		builder.RegisterType<frmProduct>();
		builder.RegisterType<frmSuppliers>();
		builder.RegisterType<Product>();
		return builder.Build();
	}
}
