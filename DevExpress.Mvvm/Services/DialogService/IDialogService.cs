using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;

namespace DevBot9.Mvvm {
    public interface IDialogService {
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        UICommand ShowDialog(IEnumerable<UICommand> dialogCommands, string title, string documentType, object viewModel, object parameter, object parentViewModel);
    }
}
