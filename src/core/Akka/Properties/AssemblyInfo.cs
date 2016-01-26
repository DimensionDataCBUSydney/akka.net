//-----------------------------------------------------------------------
// <copyright file="AssemblyInfo.cs" company="Akka.NET Project">
//     Copyright (C) 2009-2015 Typesafe Inc. <http://www.typesafe.com>
//     Copyright (C) 2013-2015 Akka.NET project <https://github.com/akkadotnet/akka.net>
// </copyright>
//-----------------------------------------------------------------------

using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.

[assembly: AssemblyTitle("Akka")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyProduct("Akka")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.

[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM

[assembly: Guid("1a5cab08-b032-49ca-8db3-9428c5a9db14")]
[assembly: InternalsVisibleTo("Akka.Tests, PublicKey=00240000048000009400000006020000002400005253413100040000010001001dc8f68e8ed71454098eb6a2712f1125b91fa67a40ee2df1859cc2c9fa7935db2eacd24bc2b05ae3c673d4cee0960edfc3bc4eabed5cbfd84a28d16d6a690457bfbf2ce23e7fdd43b147fca4656f847a34b9ebd49ca8ac8d7985d5caa3d0b336749a4c443472b1c06455e4b6feb80308cde299680f96791ea7ea6167b04e14d4")]
[assembly: InternalsVisibleTo("Akka.Tests.Performance, PublicKey=00240000048000009400000006020000002400005253413100040000010001001dc8f68e8ed71454098eb6a2712f1125b91fa67a40ee2df1859cc2c9fa7935db2eacd24bc2b05ae3c673d4cee0960edfc3bc4eabed5cbfd84a28d16d6a690457bfbf2ce23e7fdd43b147fca4656f847a34b9ebd49ca8ac8d7985d5caa3d0b336749a4c443472b1c06455e4b6feb80308cde299680f96791ea7ea6167b04e14d4")]
[assembly: InternalsVisibleTo("Akka.TestKit, PublicKey=00240000048000009400000006020000002400005253413100040000010001001dc8f68e8ed71454098eb6a2712f1125b91fa67a40ee2df1859cc2c9fa7935db2eacd24bc2b05ae3c673d4cee0960edfc3bc4eabed5cbfd84a28d16d6a690457bfbf2ce23e7fdd43b147fca4656f847a34b9ebd49ca8ac8d7985d5caa3d0b336749a4c443472b1c06455e4b6feb80308cde299680f96791ea7ea6167b04e14d4")]
[assembly: InternalsVisibleTo("Akka.TestKit.Tests, PublicKey=00240000048000009400000006020000002400005253413100040000010001001dc8f68e8ed71454098eb6a2712f1125b91fa67a40ee2df1859cc2c9fa7935db2eacd24bc2b05ae3c673d4cee0960edfc3bc4eabed5cbfd84a28d16d6a690457bfbf2ce23e7fdd43b147fca4656f847a34b9ebd49ca8ac8d7985d5caa3d0b336749a4c443472b1c06455e4b6feb80308cde299680f96791ea7ea6167b04e14d4")]
[assembly: InternalsVisibleTo("Akka.Remote, PublicKey=00240000048000009400000006020000002400005253413100040000010001001dc8f68e8ed71454098eb6a2712f1125b91fa67a40ee2df1859cc2c9fa7935db2eacd24bc2b05ae3c673d4cee0960edfc3bc4eabed5cbfd84a28d16d6a690457bfbf2ce23e7fdd43b147fca4656f847a34b9ebd49ca8ac8d7985d5caa3d0b336749a4c443472b1c06455e4b6feb80308cde299680f96791ea7ea6167b04e14d4")]
[assembly: InternalsVisibleTo("Akka.Remote.Tests, PublicKey=00240000048000009400000006020000002400005253413100040000010001001dc8f68e8ed71454098eb6a2712f1125b91fa67a40ee2df1859cc2c9fa7935db2eacd24bc2b05ae3c673d4cee0960edfc3bc4eabed5cbfd84a28d16d6a690457bfbf2ce23e7fdd43b147fca4656f847a34b9ebd49ca8ac8d7985d5caa3d0b336749a4c443472b1c06455e4b6feb80308cde299680f96791ea7ea6167b04e14d4")]
[assembly: InternalsVisibleTo("Akka.Cluster, PublicKey=00240000048000009400000006020000002400005253413100040000010001001dc8f68e8ed71454098eb6a2712f1125b91fa67a40ee2df1859cc2c9fa7935db2eacd24bc2b05ae3c673d4cee0960edfc3bc4eabed5cbfd84a28d16d6a690457bfbf2ce23e7fdd43b147fca4656f847a34b9ebd49ca8ac8d7985d5caa3d0b336749a4c443472b1c06455e4b6feb80308cde299680f96791ea7ea6167b04e14d4")]
[assembly: InternalsVisibleTo("Akka.Cluster.Tests, PublicKey=00240000048000009400000006020000002400005253413100040000010001001dc8f68e8ed71454098eb6a2712f1125b91fa67a40ee2df1859cc2c9fa7935db2eacd24bc2b05ae3c673d4cee0960edfc3bc4eabed5cbfd84a28d16d6a690457bfbf2ce23e7fdd43b147fca4656f847a34b9ebd49ca8ac8d7985d5caa3d0b336749a4c443472b1c06455e4b6feb80308cde299680f96791ea7ea6167b04e14d4")]
[assembly: InternalsVisibleTo("Akka.MultiNodeTestRunner.Shared.Tests, PublicKey=00240000048000009400000006020000002400005253413100040000010001001dc8f68e8ed71454098eb6a2712f1125b91fa67a40ee2df1859cc2c9fa7935db2eacd24bc2b05ae3c673d4cee0960edfc3bc4eabed5cbfd84a28d16d6a690457bfbf2ce23e7fdd43b147fca4656f847a34b9ebd49ca8ac8d7985d5caa3d0b336749a4c443472b1c06455e4b6feb80308cde299680f96791ea7ea6167b04e14d4")]
[assembly: InternalsVisibleTo("Akka.Cluster.Tests.MultiNode, PublicKey=00240000048000009400000006020000002400005253413100040000010001001dc8f68e8ed71454098eb6a2712f1125b91fa67a40ee2df1859cc2c9fa7935db2eacd24bc2b05ae3c673d4cee0960edfc3bc4eabed5cbfd84a28d16d6a690457bfbf2ce23e7fdd43b147fca4656f847a34b9ebd49ca8ac8d7985d5caa3d0b336749a4c443472b1c06455e4b6feb80308cde299680f96791ea7ea6167b04e14d4")]
