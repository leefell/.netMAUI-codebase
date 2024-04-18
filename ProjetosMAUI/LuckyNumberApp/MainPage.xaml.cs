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

        // por que não usar o for? Usar um while é preferível aqui porque o for pode resultar em números repetidos, 
        // então quando o laço terminasse, poderiam ficar números faltando.
        // uma vez que o sortedSet não deixa os números da lista serem repetidos.
        while (set.Count < 6)
        {
            var random = new Random();
            var luckNumber = random.Next(1, 60);

            set.Add(luckNumber);
        }

        return set;
    }
}