// -----------------------------------------------------------------------------------------------------------------
// <copyright file="Kernel32Wrapper.cs" company="my-libraries">
//     Copyright (c) David Wendland. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------------------------------------------------

using System;

// ReSharper disable once CheckNamespace

namespace Chapter.Net.WinAPI
{
    public class Kernel32Wrapper : IKernel32
    {
        public IntPtr LoadLibrary(string lpFileName)
        {
            return Kernel32.LoadLibrary(lpFileName);
        }

        public IntPtr GetModuleHandle(string moduleName)
        {
            return Kernel32.GetModuleHandle(moduleName);
        }
    }
}