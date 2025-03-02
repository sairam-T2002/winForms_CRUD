using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using winForms_CRUD.DAL;
using winForms_CRUD.Forms;
using winForms_CRUD.Repositories;
using winForms_CRUD.Repositories.Interfaces;

namespace winForms_CRUD;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        var host = CreateHostBuilder().Build();

        // Resolve the main form from the service provider
        var mainForm = host.Services.GetRequiredService<LandingForm>();
        Application.Run(mainForm);
    }

    static IHostBuilder CreateHostBuilder()
    {
        return Host.CreateDefaultBuilder()
            .ConfigureServices(( context, services ) =>
            {
                // Register services
                services.AddTransient<LandingForm>(); // Register MainForm
                services.AddTransient<EmployeeForm>();
                services.AddTransient<ISQLite, SQLiteWrapper>();
                services.AddTransient<IEmployeeRepo, EmployeeRepo>();
            });
    }
}