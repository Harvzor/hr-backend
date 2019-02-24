using Microsoft.AspNetCore.Hosting;

namespace HrBackend.Tests
{
    public class TestProgram
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {
            return new WebHostBuilder()
                .UseStartup<TestStartup>();
        }
    }
}
