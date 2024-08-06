

using ABMedia83StudioMT.ViewModels;

namespace ABMedia83StudioMT.Controls;

/// <summary>
/// Class is a special Control thatlinks directly to the Pipeline ViewModel 
/// </summary>
public class StudioControl: ViewControl, IStudioBase
{
    /// <summary>
    /// Get the main ViewModel to handle business 
    /// </summary>
    public StudioViewModel? Studio => App.AppHost?.Services.GetService<StudioViewModel>();
    /// <summary>
    /// Get the Pqreset ViewModel to handle premade list 
    /// </summary>
	public PresetViewModel? Preset => App.AppHost!.Services.GetRequiredService<PresetViewModel>();
	/// <summary>
	/// Init the Pipeline ViewModel with this base method 
	/// </summary>
	public override void Init()
    {
        //Set the DataContext to the ViewModel 
        DataContext = Studio;
    }
    public override void Close()
    {
        TabDialog.Show("Closing Tab", $"Do you want to close this {ProjectType }?", "Close", "Cancel", () =>
        {
            //Close the Tab 
            RemoveTab();
            //Send Message to the Applicaton 
            
        
        });
    }
    /// <summary>
    /// Get or set the  name of the  Proect Type
    /// </summary>
    public string? ProjectType { get; set; }
}
