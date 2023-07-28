namespace Bonus_HE171241
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //Add-start
            builder.Services.AddControllersWithViews();
            //Add-end

            var app = builder.Build();

            //Update-start
            //app.MapGet("/", () => "Hello World!");
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}"
                );
            //Update-end
            app.Run();
        }
    }
}