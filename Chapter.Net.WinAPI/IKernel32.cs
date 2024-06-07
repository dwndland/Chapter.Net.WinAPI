// -----------------------------------------------------------------------------------------------------------------
// <copyright file="IKernel32.cs" company="my-libraries">
//     Copyright (c) David Wendland. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------------------------------------------------

using System;

namespace Chapter.Net.WinAPI;

public interface IKernel32
{
    IntPtr LoadLibrary(string lpFileName);

    IntPtr GetModuleHandle(string moduleName);
}