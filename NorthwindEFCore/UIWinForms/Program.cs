using Autofac;
using Business.Interfaces;
using Core.Helper;

namespace UIWinForms;
internal static class Program
{
	[STAThread]
	static void Main()
	{
		ApplicationConfiguration.Initialize();
		Application.Run(new frmProduct(
			Configure().Resolve<IServiceProduct>(),
			Configure().Resolve<IServiceDtoProductCatName>(),
			Configure().Resolve<IServiceCategory>(),
			Configure().Resolve<IServiceSupplier>(),
			Configure().Resolve<IServiceVwProdCatSup>(),
			//Configure().Resolve<frmCategories>(),
			//Configure().Resolve<frmProdCatSup>(),
			//Configure().Resolve<frmSuppliers>(),
			Configure().Resolve<Product>(),
			new MappingProfiles().MatchMap()
			)
			);
	}
}