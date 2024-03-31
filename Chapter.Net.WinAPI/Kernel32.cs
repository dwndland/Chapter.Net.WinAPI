// -----------------------------------------------------------------------------------------------------------------
// <copyright file="Kernel32.cs" company="my-libraries">
//     Copyright (c) David Wendland. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------------------------------------------------

using System;
using System.Runtime.InteropServices;

namespace Chapter.Net.WinAPI
{
    public static class Kernel32
    {
        [DllImport("kernel32.dll")]
        public static extern IntPtr LoadLibrary(string lpFileName);

        [DllImport("kernel32.dll")]
        public static extern IntPtr GetModuleHandle(string moduleName);
    }
}