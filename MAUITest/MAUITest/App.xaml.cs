namespace MAUITest;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        //MainPage = new ContentPageDemo();
        //MainPage = new NavigationPage(new MainPage());
        //var navPage = new NavigationPage(new ContentPageDemo());
        //navPage.BarBackgroundColor = Colors.Chocolate;
        //navPage.BarTextColor = Colors.White;
        //navPage.Title = "Demo MAUI";
        //MainPage = navPage;

        MainPage = new FlyoutPageDemo();

    }
}
