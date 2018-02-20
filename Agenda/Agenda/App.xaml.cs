using Xamarin.Forms;

namespace Agenda
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var navigationPage = new NavigationPage(new Agenda.AgendaPage());
            navigationPage.BarBackgroundColor = Color.FromHex("#303F9F");
            MainPage = navigationPage;              
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
