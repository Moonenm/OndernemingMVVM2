using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OndernemingMVVM2.ViewModels
{
    [QueryProperty(nameof(Movie),"Movie")]
    public partial class DetailMoviePageViewModel : BaseViewModel
    {
        [ObservableProperty]
        Movie movie;
    }
}
