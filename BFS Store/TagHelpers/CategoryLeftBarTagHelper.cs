using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using SportStore.Models;

namespace SportStore.TagHelpers
{
    public class CategoryLeftBarTagHelper : TagHelper
    {
        private IUrlHelperFactory UrlHelperFactory { get; }
        private IProductRepository ProductRepository { get; set; }

        public CategoryLeftBarTagHelper(IUrlHelperFactory urlHelperFactory, IProductRepository productRepository)
        {
            UrlHelperFactory = urlHelperFactory;
            ProductRepository = productRepository;
        }

        [ViewContext] [HtmlAttributeNotBound] public ViewContext ViewContext { get; set; }

        public string PageAction { get; set; }
        public string CssClass { get; set; }
        public Dictionary<string, object> ControllerArgs { get; set; } = new Dictionary<string, object>();

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            IUrlHelper urlHelper = UrlHelperFactory.GetUrlHelper(ViewContext);
            string[] categories = ProductRepository.GetProducts()
                .Select(p => p.Category)
                .Distinct()
                .OrderBy(c => c).ToArray();
            TagBuilder result = new TagBuilder("div");
            foreach (string singleCategory in categories)
            {
                ControllerArgs["category"] = singleCategory;
                TagBuilder button = new TagBuilder("a");
                button.InnerHtml.Append(singleCategory);
                button.Attributes["href"] = urlHelper.Action(PageAction, ControllerArgs);
                button.Attributes["class"] = CssClass;
                result.InnerHtml.AppendHtml(button);
            }

            output.Content.AppendHtml(result.InnerHtml);
        }
    }
}