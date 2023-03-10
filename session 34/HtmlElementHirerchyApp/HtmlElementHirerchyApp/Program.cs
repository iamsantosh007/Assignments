using HtmlElementHirerchyApp.Models;

namespace HtmlElementHirerchyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ControlGrp roothtml = new ControlGrp("html");
            ControlGrp bodyTag=new ControlGrp("body");
            ControlGrp divTag=new ControlGrp("div");
            ControlGrp paragraphTag = new ControlGrp("p");
            bodyTag.AddChild(divTag);
            divTag.AddChild(paragraphTag);
            paragraphTag.AddChild(new Control("label",101,"Hello Word"));
            roothtml.AddChild(bodyTag);
            Console.WriteLine(roothtml.Render());
            roothtml.GenerateToHtml();

        }
    }
}