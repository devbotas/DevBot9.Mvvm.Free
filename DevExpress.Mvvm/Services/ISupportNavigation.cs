using System;
using System.Collections.Generic;
using System.Linq;

namespace DevBot9.Mvvm {
    public interface ISupportNavigation : ISupportParameter {
        void OnNavigatedTo();
        void OnNavigatedFrom();
    }
}
