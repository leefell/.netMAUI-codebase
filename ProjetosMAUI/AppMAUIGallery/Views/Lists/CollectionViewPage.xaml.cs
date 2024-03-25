using AppMAUIGallery.Views.Lists.Models;
using System.Collections.ObjectModel;

namespace AppMAUIGallery.Views.Lists;

public partial class CollectionViewPage : ContentPage
{
	// Colecao que usa padrao de projeto observable, ela observa o comportamento da lista 
	// e notifica o componente, ai ele sabe que precisa atualizar
	ObservableCollection<Movie> movies = new ObservableCollection<Movie>();
	int countMovies = 0;
	public CollectionViewPage()
	{
		InitializeComponent();

		AddTenMovies();
		CollectionViewControl.ItemsSource = MovieList.GetGroupList();
	}

    private async void RefreshView_Refreshing(object sender, EventArgs e)
    {
		((RefreshView)sender).IsRefreshing = true;

		await Task.Delay(3000);
		CollectionViewControl.ItemsSource = MovieList.GetList();

		((RefreshView)sender).IsRefreshing = false;
    }

    private void CollectionViewControl_RemainingItemsThresholdReached(object sender, EventArgs e)
    {
		// trabalhando com o scroll infinito
		AddTenMovies();
    }

	private void AddTenMovies()
	{
        for(int i = 0; i < 20; i++)
		{
			Movie movie = new Movie
			{
				Id = countMovies++,
				Name = $"Movie {countMovies}",
				Description = $"Description {countMovies}",
				LaunchYear = 2022,
				Duration =  new TimeSpan(2,0,0)
			};
			movies.Add(movie);
		}
    }

    private void CollectionViewControl_Scrolled(object sender, ItemsViewScrolledEventArgs e)
    {
		if (DeviceInfo.Platform != DevicePlatform.WinUI)
			return;

		if(sender is CollectionView cv)
		{
			var LastVisibleItem =  e.LastVisibleItemIndex; // 15
			var RemainingItemsThreshold = cv.RemainingItemsThreshold; // 5
			var TotalItem = ((IEnumerable<object>)cv.ItemsSource).Count(); // 20 - 40 - 60 - ...

			if(LastVisibleItem > (TotalItem - RemainingItemsThreshold)){
				AddTenMovies();
			}
		}
    }
}