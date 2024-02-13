namespace AplicativoMAUI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void BTNOla_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("ALERTA", "Olá Mundo! \nVocê está vendo essa notificação!", "Fechar");
        }

        private void BTNBrincadeira_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Horário Atual: ", DateTime.Now.ToString(), "Fechar");
        }
    }
}
