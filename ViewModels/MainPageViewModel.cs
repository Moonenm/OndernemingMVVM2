using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OndernemingMVVM2.ViewModels
{
    public partial class MainPageViewModel:BaseViewModel
    {
        [ObservableProperty]
        ObservableCollection<Werknemer> werknemers;

        private WerknemerRepository _repo;

        [ObservableProperty]
        Werknemer selectedWerknemer;

        public MainPageViewModel(WerknemerRepository repo)
        {
            _repo = repo;
            ToonWerknemers();
            SelectedWerknemer = new();
        }

        [RelayCommand]
        private async Task ToonVoorbeeld()
        {
            await Shell.Current.GoToAsync("Voorbeeld");
        }

        [RelayCommand]
        private void VerwijderWerknemer()
        {
            Werknemers.Remove(SelectedWerknemer);
        }

        [RelayCommand]
        private async Task ToonDetails()
        {
            await Shell.Current.GoToAsync("WerknemerDetails",true,new Dictionary<string, object>
            {
                {"Werknemer",SelectedWerknemer }
            });
        }

        [RelayCommand]
        private void ToonWerknemers()
        {
            Werknemers = new ObservableCollection<Werknemer>(_repo.GetWerknemers());
        }
    }
}
