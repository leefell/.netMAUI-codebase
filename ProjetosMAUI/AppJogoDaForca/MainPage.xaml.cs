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

            var repository = new WordRepositories();
            _word = repository.GetRandomWord();

            LblTips.Text = _word.Tips;
            LblText.Text = new string('_', _word.Text.Length); // ve a quantidade de caracteres de uma string e substitui por _
        }
        private void OnButtonClicked(object sender, EventArgs e)
        {
            ((Button)sender).IsEnabled = false; // se o usuario errar uma vez, ele n vai poder errar na mesma letra novamente

            String letter = ((Button)sender).Text; // armazena a letra que foi clicada

            var positions = _word.Text.GetPositions(letter);

            if(positions.Count == 0)
            {
                _errors++;
                return; 
            }

            foreach(int position in positions)
            {
                LblText.Text = LblText.Text.Remove(position, 1).Insert(position, letter);
            }
        }
    }
}
