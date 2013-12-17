(*** hide ***)
#I "../../bin"
#I @"C:\Program Files (x86)\Reference Assemblies\Microsoft\WindowsPowerShell\3.0"

(**
The PowerShell type provider
============================

Requirements:

- .NET 4.5
- PowerShell 3.0

This tutorial shows the use of the PowerShell type provider.
*)

// reference the type provider dll
#r "System.Management.Automation.dll"
#r "FSharp.Management.dll"
open FSharpx

// Let the type provider to inference signatures of available cmdlets
type PS = PowerShellProvider< PSSnapIns="", Is64BitRequired=false >

// now you have typed access to your filesystem and you can browse it via Intellisense
PS.``Get-Process``(name=[|"devenv"|])
// [fsi:val it :
//  Choice<List<System.Diagnostics.Process>,
//         List<System.Diagnostics.FileVersionInfo>,
//         List<System.Diagnostics.ProcessModule>,
//         List<System.Management.Automation.PSObject>> =
//  Choice1Of4
//    [System.Diagnostics.Process (devenv)
//       {...}]]

(**

![alt text](img/PowerShellProvider.png "Intellisense for the PowerShell")

*)