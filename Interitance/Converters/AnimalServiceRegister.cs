namespace Interitance.Converters
{
    public delegate IConverter AnimalServiceResolver(string identifier);

    public static class AnimalServiceRegister
    {
        public static void RegisterConverterDependencies(this IServiceCollection services)
        {
            services
                .AddSingleton<DogConverter>()
                .AddSingleton<CatConverter>()
                .AddSingleton<ConverterFacade>()

                .AddTransient<AnimalServiceResolver>(serviceProvider => identifier =>
                {
                    switch (identifier.ToLower())
                    {
                        case "dog":
                            return serviceProvider.GetRequiredService<DogConverter>();
                        case "cat":
                            return serviceProvider.GetRequiredService<CatConverter>();
                        default:
                            throw new NotSupportedException($"Type {identifier} does not support.");
                    }
                });
        }
    }
}
