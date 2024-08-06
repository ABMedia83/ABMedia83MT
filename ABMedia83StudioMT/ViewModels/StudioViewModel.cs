

namespace ABMedia83StudioMT.ViewModels;

/// <summary>
/// Default ViewModel for the Application
/// </summary>
public class StudioViewModel: ViewModel 
{
    //Private Field's 
    ModelList<Color> colors = new();

    #region Properties 
   


    /// <summary>
    /// Get or set Colors that I pick 
    /// </summary>
    public ModelList<Color> Colors
    {
        get => colors;
        set { colors = value; OnPropertyChanged("Colors"); }
    }


    #endregion

    #region Static Studio Pages 

    /// <summary>
    /// Get or set the Code Studio 
    /// </summary>
    public static CodeStudio CodeStudioPage { get; set; } = App.AppHost!.Services.GetRequiredService<CodeStudio>();
    /// <summary>
    /// Get or set the Design Studio
    /// </summary>
    public static DesignStudio DesignStudioPage { get; set; } = App.AppHost!.Services.GetRequiredService<DesignStudio>();
    /// <summary>
    /// Get or set the Document Studio
    /// </summary>
    public static DocumentStudio DocumentStudioPage { get; set; } = App.AppHost!.Services.GetRequiredService<DocumentStudio>();
    /// <summary>
    /// Get or set the Social Media Studio
    /// </summary>
    public static SocialMediaStudio SocialMediaStudioPage { get; set; } = App.AppHost!.Services.GetRequiredService<SocialMediaStudio>();

    #endregion





    #region Settings File names 

    public static string studioSettings => "studiosettings.json";
    public static string codeSettings => "codesettings.json";
    public static string designSettings => "designsettings.json";
    public static string documentSettings => "documentsettings.json";
    public static string socialMediaSettings => "socialmediasettings.json";

	#endregion 

}
