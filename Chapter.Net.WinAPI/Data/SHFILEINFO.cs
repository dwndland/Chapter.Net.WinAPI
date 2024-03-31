// -----------------------------------------------------------------------------------------------------------------
// <copyright file="SHFILEINFO.cs" company="my-libraries">
//     Copyright (c) David Wendland. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------------------------------------------------

using System;
using System.Runtime.InteropServices;

// ReSharper disable once CheckNamespace

namespace Chapter.Net.WinAPI
{
    [StructLayout(LayoutKind.Sequential)]
    public struct SHFILEINFO
    {
        public readonly IntPtr hIcon;
        private readonly int iIcon;
        private readonly uint dwAttributes;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
        private readonly string szDisplayName;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
        private readonly string szTypeName;
    }
}