using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Covid.TagHelpers
{
    [HtmlTargetElement("formatter")]
    [HtmlTargetElement(Attributes = "formatter")]
    public class TileHelper : TagHelper
    {
        public int Sequence { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.RemoveAll("formatter");
            if (Sequence % 2 == 0)
            {
                output.PreContent.SetHtmlContent("<div class=\"tile is-vertical\">");
                output.PostContent.SetHtmlContent("</div>");
            }
        }
    }
}
