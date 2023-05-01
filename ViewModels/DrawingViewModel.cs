using CommunityToolkit.Maui.Core;

namespace LensEyed.ViewModels;

public partial class DrawingViewModel : BaseViewModel
{
	[ObservableProperty]
	public ObservableCollection<IDrawingLine> lines = new();

	[RelayCommand]
	public void Clear()
	{
		Lines.Clear();
	}
}
