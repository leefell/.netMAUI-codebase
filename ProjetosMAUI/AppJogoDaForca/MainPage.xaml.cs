using AppJogoDaForca.Models;
using AppJogoDaForca.Repositories;
using AppJogoDaForca.Libraries.Text;

namespace AppJogoDaForca
{
    public partial class MainPage : ContentPage
    {
        private Word _word;
        private int _errors = 0;
        public MainPage()
        {
            InitializeComponent();

            ResetScreen();
        }
        private async void OnButtonClicked(object sender, EventArgs e)
        {
            ((Button)sender).IsEnabled = false; // se o usuario errar uma vez, ele n vai poder errar na mesma letra novamente

            String letter = ((Button)sender).Text; // armazena a letra que foi clicada

            var positions = _word.Text.GetPositions(letter);

            if(positions.Count == 0)
            {
                _errors++;

                ImgMain.Source = ImageSource.FromFile($"forca{_errors + 1}.png"); // conforme o user for errando, vai trocando as imagens, forca1, forca2

                if(_errors == 6)
                {
                    bool continuePlaying = await DisplayAlert("Fim de Jogo!", "Você perdeu!", "Novo Jogo", "Sair");

                    if (continuePlaying)
                        ResetScreen();
                    else
                        App.Current.Quit();
                }

                return;
            }
            else
            {
                foreach(int position in positions)
                {
                    LblText.Text = LblText.Text.Remove(position, 1).Insert(position, letter);
                }
            }

        }
        private void ResetScreen()
        {
            ResetVirtualKeyBoard();
            ResetErrors();
            SortNewWord();
        }
        private void SortNewWord()
        {
            var repository = new WordRepositories();
            _word = repository.GetRandomWord();

            LblTips.Text = _word.Tips;
            LblText.Text = new string('_', _word.Text.Length); // ve a quantidade de caracteres de uma string e substitui por _
        }
        private void ResetErrors()
        {
            _errors = 0;
            ImgMain.Source = ImageSource.FromFile("forca1.png");
        }

        private void ResetVirtualKeyBoard()
        {
            ResetVirtualLines((HorizontalStackLayout)KeyboardContainer.Children[0]); // reseta a primeira fileira de letras
            ResetVirtualLines((HorizontalStackLayout)KeyboardContainer.Children[1]); // reseta a segunda fileira de letras
            ResetVirtualLines((HorizontalStackLayout)KeyboardContainer.Children[2]); // reseta a terceira fileira de letras
        }

        private void ResetVirtualLines(HorizontalStackLayout horizontal)
        {
            foreach(Button button in horizontal.Children) // cada filho é um botão
            {
                button.IsEnabled = true;
            }
        }
    }
}
