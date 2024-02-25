using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OndernemingMVVM2.ViewModels
{
    [QueryProperty("Werknemer","SelectedWerknemer")]
    public partial class WerknemerDetailsViewModel:BaseViewModel
    {
        [ObservableProperty]
        Werknemer werknemer;
    }
}
