namespace Sitecore.Support.XA.Foundation.Variants.Abstractions.Pipelines.IoC
{
    using Microsoft.Extensions.DependencyInjection;
    using Sitecore.DependencyInjection;
    using Sitecore.XA.Foundation.Variants.Abstractions.Renderers;
    using Sitecore.XA.Foundation.Variants.Abstractions.Services;

    public class RegisterVariantsAbstractionsServices : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IVariantFieldParser, VariantFieldParser>();
            serviceCollection.AddSingleton<ITemplateRenderer, TemplateRenderer>();
            serviceCollection.AddTransient<IVariantRenderer, VariantRenderer>();
            #region Changed code
            //serviceCollection.AddSingleton<IAvailableRenderingVariantService, AvailableRenderingVariantService>();
            serviceCollection.AddSingleton<IAvailableRenderingVariantService, Sitecore.Support.XA.Foundation.Variants.Abstractions.Services.AvailableRenderingVariantService>(); 
            #endregion
            serviceCollection.AddSingleton<IVariantRenderingService, VariantRenderingService>();
            serviceCollection.AddSingleton<IRulesService, RulesService>();
        }
    }
}