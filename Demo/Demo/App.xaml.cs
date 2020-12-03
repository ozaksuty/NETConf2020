using Demo.Services;
using Xamarin.Forms;

namespace Demo
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
            Device.SetFlags(new string[] { "Expander_Experimental", "SwipeView_Experimental", "DragAndDrop_Experimental",
            "MediaElement_Experimental", "RadioButton_Experimental", "Shapes_Experimental", "AppTheme_Experimental", 
                "IndicatorView_Experimental"});
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
