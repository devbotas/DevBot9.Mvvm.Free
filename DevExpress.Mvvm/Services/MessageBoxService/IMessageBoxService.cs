using DevBot9.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.ComponentModel;

namespace DevBot9.Mvvm {
    public interface IMessageBoxService {
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        MessageResult Show(string messageBoxText, string caption, MessageButton button, MessageIcon icon, MessageResult defaultResult);
    }
}
