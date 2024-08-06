

namespace ABMedia83StudioMT.Controls;

/// <summary>
/// Interaction logic for TextPad.xaml
/// </summary>
public sealed partial class TextPad : StudioControl
{
	//Private Fields
	TextPadMode _mode;
	/// <summary>
	/// Main Constructor
	/// </summary>
	public TextPad()
	{
		InitializeComponent();
		Init();
	}

	public override void Init()
	{
		base.Init();
		//Text Mode Lamba 
		cmbTextMode.SelectionChanged += (sender, e) =>
		{
			var mode = (TextModeItem)cmbTextMode.SelectedItem;
			//Show the Mode you want 
			Mode = mode.Mode;
		};
		//Font Family Lamba 
		cmbFontFamily.SelectionChanged += (sender, e) =>
		{
			var font = (FontItem)cmbFontFamily.SelectedItem;
			txtCode.FontFamily = font.FontFamily;
			txtWriter.FontFamily = font.FontFamily;
		};
		//Text Theme Lamba
		cmbTheme.SelectionChanged += (sender, e) =>
		{
			var theme = (NoteStyle)cmbTheme.SelectedItem;
			txtCode.Background = theme.Background;
			txtCode.Foreground = theme.TextBrush;
			txtWriter.Background = theme.Background;
			txtWriter.Foreground = theme.TextBrush;
		};
		//Font Size Lamba
		slideFontSize.ValueChanged += (sender, e) =>
		{
			txtCode.FontSize = slideFontSize.Value;
			txtWriter.FontSize = slideFontSize.Value;
		};
	}

	#region Import / Export Formats 

	public void ImportFormat(TextPadFormat format)
	{
		txtCode.Text = format.Text;
		txtWriter.Text = format.Text;
		txtCode.FontFamily = new FontFamily(format.FontFamily);
		txtWriter.FontFamily = new FontFamily(format.FontFamily);
		txtCode.FontSize = format.FontSize;
		txtWriter.FontSize = format.FontSize;
		txtCode.Background = HexBrush(format.Background);
		txtCode.Foreground = HexBrush(format.TextColor);
		txtWriter.Background = HexBrush(format.Background);
		txtWriter.Foreground = HexBrush(format.TextColor);
		cmbTextMode.SelectedIndex = format.ModeIndex;
		cmbFontFamily.SelectedIndex = format.FontIndex;
		cmbTheme.SelectedIndex = format.ThemeIndex;
	}

	/// <summary>
	/// Method is designed to export a TextPad Information fast. 
	/// </summary>
	/// <returns></returns>
	public TextPadFormat ExportFormat()
	{
		//Convert Colors 
		var background = (SolidColorBrush)txtCode.Background;
		var textColor = (SolidColorBrush)txtCode.Foreground;
		var format = new TextPadFormat(Text, txtCode.FontFamily.ToString(), txtCode.FontSize, background.Color.ToString(), textColor.Color.ToString(), cmbTextMode.SelectedIndex,cmbFontFamily.SelectedIndex,cmbTheme.SelectedIndex);
		//Return the TextPad Format 
		return format;
	}
	#endregion 

	public string Text
	{
		get => txtCode.Text;
		set 
		{
			txtCode.Text = value;
			txtWriter.Text = value;
		}
	}
	/// <summary>
	/// Get or set the TextPad Mode
	/// </summary>
	public TextPadMode Mode
	{
		get => _mode;
		set
		{
			_mode = value;

			switch (value)
			{
				case TextPadMode.Code: //Code Mode 
					txtCode.Visibility = Visibility.Visible;
					txtWriter.Visibility = Visibility.Collapsed;

					if (txtWriter.Text != null)
					{
						txtWriter.Text = txtCode.Text;
					}

					break;
				case TextPadMode.Writer:
					txtCode.Visibility = Visibility.Collapsed;
					txtWriter.Visibility = Visibility.Visible;

					if (txtCode.Text != null)
					{
						txtWriter.Text = txtCode.Text;
					}

					break;
			}
		}
	}
}
