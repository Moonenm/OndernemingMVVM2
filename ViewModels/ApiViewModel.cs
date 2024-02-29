using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OndernemingMVVM2.ViewModels
{
    public partial class ApiViewModel : BaseViewModel
    {
        HttpClient HttpClient;

        [ObservableProperty]
        IpAdres ipAdres;

        [ObservableProperty]
        MovieResult movieResult;

        [ObservableProperty]
        string zoekwaarde;

        [ObservableProperty]
        Joke joke;

        [ObservableProperty]
        string templateString;

        private int PageNumber;

        public ApiViewModel()
        {
            TemplateString = "";
            HttpClient = new HttpClient();
            IpAdres = new();
            Joke = new();
            MovieResult = new();
            Zoekwaarde = "";
            PageNumber = 1;
        }

        [RelayCommand]
        private void VolgendePagina ()
        {
            PageNumber++;
            MoviesOphalen();
        }

        [RelayCommand]
        private void VorigePagina()
        {
            if(PageNumber > 1) {
                PageNumber--;
                MoviesOphalen();
            }
        }

        [RelayCommand]
        private void MoviesOphalen()
        {
            var APIKey = "81a27be8";
            var zoekwaarde = Zoekwaarde;
            var Url = $"https://www.omdbapi.com/?s={zoekwaarde}&apikey={APIKey}&page={PageNumber}";
            if(Zoekwaarde != "")
            {
                var response = HttpClient.GetStringAsync(Url).Result;
                if (response != null)
                {
                    MovieResult = JsonSerializer.Deserialize<MovieResult>(response);
                }          

            }

        }

        [RelayCommand]
        private void IPOphalen()
        {
            var Url = "https://api.myip.com/";
            var response = HttpClient.GetStringAsync(Url).Result;
            IpAdres = JsonSerializer.Deserialize<IpAdres>(response);

            var Url2 = "https://api.chucknorris.io/jokes/random";
            var response2 = HttpClient.GetStringAsync(Url2).Result;
            Joke = JsonSerializer.Deserialize<Joke>(response2);
        }
    }
}
