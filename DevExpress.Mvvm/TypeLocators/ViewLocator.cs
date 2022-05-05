using System;
using System.Reflection;
using DevBot9.Mvvm.UI;

namespace DevBot9.Mvvm.UI {
    public interface IViewLocator {
        object ResolveView(string name);
        Type ResolveViewType(string name);
        string GetViewTypeName(Type type);
    }
}
namespace DevBot9.Mvvm.Native {
    static class ViewLocatorHelper {
        const string ViewLocatorTypeName = "DevBot9.Mvvm.UI.ViewLocator";
        static PropertyInfo ViewLocatorDefaultProperty;
        public static IViewLocator Default {
            get {
                if(ViewLocatorDefaultProperty == null) {
                    var viewLocatorType = DynamicAssemblyHelper.MvvmUIAssembly.GetType(ViewLocatorTypeName);
                    ViewLocatorDefaultProperty = viewLocatorType.GetProperty("Default", BindingFlags.Static | BindingFlags.Public);
                }
                return (IViewLocator)ViewLocatorDefaultProperty.GetValue(null, null);
            }
        }
    }
}
