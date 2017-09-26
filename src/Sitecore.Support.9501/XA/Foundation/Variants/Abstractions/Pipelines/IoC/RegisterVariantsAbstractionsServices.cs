namespace Sitecore.Support.XA.Foundation.Variants.Abstractions.Pipelines.IoC
{
    using Microsoft.Extensions.DependencyInjection;
    using Sitecore.XA.Foundation.IOC.Pipelines.IOC;
    using Sitecore.XA.Foundation.Variants.Abstractions.Renderers;
    using Sitecore.XA.Foundation.Variants.Abstractions.Services;

    public class RegisterVariantsAbstractionsServices : Sitecore.XA.Foundation.Variants.Abstractions.Pipelines.IoC.RegisterVariantsAbstractionsServices
    {
        public override void Process(IocArgs args)
        {
            args.ServiceCollection.AddTransient<IVariantFieldParser, VariantFieldParser>();
            args.ServiceCollection.AddSingleton<ITemplateRenderer, TemplateRenderer>();
            args.ServiceCollection.AddTransient<IVariantRenderer, VariantRenderer>();
            #region Changed code
            // args.ServiceCollection.AddTransient<IAvailableRenderingVariantService, AvailableRenderingVariantService>();
            args.ServiceCollection.AddTransient<IAvailableRenderingVariantService, Sitecore.Support.XA.Foundation.Variants.Abstractions.Services.AvailableRenderingVariantService>(); 
            #endregion
            args.ServiceCollection.AddTransient<IVariantRenderingService, VariantRenderingService>();
            args.ServiceCollection.AddTransient<IRulesService, RulesService>();
        }
    }
}