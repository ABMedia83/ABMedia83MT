

namespace ABMedia83StudioMT.Models;

public class SocialMediaModeItem : Item 
{
	SMProjectMode mode;
	public SocialMediaModeItem(string name, SMProjectMode mode)
	{
		Name = name;
		Mode = mode;
	}
	public SMProjectMode Mode
	{
		get => mode;
		set
		{
			mode = value;
			OnPropertyChanged("Mode");
		}
	}


}
