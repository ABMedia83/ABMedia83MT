



namespace ABMedia83StudioMT.Controls;

/// <summary>
/// Class is a Special Page that links to the Oipeline ViewModel 
/// </summary>
public class StudioPage : ViewPage,IStudioBase
{
    /// <summary>
    /// Get the main ViewModel to handle business 
    /// </summary>
    public StudioViewModel? Studio => App.AppHost?.Services.GetService<StudioViewModel>();

	/// <summary>
	/// Get the Pqreset ViewModel to handle premade list 
	/// </summary>
	public PresetViewModel? Preset => App.AppHost!.Services.GetRequiredService<PresetViewModel>();


	public override void Init()
    {
        //Set the DataContext to the ViewModel 
        DataContext = Studio;
    }
}
