using System.Windows.Markup;
using System.Resources;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using System;
using System.Security;
using DevBot9.Mvvm.Native;
using DevBot9.Internal;

[assembly: AssemblyTitle("DevBot9.Mvvm")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("devbotas")]
[assembly: AssemblyProduct("DevBot9.Mvvm")]
[assembly: AssemblyCopyright(AssemblyInfo.AssemblyCopyright)]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: CLSCompliant(true)]
[assembly: AllowPartiallyTrustedCallers]
[assembly: SatelliteContractVersion(AssemblyInfo.SatelliteContractVersion)]
[assembly: ComVisible(false)]
[assembly: NeutralResourcesLanguage("en-US")]

[assembly: XmlnsPrefix(XmlNamespaceConstants.MvvmNamespaceDefinition, XmlNamespaceConstants.MvvmPrefix)]
[assembly: XmlnsDefinition(XmlNamespaceConstants.MvvmNamespaceDefinition, XmlNamespaceConstants.MvvmNamespace)]

[assembly: XmlnsPrefix(XmlNamespaceConstants.GanttNamespaceDefinition, XmlNamespaceConstants.GanttPrefix)]
[assembly: XmlnsDefinition(XmlNamespaceConstants.GanttNamespaceDefinition, XmlNamespaceConstants.GanttNamespace)]


[assembly: AssemblyVersion("21.1.0")]
[assembly: AssemblyFileVersion("21.1.0")]

[assembly: InternalsVisibleTo(MvvmAssemblyHelper.TestsFreeAssemblyName)]
[assembly: InternalsVisibleTo(MvvmAssemblyHelper.MvvmUIAssemblyName)]
