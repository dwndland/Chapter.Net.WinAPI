// -----------------------------------------------------------------------------------------------------------------
// <copyright file="UxTheme.cs" company="dwndland">
//     Copyright (c) David Wendland. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------------------------------------------------

using System;
using System.Runtime.InteropServices;

namespace Chapter.Net.WinAPI;

public static class UxTheme
{
    [DllImport("uxtheme.dll", EntryPoint = "#98", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
    public static extern uint GetImmersiveUserColorSetPreference(bool forceCheckRegistry, bool skipCheckOnFail);

    [DllImport("uxtheme.dll", EntryPoint = "#94", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
    public static extern uint GetImmersiveColorSetCount();

    [DllImport("uxtheme.dll", EntryPoint = "#95", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
    public static extern uint GetImmersiveColorFromColorSetEx(uint immersiveColorSet, uint immersiveColorType, bool ignoreHighContrast, uint highContrastCacheMode);

    [DllImport("uxtheme.dll", EntryPoint = "#96", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
    public static extern uint GetImmersiveColorTypeFromName(IntPtr name);

    [DllImport("uxtheme.dll", EntryPoint = "#100", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
    public static extern IntPtr GetImmersiveColorNamedTypeByIndex(uint index);
}