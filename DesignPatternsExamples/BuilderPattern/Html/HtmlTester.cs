using System;

namespace BuilderPattern.Html
{
    public static class HtmlTester
    {
        public static void Test()
        {
            var ulBuilder = new HtmlBuilder("ul");
            ulBuilder.AddChild("li", "Item 1");
            ulBuilder.AddChild("li", "Item 2");

            var divBuilder = new HtmlBuilder("div");
            divBuilder.AddChild(ulBuilder);

            var html = divBuilder.ToHtml();
            Console.WriteLine(html);



            var result = new HtmlBuilder("div")
                .AddChild(new HtmlBuilder("ul")
                    .AddChild("li", "Item 1")
                    .AddChild("li", "Item 2")
                )
                .ToHtml();

            Console.WriteLine(result);
        }
    }
}