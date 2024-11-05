using MauiNet8MVVMTemplate.ViewModels;
using MauiNet8MVVMTemplate.Views;
using Microsoft.Extensions.Logging;

namespace MauiNet8MVVMTemplate;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
        => MauiApp.CreateBuilder()
        .UseMauiApp<App>()
        .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            }
        )
        .Register()
        .Build();

    public static MauiAppBuilder Register(this MauiAppBuilder mauiAppBuilder)
    {
#if DEBUG
        mauiAppBuilder.Logging.AddDebug();
#endif

        mauiAppBuilder.Services.AddSingleton<DemoViewModel>();
        mauiAppBuilder.Services.AddTransient<DemoView>();

        return mauiAppBuilder;
    }
}