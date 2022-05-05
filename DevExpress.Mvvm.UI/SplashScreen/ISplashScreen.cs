
namespace DevBot9.Mvvm.UI {
    public interface ISplashScreen {
        void Progress(double value);
        void SetProgressState(bool isIndeterminate);
        void CloseSplashScreen();
    }
}
