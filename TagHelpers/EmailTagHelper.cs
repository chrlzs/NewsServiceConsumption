using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Covid.TagHelpers
{
    public class EmailTagHelper : TagHelper
    {

        string domainName = "somedomainname.com";

        public string MailTo { get; set; }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";                              
            var content = await output.GetChildContentAsync();
            var target = content.GetContent() + "@" + domainName;
            output.Attributes.SetAttribute("href", "mailto:" + target);
            output.Content.SetContent(target);
        }
    }
}
