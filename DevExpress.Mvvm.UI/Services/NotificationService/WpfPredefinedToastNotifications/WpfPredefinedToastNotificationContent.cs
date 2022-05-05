using DevBot9.Internal;
using DevBot9.Internal.WinApi.Windows.UI.Notifications;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Media.Imaging;

namespace DevBot9.Mvvm.UI.Native {
    internal class WpfPredefinedToastNotificationContent : IPredefinedToastNotificationContent {
        const int msDefaultDuration = 6000;
        const int msLongDuration = 25000;
        public PredefinedToastNotificationVewModel ViewModel { get; private set; }
        public int Duration { get; set; }
        public WpfPredefinedToastNotificationContent(PredefinedToastNotificationVewModel viewModel) {
            ViewModel = viewModel;
            Duration = msDefaultDuration;
        }
        public void SetImage(byte[] image) {
            var bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.StreamSource = new MemoryStream(image);
            bitmap.EndInit();
            ViewModel.Image = bitmap;
        }
        public void SetImage(System.Drawing.Image image) {
            throw new NotImplementedException();
        }
        public void SetImage(string path) {
            throw new NotImplementedException();
        }
        public void SetSound(DevBot9.Internal.PredefinedSound sound) {
            if (sound != DevBot9.Internal.PredefinedSound.NoSound)
                Debug.WriteLine("Only Windows 8 toast notifications support sound.");
        }
        public void SetDuration(DevBot9.Internal.NotificationDuration duration) {
            Duration = duration == DevBot9.Internal.NotificationDuration.Long ? msLongDuration : msDefaultDuration;
        }
        public void Dispose() { }
        public DevBot9.Internal.IPredefinedToastNotificationInfo Info {
            get { return new WpfTToastNotificationInfo(); }
        }
        class WpfTToastNotificationInfo : DevBot9.Internal.IPredefinedToastNotificationInfo {
            public ToastTemplateType ToastTemplateType { get; set; }
            public string[] Lines { get; set; }
            public string ImagePath { get; set; }
            public DevBot9.Internal.NotificationDuration Duration { get; set; }
            public DevBot9.Internal.PredefinedSound Sound { get; set; }
        }
    }
}
