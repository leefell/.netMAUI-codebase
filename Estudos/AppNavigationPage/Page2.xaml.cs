namespace AppNavigationPage;

public partial class Page2 : ContentPage
{
	public Page2()
	{
		InitializeComponent();
	}

    private void OnButtonNextClicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new Page3());
    }

    private void OnButtonPreviousClicked(object sender, EventArgs e)
    {
        Navigation.PopAsync(); // volta a pagina anterior, mas deve ter certeza que existe uma pagina anterior
        // Navigation.NavigationStack é o empilhamento das paginas
        // Navigation.ModalStack a ideia do modal é que ele nao usa a barra de titulo, ela é apresentada sem o botao de tirar padrao
        // tipo termos de uso durante a instalacao de algo

        // Navigation.PopToRootAsync(); volta direto ao inicio do fluxo (exemplo um cadastro de etapas)
        // Navigation.RemovePage(Navigation.NavigationStack[1]); // removeria a pagina 2 da pilha
        //Navigation.InsertPageBefore(2, 3); // adicionar uma nova pagina dentro da pilha
    }
}