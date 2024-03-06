#region Unity
IUnityContainer container = new UnityContainer();
var drv = container.RegisterType<ISql, Postgre>().Resolve<LetsWork>();
WriteLine(drv.WhoAreYou());
#endregion Unity

#region Autofac 1
var autoFac = AutoFacImp.Configure().Resolve<ISql>();
WriteLine(autoFac.WhoAreYou());
#endregion Autofac 1

#region Autofac 2
ContainerBuilder builder = new ContainerBuilder();
var Configure = builder.RegisterType<Sql>().As<ISql>();
var autoFac2 = builder.Build().Resolve<ISql>();
WriteLine(autoFac2.WhoAreYou());
#endregion Autofac 2

ReadLine();
