

namespace ABMedia83StudioMT.Controls;

/// <summary>
/// Control is used to take notes 
/// </summary>
public partial class Notes : StudioControl
{
	public Notes()
	{
		InitializeComponent();

	}

	#region Export / Import Format 
	/// <summary>
	/// Export the format of the Notes to a Record
	/// </summary>
	/// <returns></returns>
	public TextPadFormat ExportNotes()
	{
		return txtNotes.ExportFormat();
	}

	public void ImportNotes(TextPadFormat format)
	{
		txtNotes.ImportFormat(format);
	}


	#endregion

	public string NoteText
	{
		get => txtNotes!.Text;
		set => txtNotes!.Text = value;
	}

}
