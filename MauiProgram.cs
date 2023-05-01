namespace LensEyed;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("FontAwesome6FreeBrands.otf", "FontAwesomeBrands");
				fonts.AddFont("FontAwesome6FreeRegular.otf", "FontAwesomeRegular");
				fonts.AddFont("FontAwesome6FreeSolid.otf", "FontAwesomeSolid");
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			})
			.RegisterViews()
			.RegisterViewModels()
			.RegisterServices();

		AppCenter.Start(
            "windowsdesktop=c4d063c6-9dc5-4a99-9249-c597f6eb0df4;" +
            "android=bf59e554-dd21-40c3-8880-e4cf4be2e776;" +
            "ios=c97add11-ae70-4949-aa8e-c726d5730c0d;" +
            "macos=058532a0-1af4-468a-a974-f442e8d9a8d8;",
			typeof(Analytics), typeof(Crashes));

		

		return builder.Build();
	}
	private static MauiAppBuilder RegisterViews(this MauiAppBuilder builder)
	{
        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddTransient<ListDetailDetailPage>();
        builder.Services.AddSingleton<ListDetailPage>();
        builder.Services.AddSingleton<DrawingPage>();
        return builder;
	}
    private static MauiAppBuilder RegisterViewModels(this MauiAppBuilder builder)
    {

        builder.Services.AddSingleton<MainViewModel>();
        builder.Services.AddTransient<ListDetailDetailViewModel>();
        builder.Services.AddSingleton<ListDetailViewModel>();
        builder.Services.AddSingleton<DrawingViewModel>();
        return builder;
    }
    private static MauiAppBuilder RegisterServices(this MauiAppBuilder builder)
    {
        builder.Services.AddSingleton(AudioManager.Current);
        builder.Services.AddTransient<SampleDataService>();
        builder.Services.AddSingleton<ImageManager>();
        return builder;
    }
}
