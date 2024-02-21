using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OndernemingMVVM2.ViewModels
{
    public partial class VoorbeeldViewModel:BaseViewModel
    {
        [ObservableProperty]
        public int getal;
        [ObservableProperty]
        public int getal2;

        [ObservableProperty]
        public int totaal = 0;

        public VoorbeeldViewModel()
        {
            Titel = "Voorbeeld 1";
        }

        partial void OnGetal2Changing(int value)
        {
            Totaal = Getal + value;
        }

        [RelayCommand]
        private void GetalOptellen()
        {
            if (Getal < Getal2)
                Totaal = Getal + Getal2;
        }

        [RelayCommand]
        private void GetalVermenigvuldigen()
        {
            Totaal = Getal * Getal2;
        }
    }
}
