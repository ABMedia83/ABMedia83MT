



using System.Security.Policy;

namespace ABMedia83StudioMT.Controls;

/// <summary>
/// This control is designed to sketch out idea's 
/// </summary>
public sealed partial class SketchPad : StudioControl
{
	public SketchPad()
	{
		InitializeComponent();
		Init();
	}
	public override void Init()
	{
		base.Init();

		#region ComboBox Logic 

		cmbFormat.ItemsSource = Preset!.PresetFormats;
		cmbTheme.ItemsSource = Preset!.PresetDrawCanvasList;

		cmbFormat.SelectionChanged += (sender, e) =>
		{
			var format = cmbFormat.SelectedItem as FormatItem;
			gridCanvas.Width = format!.Width;
			gridCanvas.Height = format.Height;
			drawCanvas.Width = format.Width;
			drawCanvas.Height = format.Height;
		};

		cmbTheme.SelectionChanged += (sender, e) =>
		{
			var theme = cmbTheme.SelectedItem as InkItem;
			gridCanvas.Background = new SolidColorBrush(theme!.BackgroundColor) ;
			drawCanvas.BrushColor = theme.ForegroundColor;
		
		};

		#endregion


		#region Slider Logic 

		slideBrushOpacity.ValueChanged += (sender, e) =>
		{
			drawCanvas.BrushOpacity = (byte)e.NewValue;
		};

		slideBrushSize.ValueChanged += (sender, e) =>
		{
			drawCanvas.BrushSize = e.NewValue;
		};	


		#endregion 

		#region Commands


		AddCommand(DesktopCommands.Export ,(sender, e) =>
		{

			SaveDialogTask("Export Png", "Png Files|*.png", (s, i) =>
			{
				// Save Png to an Image.
				CreatePng(s.FileName, 96, drawCanvas);

			});

		});




		#endregion

	}

	#region Import / Export Format 

	public void ImportFormat(SketchPadFormat format)
	{
		//Load your sketches 
		LoadInkStrokes(drawCanvas,format.SketchUrl);
		drawCanvas.BrushSize = format.BrushSize;
		drawCanvas.BrushOpacity = format.BrushOpacity;
		drawCanvas.Width = format.Width;
		drawCanvas.Height = format.Height;
		drawCanvas.BrushColor = HexColor(format.Foreground);
		gridCanvas.Width = format.Width;
		gridCanvas.Height = format.Height;
		gridCanvas.Background = HexBrush(format.Baackground);
		
	}

	public SketchPadFormat Export(string _url)
	{
		//Convert Background to solid Color 
		var background = (SolidColorBrush)gridCanvas.Background;

		var format = new SketchPadFormat(_url, CanvasWidth, CanvasHeight, drawCanvas.BrushSize, drawCanvas.BrushOpacity, background.Color.ToString(), drawCanvas.BrushOpacity.ToString());

		//Return Format 
		return format;
	}



	#endregion 





	void canvas_Click(object sender, RoutedEventArgs e)
	{
		var opt = sender as OptionButton;

		switch(opt!.Tag)
		{
			case "Draw":
				drawCanvas.DrawMode = DrawMode.Draw; 
				break;
			case "Erase":
				drawCanvas.DrawMode = DrawMode.Erase;
				break;
			case "EraseByStroke":
				drawCanvas.DrawMode = DrawMode.EraseByStroke;
				break;
			case "Select":
				drawCanvas.DrawMode = DrawMode.Select;
				break;
		}

	}

	/// <summary>
	/// Get of set the DrawCanvas 
	/// </summary>
	public DrawCanvas Canvas
	{
		get => drawCanvas;
		set => drawCanvas = value;
	}
	/// <summary>
	/// Get or set the Canvas Width
	/// </summary>
	public double CanvasWidth
	{
		get => gridCanvas.Width;
		set => gridCanvas.Width = value;
	}
	/// <summary>
	/// Get or set the Canvas Height
	/// </summary>
	public double CanvasHeight
	{
		get => gridCanvas.Height;
		set => gridCanvas.Height = value;
	}

}
