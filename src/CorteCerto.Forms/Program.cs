using CorteCerto.App.Infra;
using dotenv.net;
using LiteBus.Commands.Abstractions;
using LiteBus.Messaging.Internal.Extensions;

namespace CorteCerto.App
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            DotEnv.Load(options: new DotEnvOptions(envFilePaths: new[] { @"Config\.env" }));

            ConfigureDI.ConfigureService();

            ApplicationConfiguration.Initialize();
            System.Windows.Forms.Application.Run(
                new LoginForm(ConfigureDI.serviceProvider.GetRequiredService<ICommandMediator>()));
        }
    }
}