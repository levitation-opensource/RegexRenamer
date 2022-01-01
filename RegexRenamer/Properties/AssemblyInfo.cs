/* =============================================================================
 * RegexRenamer                                     Copyright (c) 2011 Xiperware
 * https://github.com/Sukram21/RegexRenamer/                      sukram.mueller@gmail.com
 * 
 * This program is free software; you can redistribute it and/or modify it under
 * the terms of the GNU General Public License v2, as published by the Free
 * Software Foundation.
 * 
 * This program is distributed in the hope that it will be useful, but WITHOUT
 * ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS
 * FOR A PARTICULAR PURPOSE. See the GNU General Public License for more details.
 * =============================================================================
 */


using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.ConstrainedExecution;
using System.Security;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle( "RegexRenamer" )]
[assembly: AssemblyDescription( "RegexRenamer is a powerful user-friendly graphical tool used to batch rename files using regular expressions." )]
[assembly: AssemblyConfiguration( "" )]
[assembly: AssemblyCompany( "Xiperware" )]
[assembly: AssemblyProduct( "" )]
[assembly: AssemblyCopyright( "Copyright © 2011 Xiperware" )]
[assembly: AssemblyTrademark( "" )]
[assembly: AssemblyCulture( "" )]
/*comment-out to avoid System.TypeLoadException: 'Inheritance security rules violated while overriding member: ...' 

and 

System.MethodAccessException: 'Attempt by security transparent method 'Furty.Windows.Forms.ExtractIcons.GetDesktopIcon()' to access security critical method 'Furty.Windows.Forms.ExtractIcons.ExtractIconEx(System.String, Int32, IntPtr[], IntPtr[], UInt32)' failed.

Assembly 'RegexRenamer, Version=1.3.1.0, Culture=neutral, PublicKeyToken=null' is marked with the AllowPartiallyTrustedCallersAttribute, and uses the level 2 security transparency model.Level 2 transparency causes all methods in AllowPartiallyTrustedCallers assemblies to become security transparent by default, which may be the cause of this exception.'*/
//[assembly: AllowPartiallyTrustedCallers]  

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible( false )]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid( "64e4b43e-0fbb-4953-b77d-bef3643ac4db" )]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
[assembly: AssemblyVersion( "1.3.1.1" )]
[assembly: AssemblyFileVersion( "1.3.1.1" )]
