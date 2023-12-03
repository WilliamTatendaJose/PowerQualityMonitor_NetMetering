
using Firebase.Auth;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;
using PowerQualityMonitor_NetMetering.ViewModels;
using PowerQualityMonitor_NetMetering.Views;
using Syncfusion.Maui.Core.Hosting;

namespace PowerQualityMonitor_NetMetering
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureSyncfusionCore()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            builder.Services.AddTransient<DashboardViewModel>();
            builder.Services.AddTransient<DashboardPage>();
            builder.Services.AddTransient<LoginViewModel>();
            builder.Services.AddTransient<LoginPage>();
            builder.Services.AddTransient<SignupPage>();
            builder.Services.AddTransient<SignUpViewModel>();
            builder.Services.AddTransient<SettingsViewModel>();
            builder.Services.AddTransient<Settings>();
            builder.Services.AddTransient<LogPage>();
            builder.Services.AddTransient<LogsViewModel>();
            builder.Services.AddTransient<ForgotPasswordViewModel>();
            builder.Services.AddTransient<ForgotPassword>();
          

            return builder.Build();
        }
    }
}
