using System.Collections.Generic;
using System.Threading.Tasks;
using DAO.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Moq;
using SportStore.Infrastructure;
using Xunit;

namespace SportStoreTests
{
    public class PageLinkTagHelperTests
    {
        [Fact]
        public void Can_Generate_Page_Links()
        {
            var urlHelper = new Mock<IUrlHelper>();
            urlHelper.SetupSequence(x => x.Action(It.IsAny<UrlActionContext>()))
                .Returns("Test/Page1")
                .Returns("Test/Page2")
                .Returns("Test/Page3");

            var urlHelperFactory = new Mock<IUrlHelperFactory>();
            urlHelperFactory.Setup(f =>
                    f.GetUrlHelper(It.IsAny<ActionContext>()))
                .Returns(urlHelper.Object);
            PageLinksTagHelper helper = new PageLinksTagHelper(urlHelperFactory.Object)
            {
                PageModel = new PagingInfo(28, 10, 2),
                PageAction = "Test"
            };
            var ctx = new TagHelperContext(
                new TagHelperAttributeList(),
                new Dictionary<object, object>(), "");
            var content = new Mock<TagHelperContent>();

            TagHelperOutput output = new TagHelperOutput(
                "div",
                new TagHelperAttributeList(),
                (cache, encoder) => Task.FromResult(content.Object));
            helper.Process(ctx, output);

            var result = output.Content.GetContent();
            Assert.Equal(
                @"<a class="""" href=""Test/Page1"">1</a><a class="""" href=""Test/Page2"">2</a><a class="""" href=""Test/Page3"">3</a>",
                result);
        }
    }
}