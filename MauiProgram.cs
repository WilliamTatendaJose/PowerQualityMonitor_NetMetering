﻿using Microsoft.Extensions.Logging;
using PowerQualityMonitor_NetMetering.ViewModels;
using PowerQualityMonitor_NetMetering.Views;

namespace PowerQualityMonitor_NetMetering
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
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

            return builder.Build();
        }
    }
}
