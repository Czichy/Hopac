﻿namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("Hopac.Platform.Net")>]
[<assembly: AssemblyProductAttribute("Hopac.Platform.Net")>]
[<assembly: AssemblyDescriptionAttribute("A library for Higher-Order, Parallel, Asynchronous and Concurrent programming in F#.")>]
[<assembly: AssemblyVersionAttribute("0.2.0")>]
[<assembly: AssemblyFileVersionAttribute("0.2.0")>]
[<assembly: AssemblyCompanyAttribute("Housemarque Inc.")>]
[<assembly: AssemblyCopyrightAttribute("© Housemarque Inc.")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.2.0"
    let [<Literal>] InformationalVersion = "0.2.0"
