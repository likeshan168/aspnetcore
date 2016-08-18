using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;
using mvcMovie.Models;

namespace mvcMovie.TagHelpers
{
    [HtmlTargetElement("email", TagStructure = TagStructure.NormalOrSelfClosing)]
    public class EmailTagHelper : TagHelper
    {
        private const string EmailDomain = "163.com";

        public string MailTo { get; set; }
        //public override void Process(TagHelperContext context, TagHelperOutput output)
        //{
        //    //base.Process(context, output);
        //    output.TagName = "a";

        //    var address = MailTo + "@" + EmailDomain;
        //    output.Attributes.SetAttribute("href", "mailto:" + address);
        //    output.Content.SetContent(address);
        //}

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            var content = await output.GetChildContentAsync();
            var target = content.GetContent() + "@" + EmailDomain;
            output.Attributes.SetAttribute("href", "mailto:" + target);
            output.Content.SetContent(target);
        }


    }
    [HtmlTargetElement("bold")]
    [HtmlTargetElement(Attributes = "bold")]
    public class BoldTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.RemoveAll("bold");
            output.PreContent.SetHtmlContent("<strong>");
            output.PostContent.SetHtmlContent("</strong>");
        }
    }

    public class WebSiteInformationTagHelper : TagHelper
    {
        public WebSiteContext Info { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "section";
            output.Content.SetHtmlContent($@"
            <ul>
                <li><strong>Version:</strong>{Info.Version}</li>
                <li><strong>CopyrightYear:</strong>{Info.CopyrightYear}</li>
                <li><strong>Approved:</strong>{Info.Approved}</li>
                <li><strong>Num of tags to show:</strong>{Info.TagsToShow}</li>
            </ul>");
            output.TagMode = TagMode.StartTagAndEndTag;
        }
    }

    [HtmlTargetElement(Attributes = nameof(Condition))]
    public class ConditionTagHelper : TagHelper
    {
        public bool Condition { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (!Condition)
            {
                output.SuppressOutput();
            }
        }
    }
    [HtmlTargetElement("p")]
    public class AutoLinkerHttpTagHelper : TagHelper
    {
        public override int Order
        {
            get { return int.MinValue; }
        }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var childContent = output.Content.IsModified ? output.Content.GetContent() :
              (await output.GetChildContentAsync()).GetContent();
            output.Content.SetHtmlContent(Regex.Replace(childContent,
                @"\b(?:https?://)(\S+)\b",
                "<a target=\"_blank\" href=\"$0\">$0</a>"));
        }
    }
    [HtmlTargetElement("p")]
    public class AutoLinkerWwwTagHelper : TagHelper
    {
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var childContent = output.Content.IsModified ? output.Content.GetContent() :
              (await output.GetChildContentAsync()).GetContent();
            output.Content.SetHtmlContent(Regex.Replace(childContent,
                @"\b(www\.)(\S+)\b",
                "<a target=\"_blank\" href=\"http://$0\">$0</a>"));
        }
    }
}
