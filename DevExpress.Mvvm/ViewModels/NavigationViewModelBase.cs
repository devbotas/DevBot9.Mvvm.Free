using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevBot9.Mvvm {
    public abstract class NavigationViewModelBase : ViewModelBase, ISupportNavigation {
        #region ISupportNavigation Members
        protected virtual void OnNavigatedTo() { }
        protected virtual void OnNavigatedFrom() {
        }
        void ISupportNavigation.OnNavigatedTo() {
            OnNavigatedTo();
        }
        void ISupportNavigation.OnNavigatedFrom() {
            OnNavigatedFrom();
        }
        #endregion
    }
}
