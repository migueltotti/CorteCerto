using CorteCerto.App.Infra;
using CorteCerto.App.Interfaces;
using CorteCerto.App.Pages;
using dotenv.net;
using Microsoft.Extensions.DependencyInjection;

namespace CorteCerto.App
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            DotEnv.Load(options: new DotEnvOptions(envFilePaths: new[] { @"Config\.env" }));

            ApplicationConfiguration.Initialize();

            ConfigureDI.ConfigureService();

            var mainForm = ConfigureDI.serviceProvider.GetRequiredService<MainForm>();

            System.Windows.Forms.Application.Run(mainForm);
        }
    }
}