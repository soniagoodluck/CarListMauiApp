using System.ComponentModel;
using System.Runtime.CompilerServices;
using CommunityToolkit.Mvvm.ComponentModel;

namespace CarListMauiApp.ViewModels
{
    public partial class BassViewModel : ObservableObject
    {
        [ObservableProperty]
        string title;

        [ObservableProperty]
        [AlsoNotifyChangeFor(nameof(IsNotLoading))]
        bool isLoading;

        public bool IsNotLoading => !isLoading;

 

    }
}