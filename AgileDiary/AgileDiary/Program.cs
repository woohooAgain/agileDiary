using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace AgileDiary
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateWebHostBuilder(args).Build();
            host.Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseIISIntegration()
                .UseIIS()
                .UseStartup<Startup>();
    }
}
