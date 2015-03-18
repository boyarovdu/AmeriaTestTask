using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[assembly: AssemblyCompany("BoyarovDavid")]
[assembly: AssemblyCopyright("Copyright © 2013 BoyarovDavid")]
[assembly: AssemblyProduct("BoyarovDavid.SurveyService")]

#if DEBUG

[assembly: AssemblyConfiguration("debug")]
#else
[assembly: AssemblyConfiguration("retail")]
#endif

[assembly: ComVisible(false)]
[assembly: InternalsVisibleTo("BoyarovDavid.SurveyService.Tests")]
