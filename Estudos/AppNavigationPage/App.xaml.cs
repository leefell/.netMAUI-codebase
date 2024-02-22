namespace AppNavigationPage
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Page1()); // assim instancia uma navigation page
        }
    }
}
