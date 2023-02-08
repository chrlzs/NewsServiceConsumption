using Microsoft.AspNetCore.Razor.TagHelpers;
using Covid.Models;

namespace Covid.TagHelpers
{
    public class WebsiteInformationTagHelper : TagHelper
    {
        public WebsiteContextModel Info { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "section";
            output.PreContent.SetHtmlContent(
            $@"<strong>Version:</strong> {Info.Version} - &copy; {Info.CopyrightYear} - ");
            output.TagMode = TagMode.StartTagAndEndTag;
        }
    }
}
