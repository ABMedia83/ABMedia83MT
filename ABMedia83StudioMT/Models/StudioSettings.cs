


namespace ABMedia83StudioMT.Models;

/// <summary>
/// StudioSettings recornd stores the main settings of this Application 
/// </summary>
/// <param name="WindowState">Window State</param>
/// <param name="ShowStatusBar">Hide or Show your Status Bar</param>
/// <param name="QuickNotes">Store a Quick Note</param>
/// <param name="Logs">Store Logs of what you do</param>
/// <param name="RecentFiles">Store all the files that you're working on </param>
public record StudioSettings(WindowState WindowState, bool ShowStatusBar, StudioMode StudioMode, ModelList<LogRecord> Logs, ModelList<FileRecord> RecentFiles);



