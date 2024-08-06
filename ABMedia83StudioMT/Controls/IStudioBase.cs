



using ABMedia83StudioMT.ViewModels;

namespace ABMedia83StudioMT.Controls;

/// <summary>
/// Interface links a Control and or class to the main ViewModel 
/// </summary>
public interface IStudioBase
{
    StudioViewModel? Studio { get; }
}
