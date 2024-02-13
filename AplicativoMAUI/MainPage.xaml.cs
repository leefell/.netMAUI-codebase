namespace AplicativoMAUI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void BTNOla_Clicked(object sender, EventArgs e)
        {
            string nomeUsuario = await DisplayPromptAsync("Nome", "Digite seu nome:", "Ok");
            string idadeUsuario = await DisplayPromptAsync("Sua Idade", "Digite sua idade: ", "Ok");
            await DisplayAlert("ALERTA", "Olá " + nomeUsuario + "!" +
                "\nVocê tem " + idadeUsuario + " anos e " +
                "está vendo essa notificação às: \n" + DateTime.Now.ToString(), "Fechar");
        }
    }
}
