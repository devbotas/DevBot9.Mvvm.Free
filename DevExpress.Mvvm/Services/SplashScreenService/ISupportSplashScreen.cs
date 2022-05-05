using System.ComponentModel;

namespace DevBot9.Mvvm {
    public interface ISupportSplashScreen {
        bool IsIndeterminate { get; set; }
        double Progress { get; set; }
        double MaxProgress { get; set; }
        object State { get; set; }
    }
}
