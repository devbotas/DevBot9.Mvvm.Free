using DevBot9.Mvvm;
using DevBot9.Mvvm.Native;
using DevBot9.Mvvm.UI;
using DevBot9.Mvvm.UI.Interactivity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
namespace DevBot9.Mvvm.UI {
    public class MessageBoxService : ServiceBase, IMessageBoxService {
        MessageResult IMessageBoxService.Show(string messageBoxText, string caption, MessageButton button, MessageIcon icon, MessageResult defaultResult) {
            var owner = AssociatedObject.With(x => Window.GetWindow(x));
            if(owner == null)
                return MessageBox.Show(messageBoxText, caption, button.ToMessageBoxButton(), icon.ToMessageBoxImage(), defaultResult.ToMessageBoxResult()).ToMessageResult();
            else
                return MessageBox.Show(owner, messageBoxText, caption, button.ToMessageBoxButton(), icon.ToMessageBoxImage(), defaultResult.ToMessageBoxResult()).ToMessageResult();
        }
    }
}
