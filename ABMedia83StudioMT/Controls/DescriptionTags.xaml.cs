

namespace ABMedia83StudioMT.Controls;

/// <summary>
/// Control is deisnged to capture Disccription and Tags for Soical Media Projects 
 /// </summary>
public partial class DescriptionTags : StudioControl
{
    public DescriptionTags()
    {
        InitializeComponent();
    }

    #region Import / Export Format Method's 

    //Import Description 
    public void ImportDescription(TextPadFormat format)
	{
		txtDescription.ImportFormat(format);
	}
    /// <summary>
    /// Import Tags fro the TextPadFormat
    /// </summary>
    /// <param name="format"></param>
    
    
    public void ImportTags(TextPadFormat format)
    {
        txtTags.ImportFormat(format);
    }

    /// <summary>
    /// Export the Description to a Record
    /// </summary>
    /// <returns></returns>
    public TextPadFormat ExportDescription()
	{
		return txtDescription.ExportFormat();
	}
    //Export Tags
    public TextPadFormat ExportTags()
	{
		return txtTags.ExportFormat();
	}

    #endregion


    public string DescriptionText
    {
        get => txtDescription.Text;
        set => txtDescription.Text = value;
    }
	
    public string TagsText
	{
		get => txtTags.Text;
		set => txtTags.Text = value;
	}



}
