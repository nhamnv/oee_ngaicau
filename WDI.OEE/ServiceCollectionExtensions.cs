using Castle.Core;
using System.Reflection;

namespace WDI.OEE
{
    public static class ServiceCollectionExtensions
    {
        public static void RegisterInterfacesAndImplementations(this IServiceCollection services
                                                                , string interfaceLibraryName
                                                                , string implementationLibraryName)
        {
            var interfaceAssembly = Assembly.Load(interfaceLibraryName);
            var implementationAssembly = Assembly.Load(implementationLibraryName);

            var types = implementationAssembly.GetExportedTypes().Where(type => type.IsClass && !type.IsAbstract);

            foreach (var type in types)
            {
                var interfaceType = type.GetInterfaces().FirstOrDefault();
                if (interfaceType != null && interfaceType.Assembly == interfaceAssembly)
                {
                    var attributeNames = type.GetCustomAttributes(true).Select(attr => attr.GetType().Name).ToList();

                    switch (true)
                    {
                        case var _ when attributeNames.Contains(nameof(ScopedAttribute)):
                            services.AddScoped(interfaceType, type);
                            break;
                        case var _ when attributeNames.Contains(nameof(TransientAttribute)):
                            services.AddTransient(interfaceType, type);
                            break;
                        case var _ when attributeNames.Contains(nameof(SingletonAttribute)):
                            services.AddSingleton(interfaceType, type);
                            break;
                        default:
                            // Default to transient if no attribute is specified
                            services.AddTransient(interfaceType, type);
                            break;
                    }
                }
            }
        }
    }
}
