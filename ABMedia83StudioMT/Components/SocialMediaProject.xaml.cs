
using System.Windows.Controls;

namespace ABMedia83StudioMT.Components;

/// <summary>
/// Interaction logic for YouTubeProject.xaml
/// </summary>
public sealed partial class SocialMediaProject : StudioControl
{

	SMProjectMode mode;

	public SocialMediaProject()
	{
		InitializeComponent();
		Init();
	}

	public SocialMediaProject(TabControl? _tab)
	{
		InitializeComponent();
		Init();
	}
	public override void Init()
	{
		base.Init();


		//ComboBox Info 
		cmbSelectMode.ItemsSource = Preset!.SocialMediaModePrest;

		cmbSelectMode.SelectionChanged += (s, e) =>
		{
			var item = (SocialMediaModeItem)cmbSelectMode.SelectedItem;
			Mode = item.Mode;
		};

		Mode = SMProjectMode.Split;


	}

	#region Import / Export Formats

	public void ImportFormat(SocialMediaFormat format)
	{
		Mode = format.Mode;
		notes.ImportNotes(format.Notes);
		descriptionTag.ImportDescription(format.Description);
		descriptionTag.ImportTags(format.Tags);
		cmbSelectMode.SelectedIndex = format.ModeIndex;

	}
	/// <summary>
	/// Export the Youtube Format
	/// </summary>
	/// <returns></returns>
	public SocialMediaFormat Export()
	{
		var format = new SocialMediaFormat(notes.ExportNotes(),descriptionTag.ExportDescription(),descriptionTag.ExportTags(),Mode,cmbSelectMode.SelectedIndex);
		return format;
	}

	#endregion 

	public SMProjectMode Mode
	{
		get => mode; 
		set
		{
			mode = value;
			switch (mode)
			{
				case SMProjectMode.Split:
					gridContent.ClearAll();
					//Setup the Rows
					gridContent.AddColumns(col1!,colSplit!, col2!);
					//Setup the Object Order 
					Grid.SetColumn(notes, 0);
					Grid.SetColumn(gridSplitter, 1);
					Grid.SetColumn(descriptionTag, 2);
					gridContent.AddChildren(notes!, gridSplitter!, descriptionTag!);
					break;
				case SMProjectMode.Notes: // Just Notes 
					gridContent.ClearAll();
					gridContent.AddColumns(col1!);
					Grid.SetColumn(notes, 0);
					gridContent.AddChildren(notes!);
					break;
				case SMProjectMode.Setup:
					gridContent.ClearAll();
					gridContent.AddColumns(col1!);
					Grid.SetColumn(descriptionTag, 0);
					gridContent.AddChildren(descriptionTag!);
					break;
					case SMProjectMode.Browser:
					gridContent.ClearAll();
					gridContent.AddColumns(col1!);
					Grid.SetColumn(exportBrowser, 0);
					gridContent.AddChildren(exportBrowser!);
					break;
				case SMProjectMode.Export:
					gridContent.ClearAll();
					gridContent.AddColumns(col1!,colSplit!,col2!);
					Grid.SetColumn(descriptionTag, 0);
					Grid.SetColumn(gridSplitter, 1);
					Grid.SetColumn(exportBrowser, 2);
					gridContent.AddChildren(descriptionTag!, gridSplitter!, exportBrowser!);
					break;
			}
		}
	}

}
