using CommunityToolkit.Mvvm.ComponentModel;

namespace Exercise.MVVM.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private string text;

        public MainViewModel()
        {
            Text = "Hello";
        }
    }
}