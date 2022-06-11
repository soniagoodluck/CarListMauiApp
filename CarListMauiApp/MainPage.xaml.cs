using CarListMauiApp.ViewModels;

namespace CarListMauiApp;

public partial class MainPage : ContentPage
{
   

	public MainPage(CarListViewModel carListViewModel)
	{
		InitializeComponent();
        BindingContext = carListViewModel;
    }
}

