// -----------------------------------------------------------------------------------------------------------------
// <copyright file="DwmapiWrapper.cs" company="my-libraries">
//     Copyright (c) David Wendland. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------------------------------------------------

using System;

// ReSharper disable once CheckNamespace

namespace Chapter.Net.WinAPI
{
    public class DwmapiWrapper : IDwmapi
    {
        public int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize)
        {
            return Dwmapi.DwmSetWindowAttribute(hwnd, attr, ref attrValue, attrSize);
        }
    }
}