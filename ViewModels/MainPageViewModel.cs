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

        public MainPageViewModel(WerknemerRepository repo)
        {
            _repo = repo;
        }
        [RelayCommand]
        private void ToonWerknemers()
        {
            Werknemers = new ObservableCollection<Werknemer>(_repo.GetWerknemers());
        }
    }
}
