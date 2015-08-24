using Audiotica.Database.Services.Interfaces;
using Audiotica.Windows.Tools.Mvvm;

namespace Audiotica.Windows.ViewModels
{
    public class SongsPageViewModel : ViewModelBase
    {
        public SongsPageViewModel(ILibraryService libraryService)
        {
            LibraryService = libraryService;
        }

        public ILibraryService LibraryService { get; }
    }
}