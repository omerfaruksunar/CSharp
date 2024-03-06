public static class AutoFacImp
{
	public static IContainer Configure()
	{
		ContainerBuilder builder = new();
		builder.RegisterType<MySql>().As<ISql>();
		//builder.RegisterType<Sql>().As<ISql>();
		return builder.Build();
	}
}