
namespace ABMedia83StudioMT.Views;

/// <summary>
/// Interaction logic for SocialMediaStudio.xaml
/// </summary>
public sealed partial class SocialMediaStudio : StudioPage
{
	public SocialMediaStudio()
	{
		InitializeComponent();
		Init();
	}

	public override void Init()
	{
		base.Init();

		//Export Settings 
		OnExportSettings += (str) =>
		{
			var format = new SocialMediaStudioSettings(YouTubeMain: smProject.Export());
			//Write to a JSON File 
			WriteToJsonFile(format, str);
		};

		//Import Settings 
		OnImportSettings += (str) =>
		{
			var format = ReadFromJsonFile<SocialMediaStudioSettings>(str);
			//Convet the Json File 
			smProject.ImportFormat(format.YouTubeMain);
		};

		//Import Settings Here 
		ImportSettings(socialMediaSettings);

	}
}
