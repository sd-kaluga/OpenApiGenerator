using Parser.OpenApiData;
using Parser.Parsers;
using System;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Parser
{
    class Program
    {
        static void Main(string[] args)
        {
            var content = File.ReadAllText("open_api_schema.json");
            OpenApiDocument document = JsonSerializer.Deserialize<OpenApiDocument>(content);
            var model = new OpenApiParser(document).BuildModel();
            Console.WriteLine("Hello World!");
        }
    }
}
