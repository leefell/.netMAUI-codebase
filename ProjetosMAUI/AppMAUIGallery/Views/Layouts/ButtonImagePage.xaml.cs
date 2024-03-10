namespace AppMAUIGallery.Views.Layouts;

public partial class ButtonImagePage : ContentPage
{
	bool buttonState = false;
	public ButtonImagePage()
	{
		InitializeComponent();
	}

    private void ImageButton_Clicked(object sender, EventArgs e)
    {
		buttonState = !buttonState;

		var poweroff = "poweroff.png";
		var poweron = "poweron.png";

		var button = (ImageButton)sender;

		button.Source = (buttonState == false) ? ImageSource.FromFile(poweron) : ImageSource.FromFile(poweroff);
    }
}