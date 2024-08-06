
namespace Albert.Win32.Items;

/// <summary>
/// Class is desnigned to store a WPF Color
/// </summary>
public sealed class ColorItem : Item
{
	public ColorItem()
	{
		Color = HexColor("#0000000");
	}
	public ColorItem(string _hex)
	{
		Color = HexColor(_hex);
	}

	public ColorItem(Color _color)
	{
		Color = _color;
	}

	public ColorItem(byte _alpha, byte _red, byte _green, byte _blue)
	{
		Color = Color.FromArgb(_alpha, _red, _green, _blue);
	}

	public ColorItem(byte _red, byte _green, byte _blue)
	{
		Color = Color.FromRgb(_red, _green, _blue);
	}

	public Color Color { get; init; }


	public override string ToString()
	{
		return $"{Name}:{Color}";
	}

}

