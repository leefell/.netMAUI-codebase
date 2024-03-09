namespace AppMAUIGallery.Views.Components.Mains;

public partial class ButtonPage : ContentPage
{
	public ButtonPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        LblBOTAO.Text += $"\nClicado: {DateTime.Now}";
    }

    private void Button_Pressed(object sender, EventArgs e)
    {
        LblBOTAO.Text += $"\nPressionado: {DateTime.Now}";
    }

    private void Button_Released(object sender, EventArgs e)
    {
        LblBOTAO.Text += $"\nLiberado: {DateTime.Now}";
    }
}