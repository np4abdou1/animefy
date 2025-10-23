using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using System.Security;
using System.Security.Permissions;
using Android.Runtime;

[assembly: AssemblyVersion("1.0.0.0")]
[assembly: NamespaceMapping(Java = "org.intellij.lang.annotations", Managed = "IntelliJ.Lang.Annotations")]
[assembly: NamespaceMapping(Java = "org.jetbrains.annotations", Managed = "JetBrains.Annotations")]
[assembly: AssemblyMetadata("IsTrimmable", "True")]
[assembly: AssemblyCompany("Microsoft")]
[assembly: AssemblyConfiguration("Release")]
[assembly: AssemblyCopyright("© Microsoft Corporation. All rights reserved.")]
[assembly: AssemblyDescription(".NET for Android (formerly Xamarin.Android) binding for Kotlin Standard Library")]
[assembly: AssemblyFileVersion("24.0.1")]
[assembly: AssemblyInformationalVersion("24.0.1.4")]
[assembly: AssemblyProduct("Xamarin.Jetbrains.Annotations")]
[assembly: AssemblyTitle("Xamarin.Jetbrains.Annotations")]
[assembly: AssemblyMetadata("RepositoryUrl", "https://github.com/xamarin/AndroidX.git")]
[assembly: SecurityPermission(SecurityAction.RequestMinimum, SkipVerification = true)]
[module: RefSafetyRules(11)]
