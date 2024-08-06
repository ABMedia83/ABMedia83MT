
namespace ABMedia83StudioMT.Models;

public record TextPadFormat (string Text,string FontFamily,double FontSize,string Background,string TextColor,int ModeIndex,int FontIndex, int ThemeIndex);

public record SketchPadFormat(string SketchUrl,double Width,double Height,double BrushSize,byte BrushOpacity,string Baackground,string Foreground);

public record SocialMediaFormat(TextPadFormat Notes, TextPadFormat Description, TextPadFormat Tags, SMProjectMode Mode,int ModeIndex);