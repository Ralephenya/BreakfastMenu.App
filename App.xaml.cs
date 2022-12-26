using BreakMenu.MVVM.Views;

namespace BreakMenu;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new ViewBreakMenu();
	}
}
