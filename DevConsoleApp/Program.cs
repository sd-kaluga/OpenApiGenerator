
using Parser.Models.Stores;
using Parser.OpenApiData;
using Parser.Parsers;
using Razor.Templating.Core;
using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace DevConsoleApp
{
    class Program
    {
        async static Task Main(string[] args)
        {
            var content = File.ReadAllText("open_api_schema.json");
            OpenApiDocument document = JsonSerializer.Deserialize<OpenApiDocument>(content);
            DocumentModel model = new OpenApiParser(document).BuildModel();
            

            var html = await RazorTemplateEngine.RenderAsync("~/Views/TestView.cshtml", model);
            Console.WriteLine("Hello World!");
        }
    }
}
