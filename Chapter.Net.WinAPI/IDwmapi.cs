// -----------------------------------------------------------------------------------------------------------------
// <copyright file="IDwmapi.cs" company="my-libraries">
//     Copyright (c) David Wendland. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------------------------------------------------

using System;

namespace Chapter.Net.WinAPI;

public interface IDwmapi
{
    int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
}