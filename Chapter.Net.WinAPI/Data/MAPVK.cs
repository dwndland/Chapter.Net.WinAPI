// -----------------------------------------------------------------------------------------------------------------
// <copyright file="MAPVK.cs" company="my-libraries">
//     Copyright (c) David Wendland. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace

namespace Chapter.Net.WinAPI;

public enum MAPVK : uint
{
    VK_TO_VSC = 0x0,
    VSC_TO_VK = 0x1,
    VK_TO_CHAR = 0x2,
    VSC_TO_VK_EX = 0x3
}