


namespace ABMedia83StudioMT;

/// <summary>
/// Main App Data 
/// </summary>
public partial class App : Application
{
    public static IHost? AppHost { get; private set; }

    public App()
    {
        AppHost = Host.CreateDefaultBuilder()
         .ConfigureServices((hostContext, services) =>
         {
             //Add the MainShell as a Singleton
             services.AddSingleton<MainShell>();

             //Add the ViewModel's  
             services.AddSingleton<StudioViewModel>();
             services.AddSingleton<PresetViewModel>();

             //Add Page services 
             services.AddSingleton<CodeStudio>();
             services.AddSingleton<DesignStudio>();
             services.AddSingleton<DocumentStudio>();
             services.AddSingleton<SocialMediaStudio>();
       



         })
     .Build();
    }

    protected override async void OnStartup(StartupEventArgs e)
    {
        await AppHost!.StartAsync();

        //Create the Main Shell
        MainShell shell = App.AppHost.Services.GetRequiredService<MainShell>();

        // Show the Shell Winodw  
        shell.Show();

        base.OnStartup(e);
    }
    protected override async void OnExit(ExitEventArgs e)
    {
        await AppHost!.StopAsync();
        base.OnExit(e);
    }
}




