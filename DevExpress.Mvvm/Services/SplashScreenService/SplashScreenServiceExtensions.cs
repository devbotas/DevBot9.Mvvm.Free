using System;
using System.ComponentModel;

namespace DevBot9.Mvvm {
    public static class SplashScreenServiceExtensions {
        public static void ShowSplashScreen(this ISplashScreenService service) {
            VerifyService(service);
            service.ShowSplashScreen(null);
        }
        static void VerifyService(ISplashScreenService service) {
            if(service == null)
                throw new ArgumentNullException("service");
        }
    }
}
