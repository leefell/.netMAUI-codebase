namespace AppMAUIGallery.Views.Components.Forms;

public partial class CheckBoxPage : ContentPage
{
	public CheckBoxPage()
	{
		InitializeComponent();
	}

    private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
		if(e.Value == true)
		{
			var checkbox = ((CheckBox)sender);
			var stack = (HorizontalStackLayout)checkbox.Parent;
			var label = (Label)stack.Children[1];
			lblStatus.Text = label.Text;
		}
		else
		{
			lblStatus.Text = string.Empty;
		}
    }
}