

using ABMedia83StudioMT.ViewModels;

namespace ABMedia83StudioMT.Controls;

/// <summary>
/// Class is the base Shell Class for this Application 
/// </summary>
public class StudioShell: ViewShell, IStudioBase
{
    /// <summary>
    /// Get the main ViewModel to handle business 
    /// </summary>
    public StudioViewModel? Studio => App.AppHost?.Services.GetService<StudioViewModel>();

    public override void Init()
    {
        //Set the DataContext to the ViewModel 
        DataContext = Studio;
    }

}
