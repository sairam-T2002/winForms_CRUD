using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using winForms_CRUD.DAL;
using winForms_CRUD.DAL.Interfaces;
using winForms_CRUD.Forms;
using winForms_CRUD.Repositories;
using winForms_CRUD.Repositories.Interfaces;

namespace winForms_CRUD;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        var host = CreateHostBuilder().Build();
        var mainForm = host.Services.GetRequiredService<LandingForm>();
        Application.Run(mainForm);
    }

    static IHostBuilder CreateHostBuilder()
    {
        return Host.CreateDefaultBuilder()
            .ConfigureServices(( context, services ) =>
            {
                services.AddTransient<LandingForm>();
                services.AddTransient<EmployeeForm>();
                services.AddSingleton<IDAL, SQLiteWrapper>();
                services.AddSingleton<IEmployeeRepo, EmployeeRepo>();
            });
    }
}