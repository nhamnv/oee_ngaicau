namespace WDI.OEE
{
    public static class InfrastructureDepedencyExtensions
    {
        public static void AddInfrastructureDependencies(this IServiceCollection services)
        {
            services.RegisterInterfacesAndImplementations("Service", "Service");
            services.RegisterInterfacesAndImplementations("Repository", "Repository");
        }
    }
}
