using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevBot9.Mvvm.Native {
    static class XmlNamespaceConstants {
        public const string PresentationNamespaceDefinition = "http://schemas.microsoft.com/winfx/2006/xaml/presentation";

        public const string MvvmPrefix = "dxmvvm";
        public const string MvvmNamespaceDefinition = "http://schemas.devexpress.com/winfx/2008/xaml/mvvm";
        public const string MvvmNamespace = "DevBot9.Mvvm";

        public const string MvvmIntenalPrefix = "dxmvvminternal";
        public const string MvvmInternalNamespaceDefinition = "http://schemas.devexpress.com/winfx/2008/xaml/mvvm/internal";
        public const string MvvmUINamespace = "DevBot9.Mvvm.UI";
        public const string MvvmInteractivityNamespace = "DevBot9.Mvvm.UI.Interactivity";
        public const string MvvmInteractivityInternalNamespace = "DevBot9.Mvvm.UI.Interactivity.Internal";
        public const string DXBindingNamespace = "DevBot9.Xpf.DXBinding";
        public const string ModuleInjectionNamespace = "DevBot9.Mvvm.UI.ModuleInjection";

        public const string GanttPrefix = "dxgn";
        public const string GanttNamespace = "DevBot9.Mvvm.Gantt";
        public const string GanttNamespaceDefinition = "http://schemas.devexpress.com/winfx/2008/xaml/gantt";
    }
    static class MvvmAssemblyHelper {
        public const string TestsAssemblyName = "DevBot9.Mvvm.Tests";
        public const string TestsFreeAssemblyName = "DevBot9.Mvvm.Tests.Free";
        public const string MvvmUIAssemblyName = "DevBot9.Mvvm.UI";
    }
}
