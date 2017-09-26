namespace Sitecore.Support.XA.Foundation.Variants.Abstractions.Services
{
    using Sitecore.Data;
    using Sitecore.Data.Items;
    using Sitecore.XA.Foundation.IoC;
    using Sitecore.XA.Foundation.Presentation;
    using Sitecore.XA.Foundation.SitecoreExtensions.Extensions;
    using Sitecore.XA.Foundation.SitecoreExtensions.Repositories;
    using System.Linq;

    public class AvailableRenderingVariantService : Sitecore.XA.Foundation.Variants.Abstractions.Services.AvailableRenderingVariantService
    {
        public new ID[] AllowedTemplates { get; set; } = {
            Templates.MetadataPartialDesign.ID,
            Templates.PartialDesign.ID,
            Templates.Design.ID,
            Sitecore.XA.Foundation.Multisite.Templates.Page.ID,
            #region Added code
		    new ID("{47D90B92-9BD8-4903-88C0-8012347592A4}"), // Composite Section template (base template for Tab Item, Accordion Item and Carousel Slide templates)
            new ID("{36F45117-539A-4A13-ABF8-F1F74CB4B249}") // Flipside template 
	        #endregion
        };

        protected override bool InheritsFromAllowedTemplate(string pageTemplateId)
        {
            TemplateItem templateItem = ServiceLocator.Current.Resolve<IContentRepository>().GetTemplate(new ID(pageTemplateId));
            return this.AllowedTemplates.Any<ID>(id => templateItem.DoesTemplateInheritFrom(id));
        }
    }
}