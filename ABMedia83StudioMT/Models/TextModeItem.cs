

namespace ABMedia83StudioMT.Models;

public class TextModeItem : Item
{
	private TextPadMode _mode;
    public TextModeItem(string name, TextPadMode mode)
	{
		Name = name;
		Mode = mode;
	}






    public TextPadMode Mode
    {
        get => _mode;
		set
		{
			_mode = value;
			OnPropertyChanged("Mode");
		}
    }
    
}

