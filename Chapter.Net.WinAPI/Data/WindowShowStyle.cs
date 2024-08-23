// -----------------------------------------------------------------------------------------------------------------
// <copyright file="WindowShowStyle.cs" company="dwndland">
//     Copyright (c) David Wendland. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace

namespace Chapter.Net.WinAPI;

public enum WindowShowStyle : uint
{
    Hide = 0,
    ShowNormal = 1,
    ShowMinimized = 2,
    ShowMaximized = 3,
    Maximize = 3,
    ShowNormalNoActivate = 4,
    Show = 5,
    Minimize = 6,
    ShowMinNoActivate = 7,
    ShowNoActivate = 8,
    Restore = 9,
    ShowDefault = 10,
    ForceMinimized = 11
}