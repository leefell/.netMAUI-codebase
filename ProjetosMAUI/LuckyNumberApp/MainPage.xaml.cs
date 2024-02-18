namespace LuckyNumberApp;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}
	private void OnGenerateLuckyNumbers(object sender, EventArgs e)
	{
		NameApp.IsVisible = false; // essa label vai ficar invisivel
		ContainerLuckyNumbers.IsVisible = true;
	}
}