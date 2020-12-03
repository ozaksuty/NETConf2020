using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DragDropPage : ContentPage
    {
        public DragDropPage()
        {
            InitializeComponent();
        }
        async void OnCorrectDrop(object sender, DropEventArgs e)
        {
            await DisplayAlert("Correct", "Congratulations!", "OK");
        }

        void OnIncorrectDragOver(object sender, DragEventArgs e)
        {
            e.AcceptedOperation = DataPackageOperation.None;
        }
    }
}