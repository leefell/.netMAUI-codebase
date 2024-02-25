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
                var labelComponentTitle = new Label();
                labelComponentTitle.Text = component.Title;
                labelComponentTitle.FontFamily = "OpenSansSemibold";
                labelComponentTitle.Margin = new Thickness(20,20,0,0);

                var labelComponentDescription = new Label();
                labelComponentDescription.Text = component.Description;
                labelComponentDescription.Margin = new Thickness (20,0,0,0);

                MenuContainer.Children.Add(labelComponentTitle);
                MenuContainer.Children.Add(labelComponentDescription);

                //.Children é uma propriedade que representa a coleção de elementos secundários de um contêiner
                // o uso de .Children.Add() está adicionando os elementos visuais (labels, neste caso) ao layout
            }
        }
    }
}