namespace AppMAUIGallery.Views.Components.Mains;

public partial class LabelPage : ContentPage
{
	public LabelPage()
	{
		InitializeComponent();
	}
    private void ClickGestureRecognizer_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Toque!", "Reconheci que você tocou aqui!", "Fechar");
    }
}