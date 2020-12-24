using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Microsoft.Extensions.Primitives;
using RazorLight;
using RazorLight.Compilation;
using RazorLight.Generation;
using RazorLight.Razor;


namespace RazorLightTest.Renderer
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var viewsPath = Path.Combine(Directory.GetCurrentDirectory(), "Views");
            var filePath =  "TestView.cshtml";

            RazorLightEngine engine = new RazorLightEngineBuilder()
             .UseFileSystemProject(viewsPath)
             .UseMemoryCachingProvider()
             .Build();

          

            var res = await engine.CompileRenderAsync<object>(filePath, null);

            Console.WriteLine(res);

        }
    }
}
