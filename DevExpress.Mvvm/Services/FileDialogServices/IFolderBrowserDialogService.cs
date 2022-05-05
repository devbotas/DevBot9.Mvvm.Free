
namespace DevBot9.Mvvm {
    public interface IFolderBrowserDialogService {
        string StartPath { get; set; }
        string ResultPath { get; }
        bool ShowDialog();
    }
}
