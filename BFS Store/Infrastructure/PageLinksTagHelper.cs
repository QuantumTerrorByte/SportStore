using DAO.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SportStore.Infrastructure
{
    [HtmlTargetElement("div", Attributes = "page-model")]
    public class PageLinksTagHelper : TagHelper
    {
        private IUrlHelperFactory urlHelperFactory;

        public PageLinksTagHelper(IUrlHelperFactory helperFactory)
            => urlHelperFactory = helperFactory;

        [ViewContext] [HtmlAttributeNotBound] 
        public ViewContext ViewContext { get; set; }

        public PagingInfo PageModel { get; set; }
        public string PageAction { get; set; }

        public string PageClass { get; set; } = "btn ";
        public string CurrentPageClass { get; set; } = "btn-primary";
        public string CommonPageClass { get; set; } = "btn-secondary";


        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            IUrlHelper urlHelper = urlHelperFactory.GetUrlHelper(ViewContext);
            TagBuilder result = new TagBuilder("div");
            for (int i = 1; i <= PageModel.TotalPages; i++)
            {
                TagBuilder tag = new TagBuilder("a"); //create tag
                tag.Attributes["href"] = urlHelper.Action(PageAction, //add value to href atribute
                    new
                    {
                        page = i
                    });
                tag.InnerHtml.Append(i.ToString()); //add inner html
                
                tag.AddCssClass(PageClass);
                tag.AddCssClass(PageModel.CurrentPage == i ? CurrentPageClass : CommonPageClass);

                result.InnerHtml.AppendHtml(tag); //add href to paging block
                // output.Content.AppendHtml(result.InnerHtml);
            }

            output.Content.AppendHtml(result.InnerHtml);
        }
    }
}