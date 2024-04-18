namespace LuckyNumberApp;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }
    private void OnGenerateLuckyNumbers(object sender, EventArgs e)
    {
        NameApp.IsVisible = false; // essa label vai ficar invisivel
        ContainerLuckyNumbers.IsVisible = true;

        var set = GenerateNumbers();

        LuckyNumber01.Text = set.ElementAt(0).ToString("D2");
        LuckyNumber02.Text = set.ElementAt(1).ToString("D2");
        LuckyNumber03.Text = set.ElementAt(2).ToString("D2");
        LuckyNumber04.Text = set.ElementAt(3).ToString("D2");
        LuckyNumber05.Text = set.ElementAt(4).ToString("D2");
        LuckyNumber06.Text = set.ElementAt(5).ToString("D2");
    }
    private SortedSet<int> GenerateNumbers()
    {
        // sortedset nao deixa os elementos se repetirem e faz em ordem crescente
        var set = new SortedSet<int>();

        // por que n�o usar o for? Usar um while � prefer�vel aqui porque o for pode resultar em n�meros repetidos, 
        // ent�o quando o la�o terminasse, poderiam ficar n�meros faltando.
        // uma vez que o sortedSet n�o deixa os n�meros da lista serem repetidos.
        while (set.Count < 6)
        {
            var random = new Random();
            var luckNumber = random.Next(1, 60);

            set.Add(luckNumber);
        }

        return set;
    }
}