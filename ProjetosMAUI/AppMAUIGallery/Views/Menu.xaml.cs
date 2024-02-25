using AppMAUIGallery.Repositories;

namespace AppMAUIGallery.Views;

public partial class Menu : ContentPage
{
    public Menu()
    {
        InitializeComponent(); // esse metodo converte oq codigo de xaml para c#

        var categories = new CategoryRepository().GetCategories();

        foreach (var category in categories) // listar categorias
        {
            var labelCategory = new Label();
            labelCategory.Text = category.Name;
            labelCategory.FontFamily = "OpenSansSemibold";

            MenuContainer.Children.Add(labelCategory);

            foreach(var component in  category.Components) // listar componentes
            {
                var tap = new TapGestureRecognizer();
                tap.CommandParameter = component.Page; // pagina que eu tenho que abrir
                tap.Tapped += OnTapComponent;

                var labelComponentTitle = new Label();
                labelComponentTitle.Text = component.Title;
                labelComponentTitle.FontFamily = "OpenSansSemibold";
                labelComponentTitle.Margin = new Thickness(20,20,0,0);
                labelComponentTitle.GestureRecognizers.Add(tap);

                var labelComponentDescription = new Label();
                labelComponentDescription.Text = component.Description;
                labelComponentDescription.Margin = new Thickness (20,0,0,0);
                labelComponentDescription.GestureRecognizers.Add(tap);

                MenuContainer.Children.Add(labelComponentTitle);
                MenuContainer.Children.Add(labelComponentDescription);

                //.Children é uma propriedade que representa a coleção de elementos secundários de um contêiner
                // o uso de .Children.Add() está adicionando os elementos visuais (labels, neste caso) ao layout
            }
        }
    }

    private void OnTapComponent(object sender, EventArgs e)
    {
        var label = (Label)sender;
        var tap = (TapGestureRecognizer)label.GestureRecognizers[0];
        var page = (Type)tap.CommandParameter;

        ((FlyoutPage)App.Current.MainPage).Detail = 
            new NavigationPage((Page)Activator.CreateInstance(page)); // isso faz a mudanca da pagina

        ((FlyoutPage)App.Current.MainPage).IsPresented = false; // deixar de apresentar o menu
    }

    private void OnTapInicio(object sender, TappedEventArgs e)
    {
        ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new AppMAUIGallery.Views.MainPage()); 
        ((FlyoutPage)App.Current.MainPage).IsPresented = false;
    }
}