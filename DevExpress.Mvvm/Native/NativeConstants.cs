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
        const string PublicKey = "PublicKey=0024000004800000940000000602000000240000525341310004000001000100c9634fb4bd8481aa329ba0fbb6fe72063462135ecfb3c8a8a595ce4436df2697f258912e9aa0f705fabfb1d13d6044a55a42cee9fe81bcdce571a4fbeeaa758e1d4a2a20ffd8ea05018133be71da27951f0103ab3cec55f78009ff0d00fb8b02db756437ecee8893c624c8f1c639f342ceda43dd8a443460ca93d0d2990904bb";
        public const string TestsAssemblyName = "DevBot9.Mvvm.Tests, " + PublicKey;
        public const string TestsFreeAssemblyName = "DevBot9.Mvvm.Tests.Free, " + PublicKey;
        public const string MvvmUIAssemblyName = "DevBot9.Mvvm.UI, " + PublicKey;
    }
}
