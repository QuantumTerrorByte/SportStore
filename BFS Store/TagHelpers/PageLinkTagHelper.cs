using System.Collections.Generic;
using DAO.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using SportStore.Models.ViewModels.depricated;

namespace SportStore.TagHelpers
{
    [HtmlTargetElement("div", Attributes = "page-model2")]
    public class PageLinkTagHelper : TagHelper
    {
        private IUrlHelperFactory _urlHelperFactory;

        public PageLinkTagHelper(IUrlHelperFactory urlHelperFactory)
        {
            _urlHelperFactory = urlHelperFactory;
        }

        [ViewContext] [HtmlAttributeNotBound] public ViewContext ViewContext { get; set; }

        [HtmlAttributeName(DictionaryAttributePrefix = "page-url-")]
        public Dictionary<string, object> PageUrlValues { get; set; } = new Dictionary<string, object>();

        public string PageAction { get; set; }
        public PagingInfo PageModel { get; set; }
        public string CommonCssClass { get; set; }
        public string CurrentPageCssClass { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            IUrlHelper urlHelper = _urlHelperFactory.GetUrlHelper(ViewContext);
            TagBuilder result = new TagBuilder("div");
            var from = 2;
            var to = 10;
            var current = PageModel.CurrentPage;
            var total = PageModel.TotalPages - 1;
            if (total > 10)
            {
                if (current > 5 && current < total - 4)
                {
                    from = current - 4;
                    to = current + 4;
                }
                else if (current >= total - 4)
                {
                    from = total - 8;
                    to = total;
                }
            }


            result.InnerHtml.AppendHtml(CreateTag("a", 1, urlHelper));
            for (int i = from; i <= to; i++)
            {
                result.InnerHtml.AppendHtml(CreateTag("a", i, urlHelper));
            }

            result.InnerHtml.AppendHtml(CreateTag("a", PageModel.TotalPages, urlHelper));

            output.Content.AppendHtml(result.InnerHtml);
            output.Attributes.SetAttribute("class", "pageButtonsBlock");
            // output.Content.Append(result);
        }

        private TagBuilder CreateTag(string tag, int index, IUrlHelper urlHelper)
        {
            var result = new TagBuilder(tag);
            PageUrlValues["productPage"] = index;
            result.Attributes["href"] = urlHelper.Action(PageAction, PageUrlValues);
            result.Attributes["class"] = PageModel.CurrentPage == index ? CurrentPageCssClass : CommonCssClass;
            result.InnerHtml.Append(index.ToString());
            return result;
        }
    }
}