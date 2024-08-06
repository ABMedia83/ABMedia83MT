

namespace ABMedia83StudioMT.Controls;

/// <summary>
/// Interaction logic for YouTubeExportBrowser.xaml
/// </summary>
public sealed partial class SocialMediaBrowser : StudioControl
{
	public SocialMediaBrowser()
	{
		InitializeComponent();
		Init();
	}
	public override void Init()
	{
		base.Init();
		cmbSites.ItemsSource = Preset!.SocialMediaSitesPreset;

		cmbSites.SelectionChanged += (s, e) =>
		{
			var item = (BasicItem)cmbSites.SelectedItem;
			var site = (string?)item.Value;
			webBrowser.Source = new Uri(site!);
		};
		
	}

	void Web_Click(object sender, RoutedEventArgs e)
	{
		var push = sender as PushButton;

		switch (push!.Tag)
		{
			case "GoBack":
				webBrowser.GoBack();
				break;
			case "GoForward":
				webBrowser.GoForward();
				break;
			case "Refresh":
				webBrowser.Reload();
				break;
		}
	}
}
