using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoFinal.TagHelpers
{
    public class BotaoTagHelper : TagHelper
    {
        private String Valor { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "button";
            output.Attributes.SetAttribute("class", "btn btn-outline-success");
            output.Attributes.SetAttribute("type", "submit");
            output.Attributes.SetAttribute("value", Valor);
            output.Content.SetContent(Valor);
        }
    }
}
