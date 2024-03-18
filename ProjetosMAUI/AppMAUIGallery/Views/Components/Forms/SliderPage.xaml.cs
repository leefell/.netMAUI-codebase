namespace AppMAUIGallery.Views.Components.Forms;

public partial class SliderPage : ContentPage
{
	public SliderPage()
	{
		InitializeComponent();
	}

    private void PhoneNumberSlider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        long phoneNumber = (long)e.NewValue;
        string phoneNumberString = phoneNumber.ToString("00000000000");
        string formattedPhoneNumber = string.Format("Número: ({0}) {1}-{2}", phoneNumberString.Substring(0, 2), phoneNumberString.Substring(2, 5), phoneNumberString.Substring(7, 4));
        if (phoneNumberLabel != null)
        {
            phoneNumberLabel.Text = formattedPhoneNumber;
        }
    }

    private void phoneNumberSlider_DragCompleted(object sender, EventArgs e)
    {
        LblValue.Text = "Encontrou o número?";
    }

    private void phoneNumberSlider_DragStarted(object sender, EventArgs e)
    {
        LblValue.Text = "Encontre o Número!";
    }
}