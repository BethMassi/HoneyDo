﻿using HoneyDo.Shared.Services;
using Microsoft.Extensions.Logging;

namespace HoneyDo
{
    //TODO: Add badge count for # of uncompleted tasks.
    
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
                });

            // Add device-specific services used by the HoneyDo.Shared project
            builder.Services.AddSingleton<IFormFactor, Services.FormFactor>();
            builder.Services.AddSingleton<ILocalStorage, Services.LocalStorage>();
            builder.Services.AddSingleton<IPhotoManager, Services.PhotoManager>();

            builder.Services.AddMauiBlazorWebView();
            

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Logging.AddDebug();
#endif
            
            return builder.Build();
        }
    }
}