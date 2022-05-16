using System.Windows.Markup;
using System.Resources;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using System;
using System.Security;
using DevBot9.Internal;
using DevBot9.Mvvm.Native;

[assembly: AssemblyTitle("DevBot9.Mvvm.UI")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("devbotas")]
[assembly: AssemblyProduct("DevBot9.Mvvm.UI")]
[assembly: AssemblyCopyright("Copyright © 2000-2021 Developer Express Inc., devbotas")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: ThemeInfo(ResourceDictionaryLocation.None, ResourceDictionaryLocation.SourceAssembly)]

[assembly: CLSCompliant(true)]
[assembly: AllowPartiallyTrustedCallers]

[assembly: SatelliteContractVersion(AssemblyInfo.SatelliteContractVersion)]
[assembly: ComVisible(false)]
[assembly: NeutralResourcesLanguage("en-US")]

[assembly: XmlnsDefinition(XmlNamespaceConstants.PresentationNamespaceDefinition, XmlNamespaceConstants.DXBindingNamespace)]
[assembly: XmlnsPrefix(XmlNamespaceConstants.MvvmNamespaceDefinition, XmlNamespaceConstants.MvvmPrefix)]
[assembly: XmlnsDefinition(XmlNamespaceConstants.MvvmNamespaceDefinition, XmlNamespaceConstants.MvvmUINamespace)]
[assembly: XmlnsDefinition(XmlNamespaceConstants.MvvmNamespaceDefinition, XmlNamespaceConstants.MvvmInteractivityNamespace)]
[assembly: XmlnsPrefix(XmlNamespaceConstants.MvvmInternalNamespaceDefinition, XmlNamespaceConstants.MvvmIntenalPrefix)]
[assembly: XmlnsDefinition(XmlNamespaceConstants.MvvmInternalNamespaceDefinition, XmlNamespaceConstants.MvvmInteractivityInternalNamespace)]

[assembly: AssemblyVersion("21.1.0")]
[assembly: AssemblyFileVersion("21.1.0")]

[assembly: InternalsVisibleTo(MvvmAssemblyHelper.TestsFreeAssemblyName)]
