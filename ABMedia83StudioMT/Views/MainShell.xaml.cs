

namespace ABMedia83StudioMT.Views;

/// <summary>
/// Main shell of this Application 
/// </summary>
public sealed partial class MainShell : StudioShell
{
    //Private Field's 
    StudioMode mode;

    public MainShell()
    {
        InitializeComponent();
        Init();
    }

    public override void Init()
    {
        base.Init();

        #region ViewModel Logic 
        // Main Window Title  
        Studio!.Title = "ABMedia83 Studio 2024";
        //Set the Default frame 
        Studio!.Frame = frame;



        #endregion


        #region Commands 

        //New Command
        AddCommand(ApplicationCommands.New, (s, e) =>
        {

        });

        //Open Command
        AddCommand(ApplicationCommands.Open, (s, e) =>
        {

        });

        //About Command 
        AddCommand(DesktopCommands.About, (s, e) =>
		{
			
		});


		//Quit Command 
		AddCommand(DesktopCommands.Quit, (s, e) => Close());


		#endregion

		#region Settings 

		//Show Status Bac Lamba 
		statusMenuItem.Click += (s, e) =>
        {
            switch (statusMenuItem.IsChecked)
            {
                case true:
                    statusBar.Visibility = Visibility.Visible;
                    break;
                case false:
                    statusBar.Visibility = Visibility.Collapsed;
                    break;
            }
        };

		//Default mode without Settings 
		Mode = StudioMode.SocialMedia;


        //On Export Settings
        OnExportSettings += (str) =>
		{
            //Store Settings into a Record 
			var settings = new StudioSettings(WindowState, statusMenuItem.IsChecked , Mode, Studio!.Logs, Studio!.Files);

            //Write to a Json File
			WriteToJsonFile(settings,str);

            

            
		};
     

        //On import settings 
        OnImportSettings += (str) =>
        {
            var settings = ReadFromJsonFile<StudioSettings>(str);
            WindowState = settings.WindowState;
            switch(settings.ShowStatusBar)
            {
                    case true:
					statusMenuItem.IsChecked = true;
                    statusBar.Visibility = Visibility.Visible;
					break;
					case false:
					statusMenuItem.IsChecked = false;
                    statusBar.Visibility = Visibility.Collapsed;
					break;  
             
            }
            Mode = settings.StudioMode;
            Studio!.Logs = settings.Logs;
            Studio!.Files = settings.RecentFiles;

			

        };

        //Import Settings 
        ImportSettings(studioSettings);

        //Close Method 
        Closed += (s, e) =>
        {
            //Export Settings 
			ExportSettings(studioSettings);
            SocialMediaStudioPage.ExportSettings(socialMediaSettings);
        };

		#endregion



	}

    #region More Events

    void Mode_Click(object sender, RoutedEventArgs e)
	{
		var mnu = sender as MenuItem;

        switch(mnu!.Tag)
        {
            case "Code":
				Mode = StudioMode.Code;
				break;
            case "Design":
                Mode = StudioMode.Design;
                break;
            case "Document":
                Mode = StudioMode.Document;
                break;
            case "Social":
                    Mode = StudioMode.SocialMedia;
                break;
        }
	}

    #endregion


    /// <summary>
    /// Get or set the Current Studio Mode for this Application 
    /// </summary>
    public StudioMode Mode
    {
        get => mode; 
        set
        {
            mode = value;

            switch(value)
            {
                case StudioMode.Code:
                    Studio!.NavigateFrame(CodeStudioPage);
                    Studio!.Title = "ABMedia83 - Code Studio";
                    break;
                    case StudioMode.Design:

                        Studio!.NavigateFrame(DesignStudioPage);
                        Studio!.Title = "ABMedia83 - Design Studio";

                    break;

                    case StudioMode.Document:
                        Studio!.NavigateFrame(DocumentStudioPage);
                        Studio!.Title = "ABMedia83 - Document Studio";
                    break;

                    case StudioMode.SocialMedia:

                        Studio!.NavigateFrame(SocialMediaStudioPage);
                        Studio!.Title = "ABMedia83 - Social Media Studio";
                        break;
            }
            
        }
    }
}
