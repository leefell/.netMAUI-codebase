namespace AplicativoMAUI
{
    public partial class MainPage : ContentPage
    {
        string nomeUsuario, idadeUsuario;
        public MainPage()
        {
            InitializeComponent();
        }
        private async void BTNOla_Clicked(object sender, EventArgs e)
        {
            nomeUsuario = await DisplayPromptAsync("Nome", "Digite seu nome:", "Ok");
            await DisplayAlert("ALERTA", "Olá " + nomeUsuario + "!" +
                "\nVocê está vendo essa notificação às: " + DateTime.Now.ToString(), "Fechar");
        }

        private async void BTNIdade_Clicked(object sender, EventArgs e)
        {
            idadeUsuario = await DisplayPromptAsync("Sua Idade", "Digite sua idade: ", "Ok");
            await DisplayAlert("Saudações", "Você tem: " + idadeUsuario + " anos.", "Fechar");
        }
    }
}
